using System;

namespace ActiveWidgets.Controls
{
    /// <summary>
    /// Represents an adapter for actual toolbar items. Toolbar items are only known to the 
    /// ui elements. So we must provide a mechanism to hide them to the application logic layer.
    /// </summary>
    public interface IMenuElement : IElement
    {        
        /// <summary>
        /// Notifies the item has been actioned, e.g. Clicked
        /// </summary>
        event EventHandler Action;        
    }
}
