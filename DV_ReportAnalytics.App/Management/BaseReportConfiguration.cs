using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DV_ReportAnalytics.Management
{
    internal abstract class BaseReportConfiguration : ConfigurationSection
    {
        public abstract object AccessibleProperties { get; }
    }
}
