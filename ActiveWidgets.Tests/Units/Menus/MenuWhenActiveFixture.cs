using System;
using System.Linq;
using ActiveWidgets.Controls;
using ActiveWidgets.Menus;
using Moq;
using NUnit.Framework;

namespace ActiveWidgets.Units.Menus
{
    [TestFixture]
    public class MenuWhenActiveFixture
    {
        private class MenuControl : IMenuElement
        {
            public void Disable()
            {
            }

            public void Enable()
            {
            }
        	
			public event EventHandler Action;
			
			private void OnAction(EventArgs e)
			{
				if (Action != null)
					Action(this, e) ;
			}
        }

        private static readonly MenuControl ControlInstance = new MenuControl();

        private class SampleSupervisor : IWidget
        {
            public IElement Control
            {
                get { return null; }
            }

            public void Activate()
            {
                throw new System.NotImplementedException();
            }

            public void Deactivate()
            {
                throw new System.NotImplementedException();
            }
        }

        private class MenuSupervisor : IWidget
        {
            public IElement Control
            {
                get { return ControlInstance; }
            }

            public void Activate()
            {
                throw new System.NotImplementedException();
            }

            public void Deactivate()
            {
                throw new System.NotImplementedException();
            }
        }

        private static readonly MenuControl UnauthorizedInstance = new MenuControl();

        private class UnauthorizedSupervisor : IWidget
        {
            public IElement Control
            {
                get { return UnauthorizedInstance; }
            }

            public void Activate()
            {
                throw new System.NotImplementedException();
            }

            public void Deactivate()
            {
                throw new System.NotImplementedException();
            }
        }

        private static readonly MenuSupervisor Supervisor = new MenuSupervisor();
        private static readonly UnauthorizedSupervisor Unauthorized = new UnauthorizedSupervisor();

        private WidgetMenuItems _widgetMenuItems;

        private Mock<IAllWidgets> _allWidgets;
        
        [SetUp]
        public void SetUp()
        {
            _allWidgets = new Mock<IAllWidgets>();
            _allWidgets.Setup(m => m.GetWidget(typeof (MenuSupervisor)))
                .Returns(Supervisor);
            _allWidgets.Setup(m => m.GetWidget(typeof(UnauthorizedSupervisor)))
                .Returns(Unauthorized);

            _widgetMenuItems = new WidgetMenuItems(_allWidgets.Object);
        }

        [Test]
        public void Can_create_instances()
        {
            Assert.That(_widgetMenuItems, Is.Not.Null);
        }

        [Test]
        public void GetMenuItemsFor_result_starts_empty()
        {
            var list = _widgetMenuItems.GetMenuFor(typeof (SampleSupervisor));

            Assert.That(list, Is.Empty);
        }

        [Test]
        public void GetMenuItemsFor_calls_allWidgets_GetSupervisor_if_registered()
        {
            _widgetMenuItems.Register(typeof(MenuSupervisor), typeof(SampleSupervisor));

            var result = _widgetMenuItems.GetMenuFor(typeof (SampleSupervisor)).ToList();

            _allWidgets.Verify(m => m.GetWidget(typeof(MenuSupervisor)));
        }

        [Test]
        public void GetMenuItemsFor_calls_allWidgets_GetSupervisor_if_registered_using_generic()
        {
            _widgetMenuItems.Register<MenuSupervisor, SampleSupervisor>();

            var list = _widgetMenuItems.GetMenuFor(typeof(SampleSupervisor));
            var array = list.ToArray();

            _allWidgets.Verify(m => m.GetWidget(typeof(MenuSupervisor)));
        }

        [Test]
        public void GetMenuItemsFor_returns_allWidgets_GetSupervisor_if_registered()
        {
            _widgetMenuItems.Register(typeof(MenuSupervisor), typeof(SampleSupervisor));

            var list = _widgetMenuItems.GetMenuFor(typeof(SampleSupervisor));

            Assert.That(list, Has.Some.EqualTo(ControlInstance));
        }

        [Test]
        public void GetMenuItemsFor_returns_allWidgets_GetSupervisor_if_registered_using_generic()
        {
            _widgetMenuItems.Register<MenuSupervisor, SampleSupervisor>();

            var list = _widgetMenuItems.GetMenuFor(typeof(SampleSupervisor));

            Assert.That(list, Has.Some.EqualTo(ControlInstance));
        }


        [Test]
        public void GetMenuItemsFor_generic_returns_allWidgets_GetSupervisor_if_registered()
        {
            _widgetMenuItems.Register(typeof(MenuSupervisor), typeof(SampleSupervisor));

            var list = _widgetMenuItems.GetMenuFor<SampleSupervisor>();

            Assert.That(list, Has.Some.EqualTo(ControlInstance));
        }

        [Test]
        public void GetMenuItemsFor_generic_returns_allWidgets_GetSupervisor_if_registered_using_generic()
        {
            _widgetMenuItems.Register<MenuSupervisor, SampleSupervisor>();

            var list = _widgetMenuItems.GetMenuFor<SampleSupervisor>();

            Assert.That(list, Has.Some.EqualTo(ControlInstance));
        }
    }
}
