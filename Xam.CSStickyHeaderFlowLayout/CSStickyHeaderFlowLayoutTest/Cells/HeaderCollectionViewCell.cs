using System;

using Foundation;
using UIKit;

namespace CSStickyHeaderFlowLayoutTest.Cells
{
	public partial class HeaderCollectionViewCell : UICollectionViewCell
	{
		public static readonly NSString Key = new NSString("HeaderCollectionViewCell");
		public static readonly UINib Nib;

		static HeaderCollectionViewCell()
		{
			Nib = UINib.FromName("HeaderCollectionViewCell", NSBundle.MainBundle);
		}

		protected HeaderCollectionViewCell(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
	}
}
