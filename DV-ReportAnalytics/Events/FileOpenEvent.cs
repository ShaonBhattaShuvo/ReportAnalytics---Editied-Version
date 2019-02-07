using System;

namespace DV_ReportAnalytics.Events
{
        public class FileOpenEventArgs : EventArgs
        {
            public string Path { get; }

            public FileOpenEventArgs(string path)
            {
                Path = path;
            }

        }
        public delegate void FileOpenEventHandler(object sender, FileOpenEventArgs e);
}
