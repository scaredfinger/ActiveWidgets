using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ActiveWidgetf.Utils
{
    /// <summary>
    /// Allow access to type collections available in the system.
    /// </summary>
    /// <remarks>
    /// This type could be used to get type collections needed for other methods. Like registering types in 
    /// a service locator or <see cref="IComponentContainer">IoC container</see>. Since the collections 
    /// returned are just enumerables they could be filtered event more using Linq.
    /// </remarks>
    /// <code>
    /// var allAbstractClasses = AllTypes.InCurrentAssembly().Where(x => x.IsAbstract);
    /// 
    /// var allInterfacesImplementedByAbstractClasses = allAbstractClasses.SelectMany(x => x.GetInterfaces());
    /// </code>
    public static class AllTypes
    {
        /// <summary>
        /// Returns all types in current assembly
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Type> InCurrentAssembly()
        {
            return Assembly.GetCallingAssembly().GetTypes();
        }

        /// <summary>
        /// Returns all types in the assembly containing the specified type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <seealso cref="InAssemblyContaining{TType}"/>
        public static IEnumerable<Type> InAssemblyContaining(Type type)
        {
            return Assembly.GetAssembly(type).GetTypes();
        }

        /// <summary>
        /// Returns all types in the assembly containing the specified type
        /// </summary>
        /// <typeparam name="TType"></typeparam>
        /// <returns></returns>
        /// <seealso cref="InAssemblyContaining(Type)"/>
        public static IEnumerable<Type> InAssemblyContaining<TType>()
        {
            return InAssemblyContaining(typeof (TType));
        }

        /// <summary>
        /// Returns all types from all loaded assemblies
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Type> InAllLoadedAssemblies()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes());
        }
    }
}
