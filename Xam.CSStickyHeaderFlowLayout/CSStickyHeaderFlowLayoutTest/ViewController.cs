using System;

using UIKit;
using CSStickyHeaderFlowLayoutTest.Cells;
using Foundation;

namespace CSStickyHeaderFlowLayoutTest
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
			// Perform any additional setup after loading the view, typically from a nib.

			var layout = new CSStickyHeaderFlowLayout.CSStickyHeaderFlowLayout();
			layout.MinimumLineSpacing = 0;
			layout.SectionHeadersPinToVisibleBounds = true;

			layout.ParallaxHeaderReferenceSize = new CoreGraphics.CGSize(this.View.Frame.Size.Width, 300);
			layout.ParallaxHeaderMinimumReferenceSize = new CoreGraphics.CGSize(this.View.Frame.Size.Width, 40);
			layout.ItemSize = new CoreGraphics.CGSize(this.View.Frame.Size.Width, 44);
			layout.ParallaxHeaderAlwaysOnTop = true;
			layout.DisableStickyHeaders = true;

			var nib = UINib.FromName(nameof(HeaderCollectionViewCell), NSBundle.MainBundle);
			this.collect.RegisterNibForSupplementaryView(nib, CSStickyHeaderFlowLayout.Constants.CSStickyHeaderParallaxHeader, new NSString(nameof(HeaderCollectionViewCell)));
			this.collect.RegisterClassForCell(typeof(UICollectionViewCell), "cell");
			this.collect.Source = new TestCollectionViewSource();
			this.collect.CollectionViewLayout = layout;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
