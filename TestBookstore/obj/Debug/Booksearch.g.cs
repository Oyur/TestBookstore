﻿#pragma checksum "..\..\Booksearch.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "09C43D19F6BFF4BCA90402C926FD41189734397D280C650799DF6A6DCE644154"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using System.Windows.Shell;
using TestBookstore;


namespace TestBookstore {
    
    
    /// <summary>
    /// Booksearch
    /// </summary>
    public partial class Booksearch : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Booksearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BookSearchbox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Booksearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ISBNblock;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Booksearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchBookbtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Booksearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Deletebtn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Booksearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_Updatebtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TestBookstore;component/booksearch.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Booksearch.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BookSearchbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ISBNblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.SearchBookbtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Booksearch.xaml"
            this.SearchBookbtn.Click += new System.Windows.RoutedEventHandler(this.SearchBookbtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Deletebtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Booksearch.xaml"
            this.Deletebtn.Click += new System.Windows.RoutedEventHandler(this.Deletebtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Add_Updatebtn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Booksearch.xaml"
            this.Add_Updatebtn.Click += new System.Windows.RoutedEventHandler(this.Add_Updatebtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

