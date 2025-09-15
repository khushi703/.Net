using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace lab9_q3_mvc.Models
{
    public class OrderStore
    {
        private static ConcurrentBag<Order> _orders = new ConcurrentBag<Order>();
        private static int _idCounter = 0;

        public static void AddOrder(Order order)
        {
            order.Id = Interlocked.Increment(ref _idCounter);
            order.OrderDate = System.DateTime.Now;
            _orders.Add(order);
        }

        public static IEnumerable<Order> GetAll()
        {
            return _orders.OrderBy(o => o.OrderDate);
        }

        public static void ClearAll() // helpful during testing
        {
            _orders = new ConcurrentBag<Order>();
            _idCounter = 0;
        }
    }
}