using ActiveWidgets.Menus;
using ActiveWidgets.Tests.Domain;
using Moq;
using NUnit.Framework;

namespace ActiveWidgets.Tests.Units.Menus
{
    [TestFixture]
    public class MenuForFixture
    {        
        private MenuFor<SampleWidget> _menu;

        private Mock<IWidgetMenuItems> _activeMenuItemMock;
        private IWidgetMenuItems _menuWhenActiveMenuItem;

        [SetUp]
        public void SetUp()
        {
            _activeMenuItemMock = new Mock<IWidgetMenuItems>();
            _menuWhenActiveMenuItem = _activeMenuItemMock.Object;

            _menu = new MenuFor<SampleWidget>(_menuWhenActiveMenuItem);
        }

        [Test]
        public void Can_create_instances()
        {
            Assert.That(_menu, Is.Not.Null);
        }

        [Test]
        public void Register_calls_activeMenuItems_Register_generic()
        {
            _menu.Register<MenuWidget>();

            _activeMenuItemMock.Verify(m => m.Register<SampleWidget, MenuWidget>());
        }

        [Test]
        public void Register_calls_activeMenuItems_Register()
        {
            _menu.Register(typeof(MenuWidget));

            _activeMenuItemMock.Verify(m => m.Register(typeof(SampleWidget), typeof(MenuWidget)));
        }
    }
}