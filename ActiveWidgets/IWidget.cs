using ActiveWidgets.Controls;

namespace ActiveWidgets
{
    /// <summary>
    /// Base type for widgets
    /// </summary>
    public interface IWidget
    {
        /// <summary>
        /// Gets the control to which this widget is coupled to
        /// </summary>
        IElement Control { get; }

        /// <summary>
        /// Activates the widget, so it can perform initialization tasks
        /// </summary>
        void Activate();

        /// <summary>
        /// Deactivates the widget so it can stop any task it might be doing on 
        /// background and come to a standby state.
        /// </summary>
        void Deactivate();
    }
}