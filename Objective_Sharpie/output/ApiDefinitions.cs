using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace CSStickyHeaderFlowLayout
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double CSStickyHeaderFlowLayoutVersionNumber;
		[Field ("CSStickyHeaderFlowLayoutVersionNumber", "__Internal")]
		double CSStickyHeaderFlowLayoutVersionNumber { get; }

		// extern const unsigned char [] CSStickyHeaderFlowLayoutVersionString;
		[Field ("CSStickyHeaderFlowLayoutVersionString", "__Internal")]
		byte[] CSStickyHeaderFlowLayoutVersionString { get; }
	}

	// @interface CSStickyHeaderFlowLayoutAttributes : UICollectionViewLayoutAttributes
	[BaseType (typeof(UICollectionViewLayoutAttributes))]
	interface CSStickyHeaderFlowLayoutAttributes
	{
		// @property (nonatomic) CGFloat progressiveness;
		[Export ("progressiveness")]
		nfloat Progressiveness { get; set; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const CSStickyHeaderParallaxHeader;
		[Field ("CSStickyHeaderParallaxHeader", "__Internal")]
		NSString CSStickyHeaderParallaxHeader { get; }
	}

	// @interface CSStickyHeaderFlowLayout : UICollectionViewFlowLayout
	[BaseType (typeof(UICollectionViewFlowLayout))]
	interface CSStickyHeaderFlowLayout
	{
		// @property (nonatomic) CGSize parallaxHeaderReferenceSize;
		[Export ("parallaxHeaderReferenceSize", ArgumentSemantic.Assign)]
		CGSize ParallaxHeaderReferenceSize { get; set; }

		// @property (nonatomic) CGSize parallaxHeaderMinimumReferenceSize;
		[Export ("parallaxHeaderMinimumReferenceSize", ArgumentSemantic.Assign)]
		CGSize ParallaxHeaderMinimumReferenceSize { get; set; }

		// @property (nonatomic) BOOL parallaxHeaderAlwaysOnTop;
		[Export ("parallaxHeaderAlwaysOnTop")]
		bool ParallaxHeaderAlwaysOnTop { get; set; }

		// @property (nonatomic) BOOL disableStickyHeaders;
		[Export ("disableStickyHeaders")]
		bool DisableStickyHeaders { get; set; }

		// @property (nonatomic) BOOL disableStretching;
		[Export ("disableStretching")]
		bool DisableStretching { get; set; }
	}
}
