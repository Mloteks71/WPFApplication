#pragma checksum "..\..\..\..\Zawodnicy\AddZawodnik.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8851309ADFB67AA34DA608E1E65791F9156D665E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjektWPF.Zawodnicy;
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


namespace ProjektWPF.Zawodnicy {
    
    
    /// <summary>
    /// AddZawodnik
    /// </summary>
    public partial class AddZawodnik : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\..\Zawodnicy\AddZawodnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AddGrid;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Zawodnicy\AddZawodnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Zawodnicy\AddZawodnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SurnameTextBox;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Zawodnicy\AddZawodnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AgeTextBox;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\Zawodnicy\AddZawodnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumberTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjektWPF;component/zawodnicy/addzawodnik.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Zawodnicy\AddZawodnik.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AddGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 46 "..\..\..\..\Zawodnicy\AddZawodnik.xaml"
            this.AddGrid.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.validationError));
            
            #line default
            #line hidden
            return;
            case 2:
            this.NameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 74 "..\..\..\..\Zawodnicy\AddZawodnik.xaml"
            this.NameTextBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NameVali);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SurnameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 75 "..\..\..\..\Zawodnicy\AddZawodnik.xaml"
            this.SurnameTextBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SurnameVali);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AgeTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\..\..\Zawodnicy\AddZawodnik.xaml"
            this.AgeTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.AgeFocus);
            
            #line default
            #line hidden
            
            #line 76 "..\..\..\..\Zawodnicy\AddZawodnik.xaml"
            this.AgeTextBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.AgeVali);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NumberTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 85 "..\..\..\..\Zawodnicy\AddZawodnik.xaml"
            this.NumberTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.NumberFocus);
            
            #line default
            #line hidden
            
            #line 85 "..\..\..\..\Zawodnicy\AddZawodnik.xaml"
            this.NumberTextBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NumberVali);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 87 "..\..\..\..\Zawodnicy\AddZawodnik.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 88 "..\..\..\..\Zawodnicy\AddZawodnik.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

