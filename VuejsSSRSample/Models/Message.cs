using Newtonsoft.Json;
using System;

namespace VuejsSSRSample.Models
{
    public class Message
    {
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        private Message() { }

        public static Message CreateMessage(string title, string text, DateTime date)
        {
            return new Message()
            {
                Title = title,
                Text = text,
                Date = date
            };
        }
    }
}
