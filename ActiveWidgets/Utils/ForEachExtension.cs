using System;
using System.Collections.Generic;

namespace ActiveWidgets.Utils
{
    /// <summary>
    /// Provides a simple extension to apply an action to many elements like 
    /// <see cref="List{T}.ForEach"/>
    /// </summary>
    public static class ForEachExtension
    {
        /// <summary>
        /// Applies an action to all elements in collection, just like <see cref="List{T}.ForEach"/>
        /// </summary>
        /// <typeparam name="TElement"></typeparam>
        /// <param name="collection"></param>
        /// <param name="action"></param>
        public static void ForEach<TElement> (this IEnumerable<TElement> collection,
            Action<TElement> action)
        {
            foreach (var element in collection)
                action(element);
        }
    }
}