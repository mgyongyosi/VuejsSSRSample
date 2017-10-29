using System;
using System.Collections.Generic;

namespace VuejsSSRSample.Models
{
    public static class FakeMessageStore
    {
        private static DateTime startDateTime = new DateTime(2016, 08, 28);

        public static readonly List<Message> FakeMessages = new List<Message>()
        {
            Message.CreateMessage("First message title", "First message text", startDateTime),
            Message.CreateMessage("Second message title", "Second message text", startDateTime.AddDays(1)),
            Message.CreateMessage("Third message title", "Third message text", startDateTime.AddDays(2)),
            Message.CreateMessage("Fourth message title", "Fourth message text", startDateTime.AddDays(3)),
            Message.CreateMessage("Fifth message title", "Fifth message text", startDateTime.AddDays(4)),
            Message.CreateMessage("Sixth message title", "Sixth message text", startDateTime.AddDays(5)),
        };
    }
}
