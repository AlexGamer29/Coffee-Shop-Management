﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0")]
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
<<<<<<< HEAD
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-5IDUU87;Initial Catalog=CoffeeShop;Integrated Security=True")]
=======
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-TJQFN4F8;Initial Catalog=CoffeeShop;Integrated Security=True")]
>>>>>>> ce2326069e4406ca3270c9eb77d9339b41f13f0d
        public string CoffeeShopConnectionString {
            get {
                return ((string)(this["CoffeeShopConnectionString"]));
            }
        }
    }
}
