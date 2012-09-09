using System;

namespace ActiveWidgets
{
    /// <summary>
    /// Registers menu items that would be shown when specified supervisor becomes active
    /// </summary>
    public class MenuFor<TWidget> : IMenuFor<TWidget> 
        where TWidget : IWidget
    {
        private readonly IWidgetMenuItems _menuItems;

        /// <summary>
        /// Creates an instance
        /// </summary>
        /// <param name="menuItems">menu items</param>
        public MenuFor(IWidgetMenuItems menuItems)
        {
            _menuItems = menuItems;
        }

        /// <summary>
        /// Registers menu item widgets for <c>TWidget</c>
        /// </summary>
        /// <typeparam name="TMenuItem">Menu widget supervisor</typeparam>
        public void Register<TMenuItem>() 
        	where TMenuItem : IWidget
        {
            _menuItems.Register<TWidget, TMenuItem>();
        }

        /// <summary>
        /// Registers menu item widgets for <c>TWidget</c>
        /// </summary>
        /// <type name="menuItemType">Menu item widget</type>
        public void Register(Type menuItemType)
        {
            _menuItems.Register(typeof (TWidget), menuItemType);
        }
    }
}