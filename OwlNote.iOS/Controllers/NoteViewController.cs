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

			NavigationItem.LeftBarButtonItem = EditButtonItem;

			// Register the TableView's data source
			TableView.Source = new NoteSource (this);
			TableView.Delegate = new NoteDelegate (this);
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			ReloadData ();
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "editNote") {
				var noteEditorVC = segue.DestinationViewController as EditNoteViewController;
			}
		}

		partial void didTapAddNote (NSObject sender)
		{
			Console.WriteLine ("Tapped on Add Note, Lets create blank note and pass the ID to EditNoteVC");
			PerformSegue ("editNote", null);
		}


		// Public Methods, Accessible by other Views

		public void ReloadData ()
		{
			TableView.ReloadData ();
		}

		public void ShowMoreAction ()
		{
			UIAlertController actionSheetAlert = UIAlertController.Create ("Action Sheet", "Select an item from below", UIAlertControllerStyle.ActionSheet);

			// Add Actions
			actionSheetAlert.AddAction (UIAlertAction.Create ("Item One", 
				UIAlertActionStyle.Default, 
				(action) => 
				Console.WriteLine ("Item One pressed.")
			));

			actionSheetAlert.AddAction (UIAlertAction.Create ("Item Two", 
				UIAlertActionStyle.Default, 
				(action) => 
				Console.WriteLine ("Item Two pressed.")
			));

			actionSheetAlert.AddAction (UIAlertAction.Create ("Item Three", 
				UIAlertActionStyle.Default, 
				(action) => 
				Console.WriteLine ("Item Three pressed.")
			));

			actionSheetAlert.AddAction (UIAlertAction.Create ("Cancel", 
				UIAlertActionStyle.Cancel, 
				(action) => 
				Console.WriteLine ("Cancel button pressed.")
			));

			UIPopoverPresentationController presentationPopover = actionSheetAlert.PopoverPresentationController;
			if (presentationPopover != null) {
				presentationPopover.SourceView = this.View;
			}

			this.PresentViewController (actionSheetAlert, true, null);
		}
	}
}
