using System;

using Foundation;
using UIKit;
using OwlNote.Core.Models;

namespace OwlNote.iOS
{
	public partial class EditNoteViewController : UIViewController
	{
		public int noteID;

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

		partial void deleteNote (NSObject sender)
		{
			Console.WriteLine("Tapped Delete");
			NavigationController.PopViewController(true);
		}

		partial void didTapSave (NSObject sender)
		{		
			Console.WriteLine("Tapped Save");
				
			if(CreateNote(new Note()))
			{
				NavigationController.PopViewController(true);
			}

		}

		public override void TouchesBegan(NSSet touches, UIEvent evt)
		{
			categoryText.ResignFirstResponder();
			noteText.ResignFirstResponder ();
			titleText.ResignFirstResponder ();
		}

		public bool CreateNote(Note note)
		{
			if(String.IsNullOrEmpty(categoryText.Text) || String.IsNullOrEmpty(categoryText.Text) || String.IsNullOrEmpty(categoryText.Text))
			{
				var alertView = new UIAlertView("Validation Error","Please fill all the fields",null,"OK",null);
				alertView.Show();
				return false;
			}
				
			note.Date = DateTime.Now;
			note.Title = titleText.Text;
			note.Category = categoryText.Text;
			note.Description = noteText.Text;
			AppDelegate.SharedDelegate.NoteMgr.SaveNote(note);

			return true;
		}

		/*
		public void UpdateUIWithNote()
		{
			if (currentNote == null) {
				currentNote = AppDelegate.SharedDelegate.NoteMgr.GetNote (noteID);
			}

			// Once the note has been updated then update the UI with the respective note values
			titleText.Text = currentNote.Title;
			categoryText.Text = currentNote.Category;
			noteText.Text = currentNote.Description;
		}
      */
	}
}
