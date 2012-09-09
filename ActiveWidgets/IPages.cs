using System;
using System.Collections.Generic;
using ActiveWidgets.Controls;

namespace ActiveWidgets
{
    /// <summary>
    /// Navigates among page widgets. Allows changing the current widget.
    /// </summary>
    /// <summary>
    /// This type has been designed for single document interface applications.
    /// 
    /// Pages are active one at a time. There cannot be more than one page active at the same 
    /// time. A full sized control could be a page, a dialog could be a page. A page could 
    /// coexist at the same time with other kind of widgets, but not pages. 
    /// 
    /// To activate specific widget use:
    /// <code>
    /// pages.Goto&lt;WelcomeWidget&gt;();
    /// </code>
    /// </summary>
    public interface IPages
    {
        /// <summary>
        /// Gets current widget's control
        /// </summary>
        /// <returns></returns>
        IElement CurrentControl { get; }

        /// <summary>
        /// Gets the current widget
        /// </summary>
        /// <returns></returns>
        IWidget Current { get; }

        /// <summary>
        /// Sets the widget of specified type as active
        /// </summary>
        /// <param name="widgetType">Page widget type to go to</param>
        void Goto(Type widgetType);

        /// <summary>
        /// Sets the widget of specified type as active
        /// </summary>
        /// <typeparam name="TWidget">Page widget type to go to</typeparam>
        void Goto<TWidget>()
            where TWidget : IWidget;

        /// <summary>
        /// Navigates back to previosly active widget
        /// </summary>
        void GotoPrevious();

        /// <summary>
        /// Notifies the current widget has changed
        /// </summary>
        event EventHandler CurrentChanged;
    }
}