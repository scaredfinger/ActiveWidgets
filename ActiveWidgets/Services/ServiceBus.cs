using System;
using System.Collections.Generic;

namespace ActiveWidgets.Services
{
	/// <summary>
	/// Provides a very basic implementation for the Enterprise Service Bus pattern
	/// </summary>
	public class ServiceBus : IServiceBus
	{
		private readonly Dictionary<Type, Delegate> _messageSubscribers = 
			new Dictionary<Type, Delegate>();

		/// <summary>
		/// Subscribes specified function to messages of type <c>TMessage</c>
		/// </summary>
		/// <param name="subscriber">Function to subscribe</param>
		public void SubscribeTo<TMessage>(Action<TMessage> subscriber)
		{
			var messageType = typeof(TMessage);

			var subscriptionList = Delegate.Combine(GetSubscriptionList(messageType), subscriber);

			_messageSubscribers[messageType] = subscriptionList;
		}

		private Delegate GetSubscriptionList(Type messageType)
		{
			return _messageSubscribers.ContainsKey(messageType) ? _messageSubscribers[messageType] : null;
		}

		/// <summary>
		/// Sends a message of specified type
		/// </summary>
		/// <param name="message">Message instance</param>
		public void SendMessage<TMessage>(TMessage message)
		{
			var messageType = typeof(TMessage);

			var subscriptionList = GetSubscriptionList(messageType);

			if (subscriptionList == null)
				return;

			Action subscriptionListExecute = () => subscriptionList.DynamicInvoke(message);
			subscriptionListExecute.BeginInvoke(null, null);
		}
	}
}
