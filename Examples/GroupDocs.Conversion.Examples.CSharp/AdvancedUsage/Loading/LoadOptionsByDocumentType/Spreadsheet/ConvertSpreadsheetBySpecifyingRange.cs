﻿using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;
using GroupDocs.Conversion.Options.Load;

namespace GroupDocs.Conversion.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to convert a spreadsheet document to pdf with advanced options
    /// </summary>
    internal static class ConvertSpreadsheetBySpecifyingRange
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "converted.pdf");

            Func<LoadOptions> getLoadOptions = () => new SpreadsheetLoadOptions
            {
                ConvertRange = "10:30",
                OnePagePerSheet = true
            };

            using (Converter converter = new Converter(Constants.SAMPLE_XLSX, getLoadOptions))
            {
                PdfConvertOptions options = new PdfConvertOptions();
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nSpreadsheet document converted successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
