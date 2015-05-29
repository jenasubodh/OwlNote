using System;

using Foundation;
using UIKit;

using OwlNote.Core.Models;

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
			TableView.Source = new NoteSource (this);
			TableView.Delegate = new NoteDelegate (this);
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			TableView.ReloadData ();
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "editNote") {
				var noteEditorVC = segue.DestinationViewController as EditNoteViewController;
			}
		}

		partial void didTapAddNote (NSObject sender)
		{
			Console.WriteLine("Tapped on Add Note, Lets create blank note and pass the ID to EditNoteVC");
			PerformSegue("editNote",null);
		}

	}
}
