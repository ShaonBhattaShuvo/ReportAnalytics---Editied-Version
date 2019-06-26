using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel;

namespace DV_ReportAnalytics.Management
{
    internal sealed class EPTReportSettings : BaseReportConfiguration
    {
        #region GridItems
        private class GridItems
        {
            private EPTReportSettings _source;

            [DisplayName("Type"),
                Description("Type of this report (Read-Only)."),
                Category("Basic")]
            public string Type
            {
                get { return _source.Type; }
            }

            [DisplayName("Report Name"),
                Description("The name of output report. It will show as the title later in report view."),
                Category("Basic"),
                DefaultValue("EPT Report Results")]
            public string ReportName
            {
                get { return _source.ReportName; }
                set { _source.ReportName = value; }
            }


            [DisplayName("Input Sheet Name"),
                Description("Source sheet which contains raw experiment data."),
                Category("Basic"),
                DefaultValue("Results")]
            public string InputSheetName
            {
                get { return _source.InputSheetName; }
                set { _source.InputSheetName = value; }
            }

            [DisplayName("Output Sheet Name"),
                Description("Target sheet which the final result will be put into."),
                Category("Basic"),
                DefaultValue("CombinedResults")]
            public string OutputSheetName
            {
                get { return _source.OutputSheetName; }
                set { _source.OutputSheetName = value; }
            }

            [DisplayName("Parameters"),
                Description("Define how the string of parameter shows in the report. E.g. \"Name_Speed_Torque\""),
                Category("Result Format"),
                DefaultValue("Name_Speed_Torque")]
            public string Parameter
            {
                get { return _source.Parameter; }
                set { _source.Parameter = value; }
            }

            [DisplayName("Delimiter"),
                Description("The delimiter which is used to separate parameter into meaningful groups."),
                Category("Result Format"),
                DefaultValue('_')]
            public char Delimiter
            {
                get { return _source.Delimiter; }
                set { _source.Delimiter = value; }
            }

            [DisplayName("Parameter Column"),
                Description("Source column which parameters belong to. It can be define as letter based e.g. A/CB/DFH, or zero-indexed number e.g. 0/2/10"),
                Category("Result Format"),
                DefaultValue("A")]
            public string ParameterColumn
            {
                get { return _source.ParameterColumn; }
                set { _source.ParameterColumn = value; }
            }

            [DisplayName("Value Column"),
                Description("Source column which values belong to. It can be define as letter based e.g. A/CB/DFH, or zero-indexed number e.g. 0/2/10"),
                Category("Result Format"),
                DefaultValue("D")]
            public string ValueColumn
            {
                get { return _source.ValueColumn; }
                set { _source.ValueColumn = value; }
            }

            public GridItems(EPTReportSettings source)
            {
                _source = source;
            }
        }

        private GridItems _items;

        public override object AccessibleProperties
        {
            get { return _items; }
        }
        #endregion

        public EPTReportSettings()
        {
            _items = new GridItems(this);
        }

        #region Configuration properties
        [ConfigurationProperty(name: "type", DefaultValue = "EPTReport", IsRequired = true)]
        public string Type
        {
            get { return (string)this["type"]; }
        }

        [ConfigurationProperty(name: "reportName", DefaultValue = "EPT Report Results", IsRequired = true)]
        public string ReportName
        {
            get { return (string)this["reportName"]; }
            set { this["reportName"] = value; }
        }

        [ConfigurationProperty(name: "inputSheetName", DefaultValue = "Results", IsRequired = true)]
        public string InputSheetName
        {
            get { return (string)this["inputSheetName"]; }
            set { this["inputSheetName"] = value; }
        }

        [ConfigurationProperty(name: "outputSheetName", DefaultValue = "CombinedResults", IsRequired = true)]
        public string OutputSheetName
        {
            get { return (string)this["outputSheetName"]; }
            set { this["outputSheetName"] = value; }
        }

        [ConfigurationProperty(name: "parameter", DefaultValue = "Name_Speed_Torque", IsRequired = true)]
        public string Parameter
        {
            get { return (string)this["parameter"]; }
            set { this["parameter"] = value; }
        }

        [ConfigurationProperty(name: "delimiter", DefaultValue = '_', IsRequired = true)]
        public char Delimiter
        {
            get { return (char)this["delimiter"]; }
            set { this["delimiter"] = value; }
        }

        [ConfigurationProperty(name: "parameterColumn", DefaultValue = "A", IsRequired = true)]
        [StringValidator(MinLength = 1, MaxLength = 9999, InvalidCharacters = " ~!@#$%^&*()[]{}/;'\"|\\")]
        public string ParameterColumn
        {
            get { return (string)this["parameterColumn"]; }
            set { this["parameterColumn"] = value.ToUpper(); }
        }

        [ConfigurationProperty(name: "valueColumn", DefaultValue = "D", IsRequired = true)]
        [StringValidator(MinLength = 1, MaxLength = 9999, InvalidCharacters = " ~!@#$%^&*()[]{}/;'\"|\\")]
        public string ValueColumn
        {
            get { return (string)this["valueColumn"]; }
            set { this["valueColumn"] = value.ToUpper(); }
        } 
        #endregion
    }

    
    internal sealed class EPTReportDisplays : BaseReportConfiguration
    {
        #region GridItems
        private class GridItems
        {
            private EPTReportDisplays _source;

            [DisplayName("Row Interpolation"),
                Description("Interpolation value which is used for rows."),
                DefaultValue(0)]
            public int RowInterpolation
            {
                get { return _source.RowInterpolation; }
                set { _source.RowInterpolation = value; }
            }

            [DisplayName("Column Interpolation"),
                Description("Interpolation value which is used for columns."),
                DefaultValue(0)]
            public int ColumnInterpolation
            {
                get { return _source.ColumnInterpolation; }
                set { _source.ColumnInterpolation = value; }
            }

            [DisplayName("Maximum Items Per Row"),
                Description("Defines how many items show within one row."),
                DefaultValue(3)]
            public int MaximumItemsPerRow
            {
                get { return _source.MaximumItemsPerRow; }
                set { _source.MaximumItemsPerRow = value; }
            }

            public GridItems(EPTReportDisplays source)
            {
                _source = source;
            }
        }

        private GridItems _items;

        public override object AccessibleProperties
        {
            get { return _items; }
        }
        #endregion

        public EPTReportDisplays()
        {
            _items = new GridItems(this);
        }

        #region Displays properties
        [ConfigurationProperty(name: "rowInterpolation", DefaultValue = 0, IsRequired = true)]
        [IntegerValidator(MinValue = 0, MaxValue = 9999, ExcludeRange = false)]
        public int RowInterpolation
        {
            get { return (int)this["rowInterpolation"]; }
            set { this["rowInterpolation"] = value; }
        }

        [ConfigurationProperty(name: "columnInterpolation", DefaultValue = 0, IsRequired = true)]
        [IntegerValidator(MinValue = 0, MaxValue = 9999, ExcludeRange = false)]
        public int ColumnInterpolation
        {
            get { return (int)this["columnInterpolation"]; }
            set { this["columnInterpolation"] = value; }
        }

        [ConfigurationProperty(name: "maximumItemsPerRow", DefaultValue = 3, IsRequired = true)]
        [IntegerValidator(MinValue = 1, MaxValue = 9999, ExcludeRange = false)]
        public int MaximumItemsPerRow
        {
            get { return (int)this["maximumItemsPerRow"]; }
            set { this["maximumItemsPerRow"] = value; }
        } 
        #endregion
    }
}
