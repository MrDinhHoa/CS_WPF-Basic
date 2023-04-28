﻿#pragma checksum "..\..\..\..\MVVM\View\MainView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9F34F1E279C1E1A7D0E3A42644E5D74A6C628EDC36317F65CC9026ED9A3FF199"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using _13.WPF_Canvas.MVVM.View;
using _13.WPF_Canvas.MVVM.ViewModel;


namespace _13.WPF_Canvas.MVVM.View {
    
    
    /// <summary>
    /// MainView
    /// </summary>
    public partial class MainView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\..\MVVM\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox beamWidthBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\MVVM\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox beamHeightBox;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\..\MVVM\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox rebarBot1Box;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\..\MVVM\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox rebarBot2Box;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\..\MVVM\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas viewCanvas;
        
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
            System.Uri resourceLocater = new System.Uri("/13.WPF_Canvas;component/mvvm/view/mainview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\MainView.xaml"
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
            
            #line 31 "..\..\..\..\MVVM\View\MainView.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MoveLeave_beamSection);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 37 "..\..\..\..\MVVM\View\MainView.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MoveLeave_beamSection);
            
            #line default
            #line hidden
            return;
            case 3:
            this.beamWidthBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\..\MVVM\View\MainView.xaml"
            this.beamWidthBox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MoveLeave_beamSection);
            
            #line default
            #line hidden
            return;
            case 4:
            this.beamHeightBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\..\MVVM\View\MainView.xaml"
            this.beamHeightBox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MoveLeave_beamSection);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 72 "..\..\..\..\MVVM\View\MainView.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MoveLeave_beamSection);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 78 "..\..\..\..\MVVM\View\MainView.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MoveLeave_beamSection);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 94 "..\..\..\..\MVVM\View\MainView.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MoveLeave_beamSection);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 100 "..\..\..\..\MVVM\View\MainView.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MoveLeave_beamSection);
            
            #line default
            #line hidden
            return;
            case 9:
            this.rebarBot1Box = ((System.Windows.Controls.TextBox)(target));
            
            #line 117 "..\..\..\..\MVVM\View\MainView.xaml"
            this.rebarBot1Box.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MoveLeave_beamSection);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 123 "..\..\..\..\MVVM\View\MainView.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MoveLeave_beamSection);
            
            #line default
            #line hidden
            return;
            case 11:
            this.rebarBot2Box = ((System.Windows.Controls.TextBox)(target));
            
            #line 139 "..\..\..\..\MVVM\View\MainView.xaml"
            this.rebarBot2Box.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MoveLeave_beamSection);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 145 "..\..\..\..\MVVM\View\MainView.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MoveLeave_beamSection);
            
            #line default
            #line hidden
            return;
            case 13:
            this.viewCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

