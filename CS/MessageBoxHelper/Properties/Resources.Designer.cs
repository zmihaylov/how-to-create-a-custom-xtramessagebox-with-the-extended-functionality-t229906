﻿// Developer Express Code Central Example:
// How to create a custom XtraMessageBox with the extended functionality
// 
// This example demonstrates how to create a MessageBox with an extended
// functionality. For this, create MyXtraMessageBox class descendant that is
// inherited from the XtraMessageBox class and uses the XtraMessageBoxArgs class -
// a MyXtraMessageArgs descendant which contains properties to customize the
// XtraMessageBox behavior. - ShowCountDown. If this property is true, the message
// box title will show you how many seconds are left before the timeout. When the
// countdown is over, the title will show its usual value.
// - ShowNextTime. This
// property allows you to show a CheckBox on your message form. When you close the
// form, the result will be saved in the ShowMessageNextTime property of
// MyXtraMessageArgs and you can use this value later.
// - DisableButtons. If this
// property value is true, all buttons except for "Cancel" will be disabled on the
// form.
// - DisableCancel. This property gives you an opportunity to disable the
// "Cancel" button on the form.
// - AutoClose. If you want to close your form, after
// the countdown is over, set this property to true. Also, you need to define the
// value of the AutoCloseResult property. This property shows what value will be
// received from the MyXtraMessageBox.Show method if the form is automatically
// closed.
// - Center. If this property value is true, the MessageBox will be center
// aligned against its parent form.
// - Timeout. This property sets the timer for
// the AutoClose and ShowCountDown properties in seconds. Its value should be
// greater than 0, otherwise, these properties will be unavailable.
// - Buttons.
// This property specifies what buttons will be available on the form.
// - Icon.
// This property specifies the MessageBox icon.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T229906

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessageBoxHelper.Properties
{


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if ((resourceMan == null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MessageBoxHelper.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }
    }
}
