using System;

namespace ActiveWidgets
{
    /// <summary>
    /// Presents a more clean way to register menu items than <see cref="IMenuWhenActive"/>. All menu
    /// items registered in this instance will be available when a supervisor of type <c>TWidget</c> gets
    /// active.
    /// </summary>
    /// <typeparam name="TWidget">Owner of this menu item set. This apparently unused parameter is 
    /// important for dependency injection.</typeparam>
    /// <remarks>
    /// This type instances make registering menu items easier and clearer than using <see cref="IMenuWhenActive"/>,
    /// but anyways the later will be used underneath.
    /// 
    /// To register menu items create a Bootstrap with a dependency to this type:
    /// <code>
    /// public class SomeStoryBootstrap
    /// {
    ///     public SomeStoryBootstrap(IMenuFor&lt;SomeStorySupervisor&gt; menu)
    ///     {
    ///         menu.Register&lt;CreateNewSupervisor&gt;();
    ///         menu.Register&lt;DeleteCurrentSupervisor&gt;();
    ///         menu.Register&lt;SaveCurrentSupervisor&gt;();
    ///         menu.Register&lt;NavigateBackSupervisor&gt;();
    ///     }
    /// }
    /// </code>
    /// </remarks>
    public interface IMenuFor<TWidget>
        where TWidget : IWidget
    {
        /// <summary>
        /// Registers menu item widgets for <c>TWidget</c>
        /// </summary>
        /// <typeparam name="TMenuItemWidget">Menu widget supervisor</typeparam>
        void Register<TMenuItemWidget>()
            where TMenuItemWidget : IWidget;

        /// <summary>
        /// Registers menu item widgets for <c>TWidget</c>
        /// </summary>
        /// <type name="widgetType">Menu widget</type>
        void Register(Type widgetType);
    }
}