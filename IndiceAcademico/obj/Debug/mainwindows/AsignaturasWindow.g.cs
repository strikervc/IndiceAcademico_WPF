﻿#pragma checksum "..\..\..\mainwindows\AsignaturasWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9D5BB1160CBA678BDB31EF99D07B8185543B9192BB4FDB3BF416EEF906DDE156"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using IndiceAcademico.mainwindows;
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


namespace IndiceAcademico.mainwindows {
    
    
    /// <summary>
    /// AsignaturasWindow
    /// </summary>
    public partial class AsignaturasWindow : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\mainwindows\AsignaturasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AsignaturaDataGrid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\mainwindows\AsignaturasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\mainwindows\AsignaturasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditar;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\mainwindows\AsignaturasWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnActualizar;
        
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
            System.Uri resourceLocater = new System.Uri("/IndiceAcademico;component/mainwindows/asignaturaswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\mainwindows\AsignaturasWindow.xaml"
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
            
            #line 8 "..\..\..\mainwindows\AsignaturasWindow.xaml"
            ((IndiceAcademico.mainwindows.AsignaturasWindow)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.UserControl_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AsignaturaDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 14 "..\..\..\mainwindows\AsignaturasWindow.xaml"
            this.AsignaturaDataGrid.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.AsignaturaDataGrid_AutoGeneratingColumn);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\mainwindows\AsignaturasWindow.xaml"
            this.AsignaturaDataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.AsignaturaDataGrid_Selected);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnAgregar = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\mainwindows\AsignaturasWindow.xaml"
            this.btnAgregar.Click += new System.Windows.RoutedEventHandler(this.Agregar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnEditar = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\mainwindows\AsignaturasWindow.xaml"
            this.btnEditar.Click += new System.Windows.RoutedEventHandler(this.Editar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnActualizar = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\mainwindows\AsignaturasWindow.xaml"
            this.btnActualizar.Click += new System.Windows.RoutedEventHandler(this.Actualizar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

