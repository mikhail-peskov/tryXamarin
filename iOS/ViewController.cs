using System;

using UIKit;

namespace tryXamarin.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var button = new UIButton
			{
				Frame = new CoreGraphics.CGRect(50, 100, 150, 50),
				BackgroundColor = UIColor.Red
			};
			button.SetTitle("Clisc Me!!!", UIControlState.Normal);
			View.Add(button);

			button.TouchUpInside += (sender, e) =>
			{
				var untypedController = this.Storyboard.InstantiateViewController("SecondViewController");
				SecondViewController controller = untypedController as SecondViewController;
				this.NavigationController.PushViewController(untypedController, true);

			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}



	}
}
