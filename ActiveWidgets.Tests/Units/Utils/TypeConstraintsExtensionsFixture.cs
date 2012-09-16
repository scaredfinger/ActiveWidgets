using System;
using ActiveWidgets.Utils;
using NUnit.Framework;

/// <summary>
/// This class is needed as a testcase
/// </summary>
public class RootLevel
{
}

namespace ActiveWidgets.Tests.Units.Utils
{
    [TestFixture]
    public class TypeConstraintsExtensionsFixture
    {
        public class DecoratorAttribute : Attribute
        {
        }

        [Decorator]
        public class Decorated
        {
        }

        public class NotDecorated
        {
        }

        private interface II
        {
        }

        private interface IA
        {
        }

        private class A : IA
        {
        }

        private abstract class B
        {
        }

        [Test]
        public void Implements_returns_true_for_implemented_interfaces()
        {
            var result = typeof(A).Implements(typeof(IA));

            Assert.That(result, Is.True);
        }

        [Test]
        public void Implements_returns_true_for_implemented_interfaces_generic()
        {
            var result = typeof(A).Implements<IA>();

            Assert.That(result, Is.True);
        }

        [Test]
        public void Implements_returns_false_for_implemented_interfaces()
        {
            var result = typeof(A).Implements(typeof(II));

            Assert.That(result, Is.False);
        }

        [Test]
        public void Implements_returns_false_for_implemented_interfaces_generic()
        {
            var result = typeof(A).Implements<II>();

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsAssignableTo_returns_true_for_assignable()
        {
            var result = typeof(A).IsAssignableTo(typeof(object));

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsAssignableTo_returns_false_for_non_assignable()
        {
            var result = typeof(A).IsAssignableTo(typeof(int));

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsAssignableTo_returns_true_for_assignable_generic()
        {
            var result = typeof(A).IsAssignableTo<object>();

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsAssignableTo_returns_false_for_non_assignable_generic()
        {
            var result = typeof(A).IsAssignableTo<int>();

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsInNamespace_returns_true_for_matching()
        {
            var result = typeof(A).IsInNamespace("ActiveWidgets.Tests.Units.Utils");

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsInNamespace_returns_false_for_non_matching()
        {
            var result = typeof(A).IsInNamespace("Superman");

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsInNamespace_retruns_false_for_null()
        {
            var result = typeof(RootLevel).IsInNamespace("");

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsConcrete_returns_true_for_concrete_types()
        {
            var result = typeof(A).IsConcrete();

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsConcrete_return_false_for_abstract_types()
        {
            var result = typeof(B).IsConcrete();

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsConcrete_returns_false_for_interfaces()
        {
            var result = typeof(IA).IsConcrete();

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsDecoratedWith_with_returns_false_if_not_decorated_with_attribute()
        {
            var result = typeof(NotDecorated).IsDecoratedWith(typeof(DecoratorAttribute));

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsDecoratedWith_with_returns_true_if_decorated_with_attribute()
        {
            var result = typeof(Decorated).IsDecoratedWith(typeof(DecoratorAttribute));

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsDecoratedWith_generic_with_returns_false_if_not_decorated_with_attribute()
        {
            var result = typeof(NotDecorated).IsDecoratedWith<DecoratorAttribute>();

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsDecoratedWith_generic_with_returns_true_if_decorated_with_attribute()
        {
            var result = typeof(Decorated).IsDecoratedWith<DecoratorAttribute>();

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsNotDecoratedWith_returns_true_if_not_decorated_with_attribute()
        {
            var result = typeof(NotDecorated).IsNotDecoratedWith(typeof(DecoratorAttribute));

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsNotDecoratedWith_returns_false_if_decorated_with_attribute()
        {
            var result = typeof(Decorated).IsNotDecoratedWith(typeof(DecoratorAttribute));

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsNotDecoratedWith_generic_with_returns_true_if_not_decorated_with_attribute()
        {
            var result = typeof(NotDecorated).IsNotDecoratedWith<DecoratorAttribute>();

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsNotDecoratedWith_generic_with_returns_false_if_decorated_with_attribute()
        {
            var result = typeof(Decorated).IsNotDecoratedWith<DecoratorAttribute>();

            Assert.That(result, Is.False);
        }
    }
}