﻿#pragma checksum "..\..\..\WindowAdicionar.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4E36E1D2B8CAF2A74FFB523F10425C94C0A0B3F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Aula05;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Aula05 {
    
    
    /// <summary>
    /// WindowAdicionar
    /// </summary>
    public partial class WindowAdicionar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\WindowAdicionar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbQuadrado;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\WindowAdicionar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbRetangulo;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\WindowAdicionar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbCirculo;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\WindowAdicionar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbLargura;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\WindowAdicionar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbAltura;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\WindowAdicionar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInserir;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\WindowAdicionar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Aula05;component/windowadicionar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowAdicionar.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.rbQuadrado = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.rbRetangulo = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.rbCirculo = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.tbLargura = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbAltura = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnInserir = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\WindowAdicionar.xaml"
            this.btnInserir.Click += new System.Windows.RoutedEventHandler(this.btnInserir_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
