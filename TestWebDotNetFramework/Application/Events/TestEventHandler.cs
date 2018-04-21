using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using MediatR;

namespace TestWebDotNetFramework.Application.Events
{
    public class TestEventHandler : INotificationHandler<TestEvent>
    {
        public async Task Handle(TestEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine(notification.Data);

        }
    }
}