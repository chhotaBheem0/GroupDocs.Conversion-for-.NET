using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert DWT file into TEX format.
    /// For more details about AutoCAD Drawing Template (.dwt) to LaTeX Source Document (.tex) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-dwt-to-tex
    /// </summary>
    internal static class ConvertDwtToTex
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "dwt-converted-to.tex");
            
            // Load the source DWT file
            using (var converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_DWT))
            {
                PageDescriptionLanguageConvertOptions options = new PageDescriptionLanguageConvertOptions { Format = GroupDocs.Conversion.FileTypes.PageDescriptionLanguageFileType.Tex };
                // Save converted TEX file
                converter.Convert(outputFile, options);
            }

            Console.WriteLine("\nConversion to tex completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
