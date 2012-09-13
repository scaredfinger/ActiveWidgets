using System;
using System.Threading;
using ActiveWidgets.Services;
using NUnit.Framework;

namespace ActiveWidgets.Units.Services
{	
	[TestFixture]
	public class ServiceBusFixture
	{
		public class Message{
			public string Text { get; set; }
		}
		
		private ServiceBus _bus ;
		
		[SetUp]
		public void Setup()
		{
			_bus = new ServiceBus();
		}
		
		[Test]
		public void Can_create_instances()
		{
			Assert.That(_bus, Is.Not.Null);
		}
		
		[Test]
		public void SubscribeTo_sets_the_function_into_bus()
		{
			var untilSubscriptionHasBeenCalled = new ManualResetEvent(false) ;
			_bus.SubscribeTo<Message>(x => untilSubscriptionHasBeenCalled.Set());
			
			_bus.SendMessage(new Message());

			var timeoutWasNotReached = untilSubscriptionHasBeenCalled.WaitOne(50);
			Assert.That(timeoutWasNotReached);
		}
		
		[Test]
		public void SubscribeTo_sets_more_than_one_function()
		{
			var called = 0 ;

			_bus.SubscribeTo<Message>(x => called |= 1);
			_bus.SubscribeTo<Message>(x => called |= 2);
			_bus.SubscribeTo<Message>(x => called |= 4);
			
			_bus.SendMessage(new Message());
			
			Thread.Sleep(50) ;
			Assert.That(called, Is.EqualTo(7));
		}
	}
}
