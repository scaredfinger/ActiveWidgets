using ActiveWidgets.Controls;

namespace Store.Modules.Core
{
    /// <summary>
    /// UI Element interface for main widget.
    /// </summary>
    public interface IMainControl : IElement
    {
        /// <summary>
        /// Sets the main widget view model, this model contains all menus.
        /// </summary>
        /// <param name="model">View</param>
        void SetViewModel(MainViewModel model);
    }
}