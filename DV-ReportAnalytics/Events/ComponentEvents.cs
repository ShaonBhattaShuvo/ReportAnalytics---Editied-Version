using System;

namespace DV_ReportAnalytics.Events
{
    internal class FileBrowserWithLabelUpdateEventArgs : EventArgs
    {
        public string Path { get; }
        public bool OK { get; }
        public FileBrowserWithLabelUpdateEventArgs(string path, bool ok)
        {
            Path = path;
            OK = ok;
        }
    }
    internal delegate void FileBrowserWithLabelUpdateEventHandler(object sender, FileBrowserWithLabelUpdateEventArgs e);
}
