﻿#pragma checksum "..\..\..\editwindows\EditarAsignatura.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "79649EA09333CE0D22CC2299F13B0412145A86C75ADC426CB45E0122162EB9EE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IndiceAcademico.editwindows;
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


namespace IndiceAcademico.editwindows {
    
    
    /// <summary>
    /// EditarAsignatura
    /// </summary>
    public partial class EditarAsignatura : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        /// <summary>
        /// inputClave Name Field
        /// </summary>
        
        #line 15 "..\..\..\editwindows\EditarAsignatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.TextBox inputClave;
        
        #line default
        #line hidden
        
        /// <summary>
        /// inputNombre Name Field
        /// </summary>
        
        #line 17 "..\..\..\editwindows\EditarAsignatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.TextBox inputNombre;
        
        #line default
        #line hidden
        
        /// <summary>
        /// inputCreditos Name Field
        /// </summary>
        
        #line 19 "..\..\..\editwindows\EditarAsignatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.TextBox inputCreditos;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\editwindows\EditarAsignatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ListaAsignaturas;
        
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
            System.Uri resourceLocater = new System.Uri("/IndiceAcademico;component/editwindows/editarasignatura.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\editwindows\EditarAsignatura.xaml"
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
            
            #line 13 "..\..\..\editwindows\EditarAsignatura.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Guardar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.inputClave = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.inputNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.inputCreditos = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ListaAsignaturas = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\..\editwindows\EditarAsignatura.xaml"
            this.ListaAsignaturas.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListaAsignaturas_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
