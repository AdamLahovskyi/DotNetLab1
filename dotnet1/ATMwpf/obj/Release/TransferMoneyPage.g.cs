﻿#pragma checksum "..\..\TransferMoneyPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F532B2A819B6C674ED3E78F1AF00CFB1B72D72D52CD01460981F776D694AA893"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ATMwpf;
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


namespace ATMwpf {
    
    
    /// <summary>
    /// TransferMoneyPage
    /// </summary>
    public partial class TransferMoneyPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\TransferMoneyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame TransferMoney;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\TransferMoneyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox amountToTransfer;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\TransferMoneyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cardNumberInput;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\TransferMoneyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button transferBttn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\TransferMoneyPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelBttn;
        
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
            System.Uri resourceLocater = new System.Uri("/ATMwpf;component/transfermoneypage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TransferMoneyPage.xaml"
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
            this.TransferMoney = ((System.Windows.Controls.Frame)(target));
            
            #line 12 "..\..\TransferMoneyPage.xaml"
            this.TransferMoney.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.TransferMoney_Navigated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.amountToTransfer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cardNumberInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.transferBttn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\TransferMoneyPage.xaml"
            this.transferBttn.Click += new System.Windows.RoutedEventHandler(this.transferBttn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cancelBttn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\TransferMoneyPage.xaml"
            this.cancelBttn.Click += new System.Windows.RoutedEventHandler(this.cancelBttn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
