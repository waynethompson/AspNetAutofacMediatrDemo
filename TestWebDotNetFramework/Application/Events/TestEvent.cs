using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediatR;

namespace TestWebDotNetFramework.Application.Events
{
    public class TestEvent : INotification
    {
        public TestEvent(string data)
        {
            Data = data;
        }

        public string Data { get; private set; }
    }
}