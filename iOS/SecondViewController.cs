using Foundation;
using System;
using UIKit;

namespace tryXamarin.iOS
{
    public partial class SecondViewController : UIViewController
    {
        public SecondViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var button = new UIButton
			{
				Frame = new CoreGraphics.CGRect(50, 100, 150, 50),
				BackgroundColor = UIColor.Blue
			};
			button.SetTitle("Ya Ya!!!", UIControlState.Normal);
			View.Add(button);

			button.TouchUpInside += (sender, e) =>
			{
				
				var untypedController = this.Storyboard.InstantiateViewController("FirstViewController");
				//this.NavigationController.PushViewController(untypedController, true);
				this.NavigationController.PopViewController(true);

			};
		}
    }
}