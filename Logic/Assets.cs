using System;
using System.IO;

namespace RocPaSors
{
    internal static class Assets
    {
        public static Uri Image(string fileName) => FromBaseDirectory("Assets", "Images", fileName);

        public static Uri Sound(string fileName) => FromBaseDirectory("Assets", "Sounds", fileName);

        private static Uri FromBaseDirectory(params string[] parts)
        {
            string path = AppContext.BaseDirectory;
            foreach (string part in parts)
            {
                path = Path.Combine(path, part);
            }

            return new Uri(path, UriKind.Absolute);
        }
    }
}
