﻿Console.OutputEncoding = System.Text.Encoding.UTF8;

var lyrics = new HayaletSevgilim();

foreach (var line in lyrics.Lines)
    Console.WriteLine(line);