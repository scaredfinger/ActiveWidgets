
using System;
using ActiveWidgets.Controls;
using ActiveWidgets;

namespace ActiveWidgets.Tests.Domain
{
	public class MenuWidget : Widget<IMenuControl>
	{
		public MenuWidget(IMenuControl control)
			: base(control)
		{}
	}
}
