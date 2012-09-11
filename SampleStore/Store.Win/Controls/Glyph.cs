using System;
using System.Drawing;

namespace Store.Win.Controls
{
	/// <summary>
	/// A set of images of different sizes that represent an element
	/// </summary>
	public class Glyph
	{
		/// <summary>
		/// Gets the large size image, usually 64x64 or 48x48
		/// </summary>
		public Image Large { get; private set; }
		
		/// <summary>
		/// Gets the medium size image, usually 32x32
		/// </summary>
		public Image Medium { get; private set; }
		
		/// <summary>
		/// Gets the small size image, usually 16x16
		/// </summary>
		public Image Small { get; private set; }
		
		/// <summary>
		/// Creates an instance
		/// </summary>
		public Glyph(Image large, Image medium, Image small)
		{
			Large = large;
			Medium = medium;
			Small = small;
		}
		
		/// <summary>
		/// Creates an instance
		/// </summary>
		/// <param name="singleSize">Single image</param>
		public Glyph(Image singleSize)
			: this(singleSize, singleSize, singleSize)
		{
			
		}
	}
}
