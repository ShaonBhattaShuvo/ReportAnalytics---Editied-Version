using System;

namespace DV_ReportAnalytics.Events
{
        public class OpenFileEventArgs : EventArgs
        {
            public string Path { get; }

            public OpenFileEventArgs(string path)
            {
                this.Path = path;
            }

        }
        public delegate void OpenFileEventHandler(object sender, OpenFileEventArgs e);
}
