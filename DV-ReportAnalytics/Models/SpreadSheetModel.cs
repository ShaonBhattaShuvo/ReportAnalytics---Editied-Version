using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Models
{
    class SpreadSheetModel
    {
        private readonly string _name;
        private string _path;
        public event OpenFileEventHandler OpenFile = null;

        public SpreadSheetModel(string name)
        {
            _name = name;
        }

        public void setFilePath(string path)
        {
            _path = path;
            _OpenFile();
        }

        private void _OpenFile()
        {
            if (OpenFile != null)
            {
                OpenFile.Invoke(this, new OpenFileEventArgs(_path));
            }
        }
    }
}
