﻿#pragma checksum "E:\DAM\Segundo\DEINT\Unidades\Ejercicios\09-EjercicioControles\09-EjercicioControles\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AD6093D2D0EBCD2B71BAFD38A0C289CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _09_EjercicioControles
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 31
                {
                    this.botones = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 3: // MainPage.xaml line 52
                {
                    this.btnPagina2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnPagina2).Click += this.btnPagina2_Click;
                }
                break;
            case 4: // MainPage.xaml line 105
                {
                    this.sld1 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 5: // MainPage.xaml line 32
                {
                    this.btnCancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6: // MainPage.xaml line 33
                {
                    this.btnDefault = (global::Windows.UI.Xaml.Controls.Button)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

