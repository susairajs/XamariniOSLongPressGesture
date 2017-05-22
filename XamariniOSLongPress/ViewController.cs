using System;

using UIKit;

namespace XamariniOSLongPress
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			btnTouch.UserInteractionEnabled = true;
			UILongPressGestureRecognizer longp = new UILongPressGestureRecognizer(LongPress);
			btnTouch.AddGestureRecognizer(longp);

			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void BtnTouch_TouchUpInside(UIButton sender)
		{
			lblDisplay.Text = "Button Clicked";
		}

		public void LongPress()
		{

			lblDisplay.Text = "Button Long Pressed";
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
