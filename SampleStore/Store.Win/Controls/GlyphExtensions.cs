
using System;
using System.Drawing;

namespace Store.Controls
{
	public static class GlyphExtensions
	{
		/// <summary>
		/// Gets the large image of specified glyph.
		/// </summary>
		/// <param name="glyph">Glyph to get the image from</param>
		/// <returns>null if glyph is null, the glyph large image otherwise</returns>
		public static Image GetLarge(this Glyph glyph)
		{
			return glyph == null ? null : glyph.Large;
		}
		
		/// <summary>
		/// Gets the medium image of specified glyph.
		/// </summary>
		/// <param name="glyph">Glyph to get the image from</param>
		/// <returns>null if glyph is null, the glyph medium image otherwise</returns>
		public static Image GetMedium(this Glyph glyph)
		{
			return glyph == null ? null : glyph.Medium;
		}
		
		/// <summary>
		/// Gets the small image of specified glyph.
		/// </summary>
		/// <param name="glyph">Glyph to get the image from</param>
		/// <returns>null if glyph is null, the glyph small image otherwise</returns>
		public static Image GetSmall(this Glyph glyph)
		{
			return glyph == null ? null : glyph.Small;
		}
	}
}
