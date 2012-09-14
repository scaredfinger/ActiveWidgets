using System.Collections.Generic;
using ActiveWidgets.Controls;
using Store.Controls;
using Store.Domain;

namespace Store.Win.Tests.Tests
{
	public abstract class UiTest
	{
		public abstract void Run();

	    protected static IEnumerable<IMenuElementGroup> CreateMenuElementGroup()
	    {
	        var list = new List<IMenuElementGroup>();
	        for (var i = 0; i < 3 + Random.Int(5); i ++)
	            list.Add(new MenuElementGroup
	                         {
	                             Caption = Random.Name(),
	                             Tooltip = Random.Sentence(),
	                             Glyph = Random.Glyph(),
	                             Options = CreateMenuElements()
	                         });
	        return list;
	    }

	    protected static IEnumerable<IMenuElement> CreateMenuElements()
	    {
	        var list = new List<IMenuElement>();

	        for(var i = 0; i < 5 + Random.Int(10); i++)
	            list.Add(new MenuElement(Random.Name(), Random.Sentence(), Random.Glyph()));

	        return list;
	    }
	}
}
