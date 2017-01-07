using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;


namespace SimpleReactiveUIDemo
{
    public static class MyPicturesSearch
    {
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        public static async Task<List<Photo>> Search(string searchTerm)
        {
            Trace.WriteLine($"Start search: {searchTerm}");

            DirectoryInfo dir = new DirectoryInfo(path);

            var result = new List<Photo>();
            await Task.Run(() =>
            {
                foreach (var item in dir.EnumerateFiles(searchTerm, SearchOption.AllDirectories))
                {
                    result.Add(new Photo { Title = item.Name, Description = item.FullName, Url = item.FullName });
                }
                Trace.WriteLine($"Found {result.Count} images for search of: {searchTerm}");
            });
            return result;
        }
    }
}