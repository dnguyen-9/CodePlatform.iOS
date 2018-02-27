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
    [Register ("QuickStartPythonStudentDeveloperVC")]
    partial class QuickStartPythonStudentDeveloperVC
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField QuickStartAnswerInputField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton QuickStartClearButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton QuickStartHintsButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel QuickStartHintsUsedLabelText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel QuickStartLevelLabelText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel QuickStartPointsLabelText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView QuickStartQuestionText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton QuickStartSubmitButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel QuickStartTimer { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (QuickStartAnswerInputField != null) {
                QuickStartAnswerInputField.Dispose ();
                QuickStartAnswerInputField = null;
            }

            if (QuickStartClearButton != null) {
                QuickStartClearButton.Dispose ();
                QuickStartClearButton = null;
            }

            if (QuickStartHintsButton != null) {
                QuickStartHintsButton.Dispose ();
                QuickStartHintsButton = null;
            }

            if (QuickStartHintsUsedLabelText != null) {
                QuickStartHintsUsedLabelText.Dispose ();
                QuickStartHintsUsedLabelText = null;
            }

            if (QuickStartLevelLabelText != null) {
                QuickStartLevelLabelText.Dispose ();
                QuickStartLevelLabelText = null;
            }

            if (QuickStartPointsLabelText != null) {
                QuickStartPointsLabelText.Dispose ();
                QuickStartPointsLabelText = null;
            }

            if (QuickStartQuestionText != null) {
                QuickStartQuestionText.Dispose ();
                QuickStartQuestionText = null;
            }

            if (QuickStartSubmitButton != null) {
                QuickStartSubmitButton.Dispose ();
                QuickStartSubmitButton = null;
            }

            if (QuickStartTimer != null) {
                QuickStartTimer.Dispose ();
                QuickStartTimer = null;
            }
        }
    }
}