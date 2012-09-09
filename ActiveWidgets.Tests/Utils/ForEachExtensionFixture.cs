using System.Collections.Generic;
using ActiveWidgets.Utils;
using NUnit.Framework;

namespace ActiveWidgets.Tests.Utils
{
    [TestFixture]
    public class ForEachExtensionFixture
    {
        [Test]
        public void ForEach_with_action_executes_function_over_every_element()
        {
            var executeWith = new List<int>();
            var elements = new[] { 1, 2, 3, 4 };

            elements.ForEach(executeWith.Add);

            Assert.That(executeWith, Is.EquivalentTo(elements));
        }

        [Test]
        public void ForEach_with_function_executes_function_over_every_element()
        {
            var executeWith = new List<int>();
            var elements = new[] {1, 2, 3, 4};

            elements.ForEach(x => 
            { 
                executeWith.Add(x);
                return x;
            });

            Assert.That(executeWith, Is.EquivalentTo(elements));
        }
    }
}
