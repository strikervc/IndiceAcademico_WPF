﻿#pragma checksum "..\..\..\editwindows\EditarProfesor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9CD241BDC16FA705042B2B3734DCE4C1BCF7DDFEA51586A165F3795B9821F693"
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
    /// EditarProfesor
    /// </summary>
    public partial class EditarProfesor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        /// <summary>
        /// inputNombre Name Field
        /// </summary>
        
        #line 15 "..\..\..\editwindows\EditarProfesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.TextBox inputNombre;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\editwindows\EditarProfesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ListaProfesores;
        
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
            System.Uri resourceLocater = new System.Uri("/IndiceAcademico;component/editwindows/editarprofesor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\editwindows\EditarProfesor.xaml"
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
            
            #line 13 "..\..\..\editwindows\EditarProfesor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Guardar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.inputNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ListaProfesores = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\..\editwindows\EditarProfesor.xaml"
            this.ListaProfesores.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListaProfesores_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 18 "..\..\..\editwindows\EditarProfesor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AgregarEstudiante_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 19 "..\..\..\editwindows\EditarProfesor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AgregarAsignatura_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
