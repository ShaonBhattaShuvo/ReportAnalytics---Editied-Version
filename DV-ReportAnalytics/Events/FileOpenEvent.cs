using System;

namespace DV_ReportAnalytics.Events
{
    class FileOpenEventArgs : EventArgs
    {
        public string Path { get; }

        public FileOpenEventArgs(string path)
        {
            Path = path;
        }

    }
    delegate void FileOpenEventHandler(object sender, FileOpenEventArgs e);
}
