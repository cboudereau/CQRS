using System;
using System.Threading;
using BookARoom.Domain;

namespace BookARoom.Infra.MessageBus
{
    public class AsynchronousThreadPoolPublicationStrategy : IPublishToHandlers
    {
        public void PublishTo<T>(Action<Message> handler, T @event) where T : Event
        {
            //dispatch on thread pool for added awesomeness
            ThreadPool.QueueUserWorkItem(x => handler(@event));
        }
    }
}