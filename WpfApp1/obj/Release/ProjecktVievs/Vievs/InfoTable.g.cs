﻿#pragma checksum "..\..\..\..\ProjecktVievs\Vievs\InfoTable.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A0EF3DB61A212089A49C9961E538BF242CCD53F71B5A76B007E9174D23EF018B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp1.ProjecktVievs.Vievs;


namespace WpfApp1.ProjecktVievs.Vievs {
    
    
    /// <summary>
    /// InfoTable
    /// </summary>
    public partial class InfoTable : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\ProjecktVievs\Vievs\InfoTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid1;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\ProjecktVievs\Vievs\InfoTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid2;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\ProjecktVievs\Vievs\InfoTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid3;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\ProjecktVievs\Vievs\InfoTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid4;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\ProjecktVievs\Vievs\InfoTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid5;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\ProjecktVievs\Vievs\InfoTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid6;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\ProjecktVievs\Vievs\InfoTable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid7;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/projecktvievs/vievs/infotable.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ProjecktVievs\Vievs\InfoTable.xaml"
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
            
            #line 19 "..\..\..\..\ProjecktVievs\Vievs\InfoTable.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteSelectedRows_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 20 "..\..\..\..\ProjecktVievs\Vievs\InfoTable.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveChanges_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DataGrid1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.DataGrid2 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.DataGrid3 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.DataGrid4 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.DataGrid5 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.DataGrid6 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.DataGrid7 = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

