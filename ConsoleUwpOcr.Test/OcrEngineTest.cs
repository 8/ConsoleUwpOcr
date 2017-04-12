namespace ConsoleUwpOcr.Test
{
    using System;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using MoreLinq;
    using Windows.Media.Ocr;
    using System.Diagnostics;

    [TestFixture]
    public class OcrEngineTest
    {
        [Test]
        public void OcrEngineTest_AvailableLanguages()
        {
            OcrEngine.AvailableRecognizerLanguages
                .ForEach(l => Console.WriteLine($"DisplayName: {l.DisplayName}, LanguageTag: {l.LanguageTag}"));
        }

        [Test]
        public async Task OcrEngineTest_OcrTest()
        {
            var engine = OcrEngine.TryCreateFromLanguage(new Windows.Globalization.Language("en-US"));
            string filePath = TestData.GetFilePath("testimage.png");
            var file = await Windows.Storage.StorageFile.GetFileFromPathAsync(filePath);
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            var decoder = await Windows.Graphics.Imaging.BitmapDecoder.CreateAsync(stream);
            var softwareBitmap = await decoder.GetSoftwareBitmapAsync();
            var ocrResult = await engine.RecognizeAsync(softwareBitmap);
            Debug.WriteLine(ocrResult.Text);
            return;
        }
    }
}
