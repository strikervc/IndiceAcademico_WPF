﻿#pragma checksum "..\..\..\..\mainwindows\IndiceWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E0DE6BE12351CB4681B1E34399F9A239609C7292BA1AB440BE680D770DBDA3FB"
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
    /// IndiceWindow
    /// </summary>
    public partial class IndiceWindow : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\mainwindows\IndiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ListEstudiantes;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\mainwindows\IndiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Calcular;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\mainwindows\IndiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListaIndice;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\mainwindows\IndiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TotalPuntosHonor;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\mainwindows\IndiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TotalCreditos;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\mainwindows\IndiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label IndiceGeneral;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\mainwindows\IndiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRanking;
        
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
            System.Uri resourceLocater = new System.Uri("/IndiceAcademico;component/mainwindows/indicewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\mainwindows\IndiceWindow.xaml"
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
            this.ListEstudiantes = ((System.Windows.Controls.ComboBox)(target));
            
            #line 16 "..\..\..\..\mainwindows\IndiceWindow.xaml"
            this.ListEstudiantes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListEstudiantes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Calcular = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\mainwindows\IndiceWindow.xaml"
            this.Calcular.Click += new System.Windows.RoutedEventHandler(this.Calcular_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListaIndice = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.TotalPuntosHonor = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.TotalCreditos = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.IndiceGeneral = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.btnRanking = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\mainwindows\IndiceWindow.xaml"
            this.btnRanking.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

