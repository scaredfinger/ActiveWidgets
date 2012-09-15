using System;
using System.Drawing;
using NUnit.Framework;
using Store.Controls;

namespace Store.Win.Tests.Tests.Controls
{
	[TestFixture]
	public class GlyphExtensionsFixture
	{
		private static readonly Image Large = new Bitmap(10, 10);
		private static readonly Image Medium = new Bitmap(10, 10);
		private static readonly Image Small = new Bitmap(10, 10);
		
		private Glyph _glyph ;
		
		[SetUp]
		public void Setup()
		{
			_glyph = new Glyph(Large, Medium, Small);
		}
		
		[Test]
		public void GetLarge_returns_null_for_null_glyph()
		{
			Glyph glyph = null ;
			
			var image = glyph.GetLarge();
			
			Assert.That(image, Is.Null);
		}
		
		[Test]
		public void GetLarge_returns_image_if_not_null()
		{
			var actual = _glyph.GetLarge();
			
			Assert.That(actual, Is.SameAs(Large));
		}
		
		[Test]
		public void GetMedium_returns_null_for_null_glyph()
		{
			Glyph glyph = null ;
			
			var image = glyph.GetMedium();
			
			Assert.That(image, Is.Null);
		}
		
		[Test]
		public void GetMedium_returns_image_if_not_null()
		{
			var actual = _glyph.GetMedium();
			
			Assert.That(actual, Is.SameAs(Medium));
		}
	}
}
