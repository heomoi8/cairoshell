﻿#pragma checksum "..\..\CairoSettingsWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B3D370110B4BFBDA0F137BBEC75FE283"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CairoDesktop.Properties;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace CairoDesktop {
    
    
    /// <summary>
    /// CairoSettingsWindow
    /// </summary>
    public partial class CairoSettingsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 308 "..\..\CairoSettingsWindow.xaml"
        internal System.Windows.Controls.TextBox timeSetting;
        
        #line default
        #line hidden
        
        
        #line 318 "..\..\CairoSettingsWindow.xaml"
        internal System.Windows.Controls.TextBox dateSetting;
        
        #line default
        #line hidden
        
        
        #line 322 "..\..\CairoSettingsWindow.xaml"
        internal System.Windows.Controls.TabItem restartButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CairoDesktop;component/cairosettingswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CairoSettingsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\CairoSettingsWindow.xaml"
            ((CairoDesktop.CairoSettingsWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 178 "..\..\CairoSettingsWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.EnableDesktop_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 184 "..\..\CairoSettingsWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.EnableDynamicDesktop_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 220 "..\..\CairoSettingsWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.EnableTaskbar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 287 "..\..\CairoSettingsWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.EnableMenuBarShadow_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 293 "..\..\CairoSettingsWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuBarWhite_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 299 "..\..\CairoSettingsWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.EnableSysTray_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.timeSetting = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.dateSetting = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.restartButton = ((System.Windows.Controls.TabItem)(target));
            
            #line 322 "..\..\CairoSettingsWindow.xaml"
            this.restartButton.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.restartCairo);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
