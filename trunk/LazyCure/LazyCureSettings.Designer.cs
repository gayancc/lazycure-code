﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LifeIdea.LazyCure {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed partial class LazyCureSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static LazyCureSettings defaultInstance = ((LazyCureSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new LazyCureSettings())));
        
        public static LazyCureSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("d:\\Programs\\LazyCure\\TimeLogs")]
        public string TimeLogsFolder {
            get {
                return ((string)(this["TimeLogsFolder"]));
            }
            set {
                this["TimeLogsFolder"] = value;
            }
        }
    }
}
