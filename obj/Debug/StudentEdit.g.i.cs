﻿#pragma checksum "..\..\StudentEdit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "313B5674BACE53E392494857308A4D76F5F19BA72F5695FFEFE355A2214647AF"
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// StudentEdit
    /// </summary>
    public partial class StudentEdit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\StudentEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStudentID;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\StudentEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFirstname;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\StudentEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLastname;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\StudentEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsername;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\StudentEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\StudentEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\StudentEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFacultyname;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\StudentEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBuildingID;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\StudentEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRoomID;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\StudentEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPhone;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\StudentEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFees;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\StudentEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveEditStudent;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\StudentEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelEditStudent;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/studentedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StudentEdit.xaml"
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
            this.txtStudentID = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\StudentEdit.xaml"
            this.txtStudentID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtStudentID_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtFirstname = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\StudentEdit.xaml"
            this.txtFirstname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtFirstname_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtLastname = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\StudentEdit.xaml"
            this.txtLastname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtLastname_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtUsername = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\StudentEdit.xaml"
            this.txtUsername.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtUsername_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\StudentEdit.xaml"
            this.txtEmail.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtEmail_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtFacultyname = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\StudentEdit.xaml"
            this.txtFacultyname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtFacultyname_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtBuildingID = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\StudentEdit.xaml"
            this.txtBuildingID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBuildingID_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtRoomID = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\StudentEdit.xaml"
            this.txtRoomID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtRoomID_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtPhone = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\StudentEdit.xaml"
            this.txtPhone.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtPhone_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtFees = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\StudentEdit.xaml"
            this.txtFees.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtFees_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.SaveEditStudent = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\StudentEdit.xaml"
            this.SaveEditStudent.Click += new System.Windows.RoutedEventHandler(this.SaveEditStudent_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.CancelEditStudent = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\StudentEdit.xaml"
            this.CancelEditStudent.Click += new System.Windows.RoutedEventHandler(this.CancelEditStudent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
