using System;
using System.Collections.Generic;
using System.Linq;
using ActiveWidgets.Aspects;
using ActiveWidgets.Controls;

namespace ActiveWidgets.Menus
{
    /// <summary>
    /// Keeps a registry of menu items that will be available when a widget becomes active. 
    /// All menu items should be registered here. This process will be done manually by the bootstraps, 
    /// it would be more confortable to use <see cref="IMenuFor{TWidget}"/>
    /// instead.
    /// </summary>
    public class MenuWhenActive : IWidgetMenuItems
    {
        private readonly IAllWidgets _allWidgets;
        private readonly Dictionary<Type, List<Type>> _registered = new Dictionary<Type, List<Type>>();

        /// <summary>
        /// Creates an instance
        /// </summary>
        /// <param name="allWidgets">All widgets</param>
        public MenuWhenActive(IAllWidgets allWidgets)
        {
            _allWidgets = allWidgets;
        }

        /// <summary>
        /// Registers a menu widget for specified target widget.
        /// </summary>
        /// <seealso cref="Register(Type,Type)"/>
        /// <typeparam name="TMenuItemWidget">Menu widget</typeparam>
        /// <typeparam name="TTargetWidget">Target widget</typeparam>
        public void Register<TMenuItemWidget, TTargetWidget>() 
            where TTargetWidget : IWidget 
            where TMenuItemWidget : IWidget
        {
            Register(typeof(TMenuItemWidget), typeof(TTargetWidget));
        }

        /// <summary>
        /// Registers a menu widget for specified target widget.
        /// </summary>
        /// <seealso cref="Register{TMenuItemWidget, TTargetWidget}"/>
        /// <param name="menuWidgetType">Menu widget</param>
        /// <param name="targetWidgetType">Target widget</param>
        public void Register(Type menuWidgetType, Type targetWidgetType)
        {
            var menuList = _registered.ContainsKey(targetWidgetType)
                               ? _registered[targetWidgetType]
                               : (_registered[targetWidgetType] = new List<Type>());

            menuList.Add(menuWidgetType);
        }

        /// <summary>
        /// Returns the widgets registered as menu for specified supervisor
        /// </summary>
        /// <param name="widgetType">Target widget supervisor</param>
        /// <returns>A collection with widgets for specified supervisor</returns>
        public IEnumerable<IMenuElement> GetMenuFor(Type widgetType)
        {
            if (!_registered.ContainsKey(widgetType))
                return new IMenuElement[0];
            
            return GetMenuWidgetsFor(widgetType)
                .Select(x => x.Control)
                .OfType<IMenuElement>();
        }

        private IEnumerable<IWidget> GetMenuWidgetsFor(Type widgetType)
        {
            return _registered[widgetType].Select(_allWidgets.GetWidget);
        }

        /// <summary>
        /// Returns the widgets registered as menu for specified supervisor
        /// </summary>
        /// <typeparam name="TWidget">Target widget supervisor</typeparam>
        /// <returns>A collection with widgets for specified supervisor</returns>
        public IEnumerable<IMenuElement> GetMenuFor<TWidget>()
            where TWidget : IWidget
        {
            return GetMenuFor(typeof (TWidget));
        }
    }
}