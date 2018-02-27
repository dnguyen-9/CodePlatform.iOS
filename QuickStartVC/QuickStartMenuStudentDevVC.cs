using Foundation;
using System;
using UIKit;

namespace CodePlatform
{
    public partial class QuickStartMenuStudentDevVC : UIViewController
    {
        public string quickStartMenuLabelText { get; set; }
        public string quickStartMenuTextViewText { get; set; }

        public QuickStartMenuStudentDevVC(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            QuickStartMenuLabelText.Text = quickStartMenuLabelText;
        }
    }
}