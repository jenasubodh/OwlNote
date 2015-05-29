using System;

using Foundation;
using UIKit;

namespace OwlNote.iOS
{
	public partial class NoteCell : UITableViewCell
	{
		public UILabel Category
		{
			get { return lblCategory; }
			set { lblCategory = value; }
		}

		public UILabel Date
		{
			get { return lblDate; }
			set { lblDate = value; }
		}

		public UILabel Title
		{
			get { return lblTitle; }
			set { lblTitle = value; }
		}

		public UILabel Desc
		{
			get { return lblDescription; }
			set { lblDescription = value; }
		}


		public static readonly NSString Key = new NSString ("NoteCell");

		public NoteCell(IntPtr handle) : base(handle)
		{
		}

		public NoteCell () : base (UITableViewCellStyle.Default, Key)
		{
		}
	}
}
