using LZ4ps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace MMSaveEditor
{
    public partial class Form1 : Form
    {
        static readonly Guid localLowGuid = new Guid("A520A1A4-1780-4FF6-BD18-167343C5AF16");
        const string savePath = @"Playsport Games\Motorsport Manager\Cloud\Saves";
        const int MAGIC = 1932684653;
        const int VERSION = 4;

        static readonly Encoding UTF8_NO_BOM = new UTF8Encoding(false);

        public Form1()
        {
            InitializeComponent();
            Font = SystemFonts.MessageBoxFont;
        }

        private Mode Mode
        {
            get { return packRadioButton.Checked ? Mode.Pack : Mode.Unpack; }
        }

        private void browseSavButton_Click(object sender, EventArgs e)
        {
            FileDialog d = Mode == Mode.Unpack ? (FileDialog)new OpenFileDialog() : (FileDialog)new SaveFileDialog();
            d.DefaultExt = "sav";
            d.Filter = "MM Save files (*.sav)|*.sav";
            if (savPathTextBox.Text == "")
            {
                d.InitialDirectory = Path.Combine(GetKnownFolderPath(localLowGuid), savePath);
            }
            else
            {
                d.FileName = savPathTextBox.Text;
            }            

            if (d.ShowDialog() == DialogResult.OK)
            {
                savPathTextBox.Text = d.FileName;
                savPathTextBox.SelectionStart = savPathTextBox.Text.Length;
                if (Mode == Mode.Unpack)
                {
                    string dir = Path.GetDirectoryName(d.FileName);
                    string name = Path.GetFileNameWithoutExtension(d.FileName);
                    infoPathTextBox.Text = Path.Combine(dir, name + "_info.json");
                    infoPathTextBox.SelectionStart = infoPathTextBox.Text.Length;
                    dataPathTextBox.Text = Path.Combine(dir, name + "_data.json");
                    dataPathTextBox.SelectionStart = dataPathTextBox.Text.Length;
                }
                
            }
        }

        private void browseInfoJsonButton_Click(object sender, EventArgs e)
        {
            browseJsonFile(infoPathTextBox);
        }

        private void browseDataJsonButton_Click(object sender, EventArgs e)
        {
            browseJsonFile(dataPathTextBox);
        }

        private void browseJsonFile(TextBox filePathTextBox)
        {
            FileDialog d = Mode == Mode.Pack ? (FileDialog)new OpenFileDialog() : (FileDialog)new SaveFileDialog();
            d.DefaultExt = "json";
            d.Filter = "JSON files (*.json)|*.json";
            if (savPathTextBox.Text == "")
            {
                d.InitialDirectory = Path.Combine(GetKnownFolderPath(localLowGuid), savePath);
            }
            else
            {
                d.FileName = filePathTextBox.Text;
            }

            if (d.ShowDialog() == DialogResult.OK)
            {
                filePathTextBox.Text = d.FileName;
                filePathTextBox.SelectionStart = filePathTextBox.Text.Length;
            }
        }

        [DllImport("shell32.dll")]
        private static extern int SHGetKnownFolderPath( [MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, out IntPtr pszPath);

        private static string GetKnownFolderPath(Guid knownFolderId)
        {
            IntPtr pszPath = IntPtr.Zero;
            try
            {
                int hr = SHGetKnownFolderPath(knownFolderId, 0, IntPtr.Zero, out pszPath);
                if (hr >= 0)
                    return Marshal.PtrToStringAuto(pszPath);
                throw Marshal.GetExceptionForHR(hr);
            }
            finally
            {
                if (pszPath != IntPtr.Zero)
                    Marshal.FreeCoTaskMem(pszPath);
            }
        }

        private void packRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMainButtonText();
        }

        private void unpackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMainButtonText();
        }

        private void UpdateMainButtonText()
        {
            mainButton.Text = Mode.ToString();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mode == Mode.Pack)
                {
                    if (File.Exists(savPathTextBox.Text))
                    {
                        if (MessageBox.Show("Save file already exists. Overwrite it?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            return;
                        }
                    }
                    using (new CursorWait())
                    {
                        Pack(savPathTextBox.Text, infoPathTextBox.Text, dataPathTextBox.Text);
                    }

                }
                else
                {
                    if (File.Exists(infoPathTextBox.Text) || File.Exists(dataPathTextBox.Text))
                    {
                        if (MessageBox.Show("Save info or game data file already exists. Overwrite it?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            return;
                        }
                    }
                    using (new CursorWait())
                    {
                        Unpack(savPathTextBox.Text, infoPathTextBox.Text, dataPathTextBox.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private static void Unpack(string savPath, string infoPath, string dataPath)
        {
            using (var r = new BinaryReader(new FileStream(savPath, FileMode.Open)))
            {
                int magic = r.ReadInt32();
                int version = r.ReadInt32();
                if (magic != MAGIC || version != VERSION)
                    throw new FileFormatException("Save file format not recognised");

                int infoLengthEncoded = r.ReadInt32();
                int infoLengthDecoded = r.ReadInt32();

                int dataLengthEncoded = r.ReadInt32();
                int dataLengthDecoded = r.ReadInt32();

                byte[] infoDecoded = LZ4Codec.Decode32(r.ReadBytes(infoLengthEncoded), 0, infoLengthEncoded, infoLengthDecoded);
                byte[] dataDecoded = LZ4Codec.Decode32(r.ReadBytes(dataLengthEncoded), 0, dataLengthEncoded, dataLengthDecoded);

                using (var f = new FileStream(infoPath, FileMode.Create))
                using (var input = new StreamReader(new MemoryStream(infoDecoded), UTF8_NO_BOM))
                using (var output = new StreamWriter(f, UTF8_NO_BOM))
                {
                    JsonReformat(input, output, Formatting.Indented);
                    output.Flush();
                }

                using (var f = new FileStream(dataPath, FileMode.Create))
                using (var input = new StreamReader(new MemoryStream(dataDecoded), UTF8_NO_BOM))
                using (var output = new StreamWriter(f, UTF8_NO_BOM))
                {
                    JsonReformat(input, output, Formatting.Indented);
                    output.Flush();
                }
            }

            GC.Collect();
        }

        private static void Pack(string savPath, string infoPath, string dataPath)
        {
            var infoJsonStream = new MemoryStream();
            var dataJsonStream = new MemoryStream();

            using (var f = new FileStream(infoPath, FileMode.Open))
            using (var input = new StreamReader(f, UTF8_NO_BOM))
            using (var output = new StreamWriter(infoJsonStream, UTF8_NO_BOM, 4096, true))
            {
                JsonReformat(input, output, Formatting.None);
            }      

            using (var f = new FileStream(dataPath, FileMode.Open))
            using (var input = new StreamReader(f, UTF8_NO_BOM))
            using (var output = new StreamWriter(dataJsonStream, UTF8_NO_BOM, 4096, true))
            {
                JsonReformat(input, output, Formatting.None);
            }

            byte[] infoEncoded = LZ4Codec.Encode32(infoJsonStream.GetBuffer(), 0, (int)infoJsonStream.Length);
            byte[] dataEncoded = LZ4Codec.Encode32(dataJsonStream.GetBuffer(), 0, (int)dataJsonStream.Length);

            using (var w = new BinaryWriter(new FileStream(savPath, FileMode.Create)))
            {
                w.Write(MAGIC);
                w.Write(VERSION);

                w.Write(infoEncoded.Length);
                w.Write((int)infoJsonStream.Length);

                w.Write(dataEncoded.Length);
                w.Write((int)dataJsonStream.Length);

                w.Write(infoEncoded);
                w.Write(dataEncoded);

                w.Flush();
            }
        }

        private static void JsonReformat(TextReader input, TextWriter output, Formatting format)
        {
            var jsonReader = new JsonTextReader(input);
            var jsonWriter = new JsonTextWriter(output)
            {
                Formatting = format
            };
            jsonWriter.WriteToken(jsonReader);
        }
    }





    enum Mode
    {
        Unpack, Pack
    }
}
