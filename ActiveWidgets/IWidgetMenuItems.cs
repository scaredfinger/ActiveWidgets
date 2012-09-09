using System;
using System.Collections.Generic;
using ActiveWidgets.Controls;

namespace ActiveWidgets
{
    /// <summary>
    /// Keeps a registry of widget menu items. 
    /// </summary>
    /// <remarks>
    /// Menu items are widgets (the "menu widgets"), objects of type <c>IWidgetMenuItems</c> 
    /// keep track of menu items shown along an specific widget (the "target widget"). The target
    /// widget doesn't have to be aware of menu items available to it. But some how this are
    /// the options shown along the target widget.
    /// </remarks>
    /// <seealso cref="IMenuFor{TWidget}"></seealso>
    public interface IWidgetMenuItems
    {
        /// <summary>
        /// Registers a menu widget for specified target widget.
        /// </summary>
        /// <seealso cref="Register(Type,Type)"/>
        /// <typeparam name="TMenuItemWidget">Menu widget</typeparam>
        /// <typeparam name="TTargetWidget">Target widget</typeparam>
        void Register<TMenuItemWidget, TTargetWidget>()
            where TMenuItemWidget : IWidget
        	where TTargetWidget : IWidget;

        /// <summary>
        /// Registers a menu widget for specified target widget.
        /// </summary>
        /// <seealso cref="Register{TMenuItemWidget, TTargetWidget}"/>
        /// <param name="menuWidgetType">Menu widget</param>
        /// <param name="targetWidgetType">Target widget</param>
        void Register(Type menuWidgetType, Type targetWidgetType);

        /// <summary>
        /// Returns the menu widgets registered as menu for specified widget
        /// </summary>
        /// <param name="widgetType">Target widget supervisor</param>
        /// <returns>A collection with widgets for specified supervisor</returns>
        IEnumerable<IMenuElement> GetMenuFor(Type widgetType);

        /// <summary>
        /// Returns the widgets registered as menu for specified supervisor
        /// </summary>
        /// <typeparam name="TWidget">Target widget supervisor</typeparam>
        /// <returns>A collection with widgets for specified supervisor</returns>
        IEnumerable<IMenuElement> GetMenuFor<TWidget>()
            where TWidget : IWidget;
    }
}