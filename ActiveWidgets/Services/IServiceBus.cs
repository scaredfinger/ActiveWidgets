using System;
using System.Collections.Generic;

namespace ActiveWidgets.Services
{
	/// <summary>
	/// Provides a very basic implementation for the Enterprise Service Bus pattern
	/// </summary>
	public interface IServiceBus
	{
		/// <summary>
		/// Subscribes specified function to messages of type <c>TMessage</c>
		/// </summary>
		/// <param name="subscriber">Function to subscribe</param>
		void SubscribeTo<TMessage>(Action<TMessage> subscriber);
				
		/// <summary>
		/// Sends a message of specified type
		/// </summary>
		/// <param name="message">Message instance</param>
		void SendMessage<TMessage>(TMessage message);
	}
}
