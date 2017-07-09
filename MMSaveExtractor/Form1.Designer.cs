namespace MMSaveEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.packRadioButton = new System.Windows.Forms.RadioButton();
            this.unpackRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataPathTextBox = new System.Windows.Forms.TextBox();
            this.browseDataJsonButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infoPathTextBox = new System.Windows.Forms.TextBox();
            this.browseInfoJsonButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.savPathTextBox = new System.Windows.Forms.TextBox();
            this.browseSavButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.packRadioButton);
            this.panel1.Controls.Add(this.unpackRadioButton);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(384, 341);
            this.panel1.TabIndex = 1;
            // 
            // mainButton
            // 
            this.mainButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainButton.Location = new System.Drawing.Point(122, 304);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(130, 24);
            this.mainButton.TabIndex = 7;
            this.mainButton.Text = "Unpack";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mode:";
            // 
            // packRadioButton
            // 
            this.packRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.packRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.packRadioButton.AutoSize = true;
            this.packRadioButton.Location = new System.Drawing.Point(198, 24);
            this.packRadioButton.MinimumSize = new System.Drawing.Size(70, 0);
            this.packRadioButton.Name = "packRadioButton";
            this.packRadioButton.Size = new System.Drawing.Size(70, 23);
            this.packRadioButton.TabIndex = 18;
            this.packRadioButton.Text = "Pack";
            this.packRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.packRadioButton.UseVisualStyleBackColor = true;
            this.packRadioButton.CheckedChanged += new System.EventHandler(this.packRadioButton_CheckedChanged);
            // 
            // unpackRadioButton
            // 
            this.unpackRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unpackRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.unpackRadioButton.AutoSize = true;
            this.unpackRadioButton.Checked = true;
            this.unpackRadioButton.Location = new System.Drawing.Point(122, 24);
            this.unpackRadioButton.MinimumSize = new System.Drawing.Size(70, 0);
            this.unpackRadioButton.Name = "unpackRadioButton";
            this.unpackRadioButton.Size = new System.Drawing.Size(70, 23);
            this.unpackRadioButton.TabIndex = 17;
            this.unpackRadioButton.TabStop = true;
            this.unpackRadioButton.Text = "Unpack";
            this.unpackRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unpackRadioButton.UseVisualStyleBackColor = true;
            this.unpackRadioButton.CheckedChanged += new System.EventHandler(this.unpackRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dataPathTextBox);
            this.groupBox2.Controls.Add(this.browseDataJsonButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.infoPathTextBox);
            this.groupBox2.Controls.Add(this.browseInfoJsonButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 115);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unpacked";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Game Data JSON file:";
            // 
            // dataPathTextBox
            // 
            this.dataPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPathTextBox.Location = new System.Drawing.Point(9, 39);
            this.dataPathTextBox.Name = "dataPathTextBox";
            this.dataPathTextBox.Size = new System.Drawing.Size(280, 20);
            this.dataPathTextBox.TabIndex = 11;
            // 
            // browseDataJsonButton
            // 
            this.browseDataJsonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseDataJsonButton.Location = new System.Drawing.Point(291, 38);
            this.browseDataJsonButton.Name = "browseDataJsonButton";
            this.browseDataJsonButton.Size = new System.Drawing.Size(58, 22);
            this.browseDataJsonButton.TabIndex = 12;
            this.browseDataJsonButton.Text = "Browse";
            this.browseDataJsonButton.UseVisualStyleBackColor = true;
            this.browseDataJsonButton.Click += new System.EventHandler(this.browseDataJsonButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Save Info JSON file:";
            // 
            // infoPathTextBox
            // 
            this.infoPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPathTextBox.Location = new System.Drawing.Point(9, 83);
            this.infoPathTextBox.Name = "infoPathTextBox";
            this.infoPathTextBox.Size = new System.Drawing.Size(280, 20);
            this.infoPathTextBox.TabIndex = 6;
            // 
            // browseInfoJsonButton
            // 
            this.browseInfoJsonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseInfoJsonButton.Location = new System.Drawing.Point(291, 82);
            this.browseInfoJsonButton.Name = "browseInfoJsonButton";
            this.browseInfoJsonButton.Size = new System.Drawing.Size(58, 22);
            this.browseInfoJsonButton.TabIndex = 9;
            this.browseInfoJsonButton.Text = "Browse";
            this.browseInfoJsonButton.UseVisualStyleBackColor = true;
            this.browseInfoJsonButton.Click += new System.EventHandler(this.browseInfoJsonButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.savPathTextBox);
            this.groupBox1.Controls.Add(this.browseSavButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 71);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Packed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Save file:";
            // 
            // savPathTextBox
            // 
            this.savPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savPathTextBox.Location = new System.Drawing.Point(8, 39);
            this.savPathTextBox.Name = "savPathTextBox";
            this.savPathTextBox.Size = new System.Drawing.Size(280, 20);
            this.savPathTextBox.TabIndex = 6;
            // 
            // browseSavButton
            // 
            this.browseSavButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseSavButton.Location = new System.Drawing.Point(290, 38);
            this.browseSavButton.Name = "browseSavButton";
            this.browseSavButton.Size = new System.Drawing.Size(58, 22);
            this.browseSavButton.TabIndex = 9;
            this.browseSavButton.Text = "Browse";
            this.browseSavButton.UseVisualStyleBackColor = true;
            this.browseSavButton.Click += new System.EventHandler(this.browseSavButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(10000, 380);
            this.MinimumSize = new System.Drawing.Size(260, 380);
            this.Name = "Form1";
            this.Text = "MM Save Extractor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button browseSavButton;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.TextBox savPathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dataPathTextBox;
        private System.Windows.Forms.Button browseDataJsonButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox infoPathTextBox;
        private System.Windows.Forms.Button browseInfoJsonButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton packRadioButton;
        private System.Windows.Forms.RadioButton unpackRadioButton;
    }
}

