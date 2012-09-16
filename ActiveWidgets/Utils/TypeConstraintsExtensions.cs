using System;
using System.Linq;

namespace ActiveWidgets.Utils
{
    /// <summary>
    /// Represents filters that can be used when registered a bunch of types into a container
    /// </summary>
    /// <seealso cref="RegistrationExtensions"/>
    public static class TypeConstraintsExtensions
    {
        /// <summary>
        /// Returns true when a type implements a certain interface
        /// </summary>
        /// <param name="type"></param>
        /// <param name="interface"></param>
        /// <returns></returns>
        public static bool Implements(this Type type, Type @interface)
        {
            return type.GetInterfaces().Any(x => x == @interface);
        }
        
        /// <summary>
        /// Returns true when a type implements a certain interface
        /// </summary>
        /// <param name="type"></param>
        /// <typeparamref name="TType"/>
        /// <returns></returns>
        public static bool Implements<TType>(this Type type)
        {
            return type.Implements(typeof (TType));
        }

        /// <summary>
        /// Returns true when a type is assignable to some other type. It's is just a revert 
        /// logic for <see cref="Type.IsAssignableFrom(Type)"/>
        /// </summary>
        /// <param name="type"></param>
        /// <param name="base"></param>
        /// <returns></returns>
        public static bool IsAssignableTo(this Type type, Type @base)
        {
            return @base.IsAssignableFrom(type);
        }

        /// <summary>
        /// Returns true when a type is assignable to some other type. It's is just a revert 
        /// logic for <see cref="Type.IsAssignableFrom(Type)"/>
        /// </summary>
        /// <param name="type"></param>
        /// <typeparamref name="TType"/>
        /// <returns></returns>
        public static bool IsAssignableTo<TType>(this Type type)
        {
            return type.IsAssignableTo(typeof (TType));
        }

        /// <summary>
        /// Returns true then a type is in specified namespace
        /// </summary>
        /// <param name="type"></param>
        /// <param name="namespaceFragment"></param>
        /// <returns></returns>
        public static bool IsInNamespace(this Type type, string namespaceFragment)
        {
            return type.Namespace != null &&
                type.Namespace.Contains(namespaceFragment);
        }

        /// <summary>
        /// Returns true for non abstract types
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsConcrete(this Type type)
        {
            return !type.IsAbstract;
        }

        /// <summary>
        /// Gets whether specified type is decorated with specified attribute
        /// </summary>
        /// <param name="type">Type</param>
        /// <param name="attribute">Attribute</param>
        /// <returns>True if type is decorated with attribute, false otherwise</returns>
        /// <seealso cref="IsDecoratedWith{TAttribute}"/>
        /// <seealso cref="IsNotDecoratedWith"/>
        public static bool IsDecoratedWith(this Type type, Type attribute)
        {
            return type.GetCustomAttributes(attribute, true).Any();
        }

        /// <summary>
        /// Gets whether specified type is decorated with specified attribute
        /// </summary>
        /// <param name="type">Type</param>
        /// <typeparam name="TAttribute">Attribute</typeparam>
        /// <returns>True if type is decorated with attribute, false otherwise</returns>
        /// <seealso cref="IsDecoratedWith"/>
        /// <seealso cref="IsNotDecoratedWith{TAttribute}"/>
        public static bool IsDecoratedWith<TAttribute>(this Type type)
            where TAttribute : Attribute
        {
            return type.IsDecoratedWith(typeof (TAttribute));
        }

        /// <summary>
        /// Gets whether specified type is not decorated with specified attribute
        /// </summary>
        /// <param name="type">Type</param>
        /// <param name="attribute">Attribute</param>
        /// <returns>True if type is not decorated with attribute, false otherwise</returns>
        /// <seealso cref="IsNotDecoratedWith{TAttribute}"/>
        /// <seealso cref="IsDecoratedWith"/>
        public static bool IsNotDecoratedWith(this Type type, Type attribute)
        {
            return !type.IsDecoratedWith(attribute);
        }

        /// <summary>
        /// Gets whether specified type is not decorated with specified attribute
        /// </summary>
        /// <param name="type">Type</param>
        /// <typeparam name="TAttribute">Attribute</typeparam>
        /// <returns>True if type is not decorated with attribute, false otherwise</returns>
        /// <seealso cref="IsNotDecoratedWith"/>
        /// <seealso cref="IsDecoratedWith{TAttribute}"/>
        public static bool IsNotDecoratedWith<TAttribute>(this Type type)
            where TAttribute : Attribute
        {
            return ! type.IsDecoratedWith(typeof(TAttribute));
        }
    }
}