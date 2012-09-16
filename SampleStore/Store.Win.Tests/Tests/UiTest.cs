using System;
using System.Collections.Generic;
using System.Windows.Forms;

using ActiveWidgets.Controls;
using Store.Controls;
using Store.Domain;

namespace Store.Win.Tests.Tests
{
	public abstract class UiTest
	{
		private readonly List<Control> _actions = new List<Control>();
		
		public InteractiveTests Owner { get; set; }
		
		public abstract string Name { get; }
		
		public virtual string Description { get { return string.Empty;} }
		
		public abstract string Module { get ; }
		
		public IEnumerable<Control> Actions
		{
			get {
				return _actions ;
			}
		}
		
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
	    
	    protected void AddAction(string name, Action action)
	    {
	    	var button = new Button()
	    	{
	    		Text = name
	    	};
	    	
	    	button.Click += (s, e) =>
	    		action();
	    	
	    	_actions.Add(button) ;
	    }
	}
}
