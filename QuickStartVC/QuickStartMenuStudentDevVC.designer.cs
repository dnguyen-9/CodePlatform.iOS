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
    [Register ("QuickStartMenuStudentDevVC")]
    partial class QuickStartMenuStudentDevVC
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel QuickStartMenuLabelText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (QuickStartMenuLabelText != null) {
                QuickStartMenuLabelText.Dispose ();
                QuickStartMenuLabelText = null;
            }
        }
    }
}