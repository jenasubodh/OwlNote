// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace OwlNote.iOS
{
	[Register ("NoteCell")]
	partial class NoteCell
	{
		[Outlet]
		UIKit.UILabel hueColor { get; set; }

		[Outlet]
		UIKit.UILabel lblCategory { get; set; }

		[Outlet]
		UIKit.UILabel lblDate { get; set; }

		[Outlet]
		UIKit.UILabel lblDescription { get; set; }

		[Outlet]
		UIKit.UILabel lblTime { get; set; }

		[Outlet]
		UIKit.UILabel lblTitle { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (hueColor != null) {
				hueColor.Dispose ();
				hueColor = null;
			}

			if (lblCategory != null) {
				lblCategory.Dispose ();
				lblCategory = null;
			}

			if (lblDate != null) {
				lblDate.Dispose ();
				lblDate = null;
			}

			if (lblDescription != null) {
				lblDescription.Dispose ();
				lblDescription = null;
			}

			if (lblTime != null) {
				lblTime.Dispose ();
				lblTime = null;
			}

			if (lblTitle != null) {
				lblTitle.Dispose ();
				lblTitle = null;
			}
		}
	}
}
