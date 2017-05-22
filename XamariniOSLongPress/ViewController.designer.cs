// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamariniOSLongPress
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnTouch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDisplay { get; set; }

        [Action ("BtnTouch_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnTouch_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnTouch != null) {
                btnTouch.Dispose ();
                btnTouch = null;
            }

            if (lblDisplay != null) {
                lblDisplay.Dispose ();
                lblDisplay = null;
            }
        }
    }
}