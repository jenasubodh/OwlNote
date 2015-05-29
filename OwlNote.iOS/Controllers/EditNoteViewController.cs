using System;

using Foundation;
using UIKit;

namespace OwlNote.iOS
{
	public partial class EditNoteViewController : UIViewController
	{
		public EditNoteViewController (IntPtr handle) : base (handle)
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

			// Name the navigation title
			this.NavigationItem.Title = "Edit Note";
		}

		partial void didTapDelete (NSObject sender)
		{
			Console.WriteLine("Tapped Delete");
		}

		partial void didTapSave (NSObject sender)
		{
			Console.WriteLine("Tapped Save");
		}

		public override void TouchesBegan(NSSet touches, UIEvent evt)
		{
			categoryText.ResignFirstResponder();
			noteText.ResignFirstResponder ();
			titleText.ResignFirstResponder ();
		}
	}
}
