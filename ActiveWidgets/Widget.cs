using System;
using ActiveWidgets.Controls;

namespace ActiveWidgets
{
    /// <summary>
    /// Base type for widgets
    /// </summary>
    /// <remarks>
    /// <typeparam name="TControl">
    /// Control type, could be a form or a user control. It's recommended
    /// to use interfaces, this way the supervisor will be weakly coupled to the control and will make
    /// automatic tests easier.
    /// </typeparam>
    public abstract class Widget<TControl> : IWidget, IDisposable
        where TControl : IElement
    {
        /// <summary>
        /// Gets the control to which this widget is coupled to
        /// </summary>
        public IElement Control
        {
            get { return TypedControl; }
        }

        /// <summary>
        /// Holds an instances to the control this instances will perform over and receive event from.
        /// </summary>
        protected TControl TypedControl { get; private set; }

        /// <summary>
        /// Creates an instance
        /// </summary>
        /// <param name="control">A UI element to couple with</param>
        protected Widget(TControl control)
        {
            TypedControl = control;
        }

        /// <summary>
        /// Activates the widget, so it can perform initialization tasks
        /// </summary>
        public void Activate()
        {
            OnActivated();
        }

        /// <summary>
        /// When override defines initialization tasks.
        /// </summary>
        /// <seealso cref="Activate"/>
        /// <seealso cref="Deactivate"/>
        protected virtual void OnActivated()
        {
        }

        /// <summary>
        /// Notifies the supervisor it has become inactive, so it can stop any task it might be doing on
        /// background and come to a standby state
        /// </summary>
        /// <seealso cref="Activate"/>
        public void Deactivate()
        {
            OnDeactivated();
        }

        /// <summary>
        /// When override defines tasks to take the widget into standby state.
        /// </summary>
        /// <seealso cref="Deactivate"/>
        /// <seealso cref="Activate"/>
        protected virtual void OnDeactivated()
        {

        }

        /// <summary>
        /// Implements the default controlled destruction mechanism
        /// </summary>
        public virtual void Dispose()
        {

        }
    }
}