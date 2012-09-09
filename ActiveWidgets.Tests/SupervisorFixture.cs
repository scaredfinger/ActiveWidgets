using System;
using ActiveWidgets;
using ActiveWidgets.Controls;
using NUnit.Framework;

namespace Unit.Widgets
{
    [TestFixture]
    public class SupervisorFixture
    {
        private interface ISampleControl : IElement
        {
        }

        private class SampleControl : ISampleControl
        {
        	
			public void Disable()
			{
				throw new NotImplementedException();
			}
        	
			public void Enable()
			{
				throw new NotImplementedException();
			}
        }

        private class SampleWidgetSupervisor : Widget<ISampleControl>
        {
            public SampleWidgetSupervisor(ISampleControl control) : base(control)
            {
            }
        }

        private static readonly SampleControl Control = new SampleControl();

        private SampleWidgetSupervisor _widgetSupervisor;

        [SetUp]
        public void SetUp()
        {
            _widgetSupervisor = new SampleWidgetSupervisor(Control);
        }

        [Test]
        public void Can_create_instances()
        {
            Assert.That(_widgetSupervisor, Is.Not.Null);
        }

        [Test]
        public void Constructor_sets_the_control()
        {
            Assert.That(_widgetSupervisor, Has.Property("Control").SameAs(Control));
        }

        [Test]
        public void CoupleWith_sets_widget_control_to_parameter()
        {
            Assert.That(_widgetSupervisor, Has.Property("Control").SameAs(Control));
        }

        [Test]
        public void Dispose_throws_no_exceptions()
        {
            Assert.DoesNotThrow(() => _widgetSupervisor.Dispose());
        }
    }
}