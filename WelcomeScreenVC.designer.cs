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
    [Register ("WelcomeScreenVC")]
    partial class WelcomeScreenVC
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DeveloperButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LearnerButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ManagerButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton StudentButton { get; set; }

        [Action ("UIButton407_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton407_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (DeveloperButton != null) {
                DeveloperButton.Dispose ();
                DeveloperButton = null;
            }

            if (LearnerButton != null) {
                LearnerButton.Dispose ();
                LearnerButton = null;
            }

            if (ManagerButton != null) {
                ManagerButton.Dispose ();
                ManagerButton = null;
            }

            if (StudentButton != null) {
                StudentButton.Dispose ();
                StudentButton = null;
            }
        }
    }
}