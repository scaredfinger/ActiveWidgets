using System;
using System.Runtime.CompilerServices;

namespace ActiveWidgets
{
    /// <summary>
    /// Widgets contains the bases and interfaces for widgets general purpous widgets, which will be used 
    /// by many other widgets as well.
    /// </summary>
    /// <remarks>
    /// Widgets are the top level components of this application. They are have two parts a UI element, 
    /// such as: User controls, Dialogs and Menu buttons and a Supervisor. This way a great separation of
    /// concerns is achieved. We want our UI elements to be very, very dumb.
    /// 
    /// The supervisor will contain all behavior. Will interact with lower layers like <see cref="Services"/>
    /// or <see cref="Widgets">Widget API</see>. All will be sent to UI elements using public methods and
    /// entitie params, it's strongly recommended to use as many entities as needed but not to use more than 
    /// one param. Information from UI elements will be send to the supervisor using events, the use of 
    /// <see cref="EventHandler{T}"/> is strongly recommended. General event argument types should be defined
    /// on <see cref="Entities"/> namespace, other eventhandlers should be defined in their own story. The
    /// supervisor is an implementation of pattern Supervising Controller by Martin Fowler.
    /// 
    /// The UI element will be responsible for displaying information and receiving user input, some 
    /// minor decitions (like changing a font color to red for data outside bounders) are allowed but 
    /// not recommended, since it's very easy to start crossing the line and making UI elements fat with 
    /// behavior.
    /// 
    /// Other important types you will find in this namespace are the menu items registrar:
    /// <list type="bullet">
    ///     <item>
    ///         <term><see cref="IMainMenu">Main menu items</see></term>
    ///         <description>
    /// Holds global menu items.
    ///         </description>
    ///     </item>
    ///     <item>
    ///         <term><see cref="IMenuWhenActive">Active widget's menu items</see></term>
    ///         <description>
    /// Holds menu items that would be shown only when a certain widget is shown. The best way to populate
    /// this collection would be using <see cref="IMenuFor{TWidget}"/>
    ///         </description>
    ///     </item>
    ///     <item>
    ///         <term><see cref="IMenuFor{TWidget}">Menu items for</see></term>
    ///         <description>
    /// Tool to easily populate <see cref="IMenuWhenActive"/>
    ///         </description>
    ///     </item>
    /// </list>
    /// </remarks>
    [CompilerGenerated]
    class NamespaceDoc
    {
    }
}
