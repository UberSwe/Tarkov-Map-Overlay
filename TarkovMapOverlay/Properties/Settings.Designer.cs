﻿namespace TarkovMapOverlay.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public double windowTop {
            get {
                return ((double)(this["windowTop"]));
            }
            set {
                this["windowTop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public double windowLeft {
            get {
                return ((double)(this["windowLeft"]));
            }
            set {
                this["windowLeft"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("420")]
        public double windowWidth {
            get {
                return ((double)(this["windowWidth"]));
            }
            set {
                this["windowWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("300")]
        public double windowHeight {
            get {
                return ((double)(this["windowHeight"]));
            }
            set {
                this["windowHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public double visual_opacity {
            get {
                return ((double)(this["visual_opacity"]));
            }
            set {
                this["visual_opacity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool visual_transparency {
            get {
                return ((bool)(this["visual_transparency"]));
            }
            set {
                this["visual_transparency"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string currentMapPath {
            get {
                return ((string)(this["currentMapPath"]));
            }
            set {
                this["currentMapPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>\"\"</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection customMapList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["customMapList"]));
            }
            set {
                this["customMapList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool minimizeWithMouseButton {
            get {
                return ((bool)(this["minimizeWithMouseButton"]));
            }
            set {
                this["minimizeWithMouseButton"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("M")]
        public global::System.Windows.Forms.Keys minimizeKey {
            get {
                return ((global::System.Windows.Forms.Keys)(this["minimizeKey"]));
            }
            set {
                this["minimizeKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public global::System.Windows.Forms.MouseButtons minimizeMousebutton {
            get {
                return ((global::System.Windows.Forms.MouseButtons)(this["minimizeMousebutton"]));
            }
            set {
                this["minimizeMousebutton"] = value;
            }
        }
    }
}
