using System;
using CSStickyHeaderFlowLayoutTest.Cells;
using UIKit;
namespace CSStickyHeaderFlowLayoutTest
{
	public class TestCollectionViewSource : UICollectionViewSource
	{
		public TestCollectionViewSource()
		{
		}

		static Random rand = new Random();

		public override UICollectionReusableView GetViewForSupplementaryElement(UICollectionView collectionView, Foundation.NSString elementKind, Foundation.NSIndexPath indexPath)
		{
			if (elementKind == CSStickyHeaderFlowLayout.Constants.CSStickyHeaderParallaxHeader)
			{
				var cell = collectionView.DequeueReusableSupplementaryView(elementKind, nameof(HeaderCollectionViewCell), indexPath);
				return cell;
			}

			return null;
		}

		public override nint GetItemsCount(UICollectionView collectionView, nint section)
		{
			return 255;
		}

		public override UICollectionViewCell GetCell(UICollectionView collectionView, Foundation.NSIndexPath indexPath)
		{
			var cell = collectionView.DequeueReusableCell("cell", indexPath) as UICollectionViewCell;
			cell.BackgroundColor = GetRandomColor();

			return cell;
		}

		public static UIColor GetRandomColor()
		{
			int hue = rand.Next(255);
			UIColor color = UIColor.FromHSB(
				(hue / 255.0f),
				1.0f,
				1.0f);
			return color;
		}
	}
}
