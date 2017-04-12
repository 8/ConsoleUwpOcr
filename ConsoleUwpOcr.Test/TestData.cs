namespace ConsoleUwpOcr.Test
{
    using System.IO;
    using System.Reflection;

    public static class TestData
    {
        public static string GetFilePath(string fileName)
        {
            string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string testDataFolder = Path.Combine(assemblyFolder, "TestData");

            return Path.Combine(testDataFolder, fileName);
        }
    }
}
