#pragma checksum "..\..\..\..\Zawody\FiltrZawody.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E9CD3ACB0E846BC3B59640C34B406C0D755E3996"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjektWPF.Zawody;
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


namespace ProjektWPF.Zawody {
    
    
    /// <summary>
    /// FiltrZawody
    /// </summary>
    public partial class FiltrZawody : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 81 "..\..\..\..\Zawody\FiltrZawody.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MiesiacStart;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Zawody\FiltrZawody.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MiesiacStop;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Zawody\FiltrZawody.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Rok;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Zawody\FiltrZawody.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Rodzaj;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjektWPF;component/zawody/filtrzawody.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Zawody\FiltrZawody.xaml"
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
            this.MiesiacStart = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.MiesiacStop = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Rok = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Rodzaj = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            
            #line 89 "..\..\..\..\Zawody\FiltrZawody.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Filtr);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 90 "..\..\..\..\Zawody\FiltrZawody.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Reset);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

