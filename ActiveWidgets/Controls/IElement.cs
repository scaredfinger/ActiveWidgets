namespace ActiveWidgets.Controls
{
    /// <summary>
    /// Represents a base type for every supervised UI element. 
    /// </summary>
    /// <remarks>
    /// Supervised elements will have no application logic. They will receive data from their 
    /// supervisors and will display it and receive user input and gestures and route it to 
    /// their supervisors via events. The elements should not be aware of the supervisors 
    /// existence. An element could be a control, a set of controls, or anything you 
    /// might need depending on the actual UI used.
    /// </remarks>
    public interface IElement
    {
        /// <summary>
        /// Disables this menu item
        /// </summary>
        void Disable();
        
        /// <summary>
        /// Enables this menu item
        /// </summary>
        void Enable();
    }
}