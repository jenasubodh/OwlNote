using System;
using System.Collections.Generic;
using System.Globalization;

using Foundation;
using UIKit;

using OwlNote.Core.Models;

namespace OwlNote.iOS
{
	public class NoteSource : UITableViewSource
	{
		private IList<Note> _Notes;
		private NoteViewController _NoteVC;

		// Create random UIColors
		public UIColor GenerateRandomColor()
		{
			Random random = new Random ();

			int red = random.Next (256);
			int green = random.Next (256);
			int blue = random.Next (256);
			// mix the color
			return UIColor.FromRGB(red/2,green/2,blue/2);
		}
			
		public IList<Note> Notes {
			get {
				LoadNotes ();
				return _Notes;
			}
		}

		public NoteSource (NoteViewController NoteVC)
		{
			_NoteVC = NoteVC;				
		}

		public void LoadNotes ()
		{
			// Initialize elements if Null
			if (_Notes == null) {
				_Notes = new List<Note> ();
			}

			this._Notes = AppDelegate.SharedDelegate.NoteMgr.GetNotes ();
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return Notes.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (NoteCell.Key) as NoteCell;
			if (cell == null)
				cell = new NoteCell ();

			var note = this.Notes [indexPath.Row];

			cell.DateHue.BackgroundColor = GenerateRandomColor ();

			cell.Date.Text = note.Date.Day + "\n" + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName (note.Date.Month) + "\n" + note.Date.Year;
			cell.Title.Text = note.Title;
			cell.Category.Text = note.Category;
			cell.Desc.Text = note.Description;
			cell.Time.Text = String.Format("{0:t}", note.Date);

			return cell;
		}
			
		public override bool CanEditRow (UITableView tableView, NSIndexPath indexPath)
		{
			return true;
		}

		public override void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
		{
		}
	}
}

