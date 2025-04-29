using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_txt
{
    public static class Manager
    {
        // Default values for file operations
        public static string DefaultFolderPath => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
        public static string DefaultFileName => "NewFile";
        public static string DefaultFileExtension => ".txt";

        public static string FolderPath { get; set; } = DefaultFolderPath;
        public static string FileName { get; set; } = DefaultFileName;
        public static string FileExtension { get; set; } = DefaultFileExtension;
        public static string FilePath => FolderPath + FileName + FileExtension;
    }
}
