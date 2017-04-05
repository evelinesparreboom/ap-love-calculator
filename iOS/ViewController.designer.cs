// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace ap_love_calculator.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLoveCalc { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel loveResultLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField person1nameText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField person2nameText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnLoveCalc != null) {
                btnLoveCalc.Dispose ();
                btnLoveCalc = null;
            }

            if (loveResultLabel != null) {
                loveResultLabel.Dispose ();
                loveResultLabel = null;
            }

            if (person1nameText != null) {
                person1nameText.Dispose ();
                person1nameText = null;
            }

            if (person2nameText != null) {
                person2nameText.Dispose ();
                person2nameText = null;
            }
        }
    }
}