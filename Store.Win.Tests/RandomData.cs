using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;

using NLipsum.Core;
using Store.Win.Controls;
using Store.Win.Tests.Resources;
using DictionaryEntry = System.Collections.DictionaryEntry;
using RandomInt = System.Random;

namespace Store.Win.Tests
{
	public static class Random
	{
		private static readonly RandomInt _numberGenerator = new RandomInt();
		private static readonly LipsumGenerator _lipsum = 
			new LipsumGenerator(Lipsums.LoremIpsum, false);
		
		private static readonly Image[] Images16x16 = LoadImages(Icons16.ResourceManager);
		
		private static Image[] LoadImages(ResourceManager manager)
		{
			return AllResourcesIn(manager)
				.Select(x => manager.GetObject(x))
				.Cast<Image>()
				.ToArray();
		}
		
		private static IEnumerable<string> AllResourcesIn(ResourceManager manager)
		{
			var resSet = manager.GetResourceSet(
				CultureInfo.CurrentCulture, true, true);
			
			return resSet.Cast<DictionaryEntry>()
				.Select(x => x.Key)
				.Cast<string>();
		}
		
		private static readonly Image[] Images24x24 = LoadImages(Icons24.ResourceManager);
		
		private static readonly Image[] Images48x48 = LoadImages(Icons48.ResourceManager);
		
		public static string Sentence()
		{
			return _lipsum.GenerateSentences(1)[0] ;
		}
		
		public static string Name()
		{
			var count = Int(3, 10);
			return Name(count);
		}
		
		public static string Name(int count)
		{
			return string.Join("", _lipsum.GenerateWords(count));
		}
		
		public static int Int()
		{
			return _numberGenerator.Next();
		}
		
		public static int Int(int max)
		{
			return _numberGenerator.Next(max) ;
		}
		
		public static int Int(int min, int max)
		{
			return _numberGenerator.Next(min, max);
		}
		
		public static DateTime Date()
		{
			return DateTime.MinValue + TimeSpan.FromMilliseconds(Int());
		}
		
		public static Image Image16x16()
		{
			return Images16x16[Int(Images16x16.Length)];
		}
		
		public static Glyph Glyph()
		{
			var index = Int(Images16x16.Length) ;
			return new Glyph(Images48x48[index], Images24x24[index], Images16x16[index]);
		}
	}
}
