﻿#pragma checksum "C:\Users\cleme\Downloads\GettingStarted\NombreMystereUniversal\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CCCFCC66B46F1C379D9C62F22A8C43D4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NombreMystereUniversal
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 14
                {
                    this.tbInfo = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // MainPage.xaml line 15
                {
                    this.tbNbEssais = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // MainPage.xaml line 16
                {
                    this.tbEssai = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // MainPage.xaml line 17
                {
                    this.btValider = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btValider).Click += this.btValider_Click;
                }
                break;
            case 6: // MainPage.xaml line 18
                {
                    this.btNouvellePartie = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btNouvellePartie).Click += this.btNouvellePartie_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

