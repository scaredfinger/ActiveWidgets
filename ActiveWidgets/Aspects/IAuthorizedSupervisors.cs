using System.Collections.Generic;
using ActiveWidgets;

namespace ActiveWidgets.Aspects
{
    /// <summary>
    /// Takes a list of widgets and filters those not available for current user type
    /// </summary>
    public interface IAuthorizedWidgets
    {
        /// <summary>
        /// Does the actual filtering
        /// </summary>
        /// <param name="supervisors">List of supervisors</param>
        /// <returns>List of supervisors authorized for specified user type</returns>
        IEnumerable<IWidget> Among(IEnumerable<IWidget> supervisors);
    }
}