﻿#pragma checksum "..\..\..\Dashboard.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A5B0F2C07E5955E44CA8FE1BCCD15D8EE5097270"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryManagementWPF;
using LibraryManagementWPF.Views.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using System.Windows.Shell;
using Wpf.Ui;
using Wpf.Ui.Controls;
using Wpf.Ui.Converters;
using Wpf.Ui.Markup;


namespace LibraryManagementWPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Wpf.Ui.Controls.FluentWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LibraryManagementWPF.MainWindow dashboard;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid canvasLayer;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.NavigationView RootNavigation;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.NavigationViewItem userInfo;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.NavigationViewItem logOutBtn;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.TitleBar titleBar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LibraryManagementWPF;component/dashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dashboard.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dashboard = ((LibraryManagementWPF.MainWindow)(target));
            return;
            case 2:
            this.canvasLayer = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.RootNavigation = ((Wpf.Ui.Controls.NavigationView)(target));
            
            #line 21 "..\..\..\Dashboard.xaml"
            this.RootNavigation.Navigated += new Wpf.Ui.Controls.TypedEventHandler<Wpf.Ui.Controls.NavigationView, Wpf.Ui.Controls.NavigatedEventArgs>(this.RootNavigation_Navigated);
            
            #line default
            #line hidden
            return;
            case 4:
            this.userInfo = ((Wpf.Ui.Controls.NavigationViewItem)(target));
            return;
            case 5:
            this.logOutBtn = ((Wpf.Ui.Controls.NavigationViewItem)(target));
            
            #line 50 "..\..\..\Dashboard.xaml"
            this.logOutBtn.Click += new System.Windows.RoutedEventHandler(this.logOutBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.titleBar = ((Wpf.Ui.Controls.TitleBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

