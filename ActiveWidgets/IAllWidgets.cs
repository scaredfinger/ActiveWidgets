using System;

namespace ActiveWidgets
{
    /// <summary>
    /// Keeps a registry of all widgets available in the system. Any new widget should be 
    /// registered in here.
    /// </summary>
    public interface IAllWidgets
    {
        /// <summary>
        /// Gets a registered widget instance
        /// </summary>
        /// <seealso cref="GetWidget{TWidget}()"/>
        /// <param name="widgetType">Type of the widget</param>
        /// <returns>A widget instance</returns>
        IWidget GetWidget(Type widgetType);

        /// <summary>
        /// Gets a registered widget instance
        /// </summary>
        /// <seealso cref="GetWidget(Type)"/>
        /// <typeparam name="TWidget">Type of the widget</typeparam>
        /// <returns>A widget instance</returns>
        TWidget GetWidget<TWidget>();
    }
}