using System;
using System.IO;
using GroupDocs.Conversion.Options.Convert;

namespace GroupDocs.Conversion.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to convert RTF file into PNG format.
    /// For more details about Rich Text File Format (.rtf) to Portable Network Graphic (.png) conversion please check this documentation article 
    /// https://docs.groupdocs.com/conversion/net/convert-rtf-to-png
    /// </summary>
    internal static class ConvertRtfToPng
    {
        public static void Run()
        {
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFileTemplate = Path.Combine(outputFolder, "converted-page-{0}.png");
            Func<int, Stream> getPageStream = page => new FileStream(string.Format(outputFileTemplate, page), FileMode.Create);

            // Load the source RTF file
            using (Converter converter = new GroupDocs.Conversion.Converter(Constants.SAMPLE_RTF))
            {
                // Set the convert options for PNG format
                ImageConvertOptions options = new ImageConvertOptions { Format = GroupDocs.Conversion.FileTypes.ImageFileType.Png };  
                // Convert to PNG format
                converter.Convert(getPageStream, options);
            }

            Console.WriteLine("\nConversion to png completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}