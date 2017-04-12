namespace ConsoleUwpOcr
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Windows.Media.Ocr;
    using Windows.Storage;

    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run(args);
        }

        private void Run(string[] args)
        {
            if (args.Length > 0)
            {
                string fileName = args[0];
                string filePath = Path.GetFullPath(fileName);
                Console.WriteLine(GetStringFromImage(filePath).Result);
            }
            else
                Console.WriteLine("Please supply an image as an argument, e.g. 'ocr.exe image.png'");
        }

        private async Task<string> GetStringFromImage(string filePath)
        {
            var engine = OcrEngine.TryCreateFromLanguage(new Windows.Globalization.Language("en-US"));
            var file = await StorageFile.GetFileFromPathAsync(filePath);
            var stream = await file.OpenAsync(FileAccessMode.Read);
            var decoder = await Windows.Graphics.Imaging.BitmapDecoder.CreateAsync(stream);
            var softwareBitmap = await decoder.GetSoftwareBitmapAsync();
            var ocrResult = await engine.RecognizeAsync(softwareBitmap);
            return ocrResult.Text;
        }
    }
}
