using System;

using Foundation;
using UIKit;

namespace OwlNote.iOS
{
	public partial class NoteViewController : UIViewController
	{
		public NoteViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Register the TableView's data source
			TableView.Source = new NoteSource ();
		}
	}
}
