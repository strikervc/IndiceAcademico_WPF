﻿#pragma checksum "..\..\..\..\editwindows\AgregarCalificacion.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8AE4E1420DEC04C3B2EB92D030F9E9C115BE9E80FED7D56F66979752CEBC7645"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
    /// AgregarCalificacion
    /// </summary>
    public partial class AgregarCalificacion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\editwindows\AgregarCalificacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputNota;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\editwindows\AgregarCalificacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ListaAsignatura;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\editwindows\AgregarCalificacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ListaEstudiantes;
        
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
            System.Uri resourceLocater = new System.Uri("/IndiceAcademico;component/editwindows/agregarcalificacion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\editwindows\AgregarCalificacion.xaml"
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
            
            #line 13 "..\..\..\..\editwindows\AgregarCalificacion.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Guardar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.inputNota = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\..\editwindows\AgregarCalificacion.xaml"
            this.inputNota.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.InputNota_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListaAsignatura = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.ListaEstudiantes = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            
            #line 20 "..\..\..\..\editwindows\AgregarCalificacion.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Volver_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

