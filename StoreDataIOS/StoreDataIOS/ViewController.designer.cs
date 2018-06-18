// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace StoreDataIOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField nameBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField phoneBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton submitButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton viewListButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (nameBox != null) {
                nameBox.Dispose ();
                nameBox = null;
            }

            if (phoneBox != null) {
                phoneBox.Dispose ();
                phoneBox = null;
            }

            if (submitButton != null) {
                submitButton.Dispose ();
                submitButton = null;
            }

            if (viewListButton != null) {
                viewListButton.Dispose ();
                viewListButton = null;
            }
        }
    }
}