// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CodePlatform
{
    [Register ("HomeVC")]
    partial class HomeVC
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HomeLevelLabelText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HomePointsLabelText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (HomeLevelLabelText != null) {
                HomeLevelLabelText.Dispose ();
                HomeLevelLabelText = null;
            }

            if (HomePointsLabelText != null) {
                HomePointsLabelText.Dispose ();
                HomePointsLabelText = null;
            }
        }
    }
}