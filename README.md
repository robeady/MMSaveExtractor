# MMSaveExtractor
Facilitates MM save-game editing.

This application can unpack MM .sav files into a pair of JSON files, which can then be edited using any text editor. It can also repack this pair of files into a MM .sav file.

The Save Info file contains information such as save statistics, your team colours, models and textures, mods used and DLC.

The Game Data file is a complete representation of the game state. Beware! This file is very large (perhaps several hundred MB) so you will need a serious text editor to view it. My personal recommendation is Sublime Text.

Usage of the program should be self explanatory. Be sure to choose the correct mode (unpack/pack) first.

Requires .NET framework version 4.5.

Please report any issues or suggestions on [RaceDepartment](http://www.racedepartment.com/threads/save-extractor.133659/).

# For developers

Any contributions are welcome! The code is pretty short so I left it all in `Form1.cs`.

Dependencies: I am using the lz4net library for LZ4 compression/decompression, and Newtonsoft's Json.NET library to reformat the output JSON files so they are human editable (just about).
