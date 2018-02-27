using Foundation;
using System;
using UIKit;

namespace CodePlatform
{
    public partial class WelcomeScreenVC : UIViewController
    {
        public string quickStartMenuLabelText { get; set; }
        public string quickStartMenuTextViewText { get; set; }

        public WelcomeScreenVC (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }


        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            // set the View Controller that’s powering the screen we’re
            // transitioning to

            var quickStartMenuStudentDevVC = segue.DestinationViewController as QuickStartMenuStudentDevVC;

            var s = segue.Identifier;

            UpdateQuickStartMenuVCText(quickStartMenuStudentDevVC, s);
        }

        public void UpdateQuickStartMenuVCText(QuickStartMenuStudentDevVC controller, string segueIndentifier)
        {
            //var text1 = "Please select one of the programming " +
                //"skills below that you would like to challenge yourself";
            //var text2 = "Please select one of the programming " +
            //    "skills below that you would like to hire the best candidate ";
            //var text3 = "Please select one of the programming " +
                //"skills below that you would like to learn by yourself";

            switch (segueIndentifier)
            {
                case "StudentSegue":
                    controller.quickStartMenuLabelText = "Hello <username> [Student],";
                    //controller.quickStartMenuTextViewText = text1;

                    break;
                case "DeveloperSegue":
                    controller.quickStartMenuLabelText = "Hello <username> [Developer],";
                    //controller.quickStartMenuTextViewText = text1;
                    break;
                //case "ManagerSegue":
                //    controller.quickStartMenuLabelText = "Type: Manager";
                //    controller.quickStartMenuTextViewText = text2;
                //    break;
                //case "OthersSegue":
                    //controller.quickStartMenuLabelText = "Type: Others";
                    //controller.quickStartMenuTextViewText = text3;
                    //break;
            }
        }



        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}