﻿using Nop.Core.Domain.Orders;
using Nop.Core.Events;

namespace Nop.Services.Orders
{
    public static class EventPublisherExtensions
    {
        /// <summary>
        /// Publishes the order paid event.
        /// </summary>
        /// <param name="eventPublisher">The event publisher.</param>
        /// <param name="order">The order.</param>
        public static void PublishOrderPaid(this IEventPublisher eventPublisher, Order order)
        {
            eventPublisher.Publish(new OrderPaidEvent(order));
        }
        /// <summary>
        /// Publishes the order placed event.
        /// </summary>
        /// <param name="eventPublisher">The event publisher.</param>
        /// <param name="order">The order.</param>
        public static void PublishOrderPlaced(this IEventPublisher eventPublisher, Order order)
        {
            eventPublisher.Publish(new OrderPlacedEvent(order));
        }
    }
}