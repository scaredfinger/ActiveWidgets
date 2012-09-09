
using System;
using ActiveWidgets.Controls;
using ActiveWidgets;

namespace ActiveWidgets.Tests.Domain
{
	public class SampleWidget : Widget<ISampleControl>
	{
		public SampleWidget(ISampleControl control)
			: base(control)
		{
		}
	}
}
