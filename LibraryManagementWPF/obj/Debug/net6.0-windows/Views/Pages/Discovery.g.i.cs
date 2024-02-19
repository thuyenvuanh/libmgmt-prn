﻿#pragma checksum "..\..\..\..\..\Views\Pages\Discovery.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D3EED7C04C8F2379D40F2B08AEEFEBBF84905370"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace LibraryManagementWPF.Views.Pages {
    
    
    /// <summary>
    /// Discovery
    /// </summary>
    public partial class Discovery : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\Views\Pages\Discovery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid RootPage;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\Views\Pages\Discovery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock pageTitle;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\Views\Pages\Discovery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.Button btnRefresh;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\Views\Pages\Discovery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.TextBox tbxSearchBook;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Views\Pages\Discovery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\Views\Pages\Discovery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnlBookSelected;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Views\Pages\Discovery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.Button btnBorrow;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\Views\Pages\Discovery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.Button btnDetails;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\Views\Pages\Discovery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.DataGrid dgvBook;
        
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
            System.Uri resourceLocater = new System.Uri("/LibraryManagementWPF;component/views/pages/discovery.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Pages\Discovery.xaml"
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
            this.RootPage = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.pageTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btnRefresh = ((Wpf.Ui.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\Views\Pages\Discovery.xaml"
            this.btnRefresh.Click += new System.Windows.RoutedEventHandler(this.btnRefresh_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbxSearchBook = ((Wpf.Ui.Controls.TextBox)(target));
            return;
            case 5:
            this.btnSearch = ((Wpf.Ui.Controls.Button)(target));
            
            #line 33 "..\..\..\..\..\Views\Pages\Discovery.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.pnlBookSelected = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.btnBorrow = ((Wpf.Ui.Controls.Button)(target));
            
            #line 36 "..\..\..\..\..\Views\Pages\Discovery.xaml"
            this.btnBorrow.Click += new System.Windows.RoutedEventHandler(this.btnBorrow_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnDetails = ((Wpf.Ui.Controls.Button)(target));
            
            #line 41 "..\..\..\..\..\Views\Pages\Discovery.xaml"
            this.btnDetails.Click += new System.Windows.RoutedEventHandler(this.btnDetails_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dgvBook = ((Wpf.Ui.Controls.DataGrid)(target));
            
            #line 54 "..\..\..\..\..\Views\Pages\Discovery.xaml"
            this.dgvBook.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgvBook_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

