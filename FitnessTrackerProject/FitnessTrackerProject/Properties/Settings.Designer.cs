﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessTrackerProject.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-EFAN90DG\\SQLEXPRESS;Initial Catalog=fitnesstrackerdatabase;Int" +
            "egrated Security=True")]
        public string fitnesstrackerdatabaseConnectionString {
            get {
                return ((string)(this["fitnesstrackerdatabaseConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-EFAN90DG\\SQLEXPRESS;Initial Catalog=FitnessT;Integrated Securi" +
            "ty=True")]
        public string FitnessTConnectionString {
            get {
                return ((string)(this["FitnessTConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-EFAN90DG\\SQLEXPRESS;Initial Catalog=FitnessTrackerDB;Integrate" +
            "d Security=True")]
        public string FitnessTrackerDBConnectionString {
            get {
                return ((string)(this["FitnessTrackerDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-EFAN90DG\\SQLEXPRESS;Initial Catalog=db;Integrated Security=Tru" +
            "e")]
        public string dbConnectionString {
            get {
                return ((string)(this["dbConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-EFAN90DG\\SQLEXPRESS;Initial Catalog=FitnesstranckerDB;Integrat" +
            "ed Security=True")]
        public string FitnesstranckerDBConnectionString {
            get {
                return ((string)(this["FitnesstranckerDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-EFAN90DG\\SQLEXPRESS;Initial Catalog=DBfitness;Integrated Secur" +
            "ity=True")]
        public string DBfitnessConnectionString {
            get {
                return ((string)(this["DBfitnessConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-EFAN90DG\\SQLEXPRESS;Initial Catalog=FitnessDB;Integrated Secur" +
            "ity=True")]
        public string FitnessDBConnectionString {
            get {
                return ((string)(this["FitnessDBConnectionString"]));
            }
        }
    }
}
