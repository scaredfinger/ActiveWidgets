using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using ActiveWidgetf.Utils;
using NUnit.Framework;

namespace ActiveWidgets.Units.Utils
{
    [TestFixture]
    public class AllTypesFixture
    {
        [Test]
        public void InCurrentAssembly_returns_all_types_from_current_assembly()
        {
            var actual = AllTypes.InCurrentAssembly();

            Assert.That(actual, Is.EquivalentTo(Assembly.GetExecutingAssembly().GetTypes()));
        }
        
        [Test]
        public void InAssemblyNamed_returns_all_types_from_assembly_containing()
        {
            var actual = AllTypes.InAssemblyContaining(typeof(object));

            Assert.That(actual, Is.EquivalentTo(Assembly.GetAssembly(typeof(object)).GetTypes()));
        }

        [Test]
        public void InAssemblyNamed_returns_all_types_from_assembly_containing_generic()
        {
            var actual = AllTypes.InAssemblyContaining<object>();

            Assert.That(actual, Is.EquivalentTo(Assembly.GetAssembly(typeof(object)).GetTypes()));
        }

        [Test]
        public void InAllLoadedAssemblies_returns_all_types_from_all_assemblies()
        {
            IEnumerable<Type> actual = AllTypes.InAllLoadedAssemblies();

            Assert.That(actual, Is.EqualTo(AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())));
        }
    }
}
