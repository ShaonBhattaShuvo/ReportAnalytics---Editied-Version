﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DV_ReportAnalytics.App.Configurations {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.1.0.0")]
    internal sealed partial class EPTConfig : global::System.Configuration.ApplicationSettingsBase {
        
        private static EPTConfig defaultInstance = ((EPTConfig)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new EPTConfig())));
        
        public static EPTConfig Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("EPT Report Results")]
        public string ReportName {
            get {
                return ((string)(this["ReportName"]));
            }
            set {
                this["ReportName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Results")]
        public string InputSheetName {
            get {
                return ((string)(this["InputSheetName"]));
            }
            set {
                this["InputSheetName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CombinedResults")]
        public string OutputSheetName {
            get {
                return ((string)(this["OutputSheetName"]));
            }
            set {
                this["OutputSheetName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Name_Speed_Torque")]
        public string Parameter {
            get {
                return ((string)(this["Parameter"]));
            }
            set {
                this["Parameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("_")]
        public char Delimiter {
            get {
                return ((char)(this["Delimiter"]));
            }
            set {
                this["Delimiter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("A")]
        public string ParameterColumn {
            get {
                return ((string)(this["ParameterColumn"]));
            }
            set {
                this["ParameterColumn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D")]
        public string ValueColumn {
            get {
                return ((string)(this["ValueColumn"]));
            }
            set {
                this["ValueColumn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int RowInterp {
            get {
                return ((int)(this["RowInterp"]));
            }
            set {
                this["RowInterp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ColumnInterp {
            get {
                return ((int)(this["ColumnInterp"]));
            }
            set {
                this["ColumnInterp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int MaxItemsPerRow {
            get {
                return ((int)(this["MaxItemsPerRow"]));
            }
            set {
                this["MaxItemsPerRow"] = value;
            }
        }
    }
}
