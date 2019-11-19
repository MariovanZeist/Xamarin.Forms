using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Foundation;
using NUnit.Framework;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.ControlGallery.iOS.Tests
{
	[TestFixture]
	[Internals.Preserve(AllMembers = true)]
	public class SampleTests
	{
		[Test]
		public void iOSPlatformTest1()
		{
			var x = new Label { Text = "foo" };
			
			Device.BeginInvokeOnMainThread(() =>
			{
				using (var renderer = Platform.iOS.Platform.CreateRenderer(x))
				{
					var tv = renderer.NativeView as ViewRenderer<Label, UILabel>;
					var ftv = tv.Control;
					Assert.That(ftv.Text == x.Text);
				}
			});
		}
	}
}