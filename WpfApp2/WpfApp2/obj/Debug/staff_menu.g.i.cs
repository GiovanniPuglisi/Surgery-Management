﻿#pragma checksum "..\..\staff_menu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "46C0EB7635A23B345053D16A58192F6C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using WpfApp2;


namespace WpfApp2 {
    
    
    /// <summary>
    /// staff_menu
    /// </summary>
    public partial class staff_menu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfApp2.staff_menu Staff_Screen;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_bookings;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_patients;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_home;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label staff_on_duty_date;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StaffSearchbt;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dp2;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_register_staff;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/staff_menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\staff_menu.xaml"
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
            this.Staff_Screen = ((WpfApp2.staff_menu)(target));
            return;
            case 2:
            this.btn_bookings = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\staff_menu.xaml"
            this.btn_bookings.Click += new System.Windows.RoutedEventHandler(this.btn_bookings_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_patients = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\staff_menu.xaml"
            this.btn_patients.Click += new System.Windows.RoutedEventHandler(this.btn_patients_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_home = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\staff_menu.xaml"
            this.btn_home.Click += new System.Windows.RoutedEventHandler(this.btn_home_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.staff_on_duty_date = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.StaffSearchbt = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\staff_menu.xaml"
            this.StaffSearchbt.Click += new System.Windows.RoutedEventHandler(this.Search_Staff);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.dp2 = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 11:
            
            #line 33 "..\..\staff_menu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.gettodayshifts);
            
            #line default
            #line hidden
            return;
            case 12:
            this.bt_register_staff = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\staff_menu.xaml"
            this.bt_register_staff.Click += new System.Windows.RoutedEventHandler(this.bt_new_staff);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

