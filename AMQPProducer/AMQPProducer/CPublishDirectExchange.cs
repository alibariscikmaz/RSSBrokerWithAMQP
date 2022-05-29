using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.Xml;

namespace AMQPProducer
{

    public class CPublishDirectExchange
    {

        private string title { get; set; }
        private string summary { get; set; }
        private string author { get; set; }
        private string publish_date { get; set; }
        private string url { get; set; }

        public void PublishToExchange(IModel channel, string topic, CPublishDirectExchange message)
        {
            channel.ExchangeDeclare("direct-exchange", ExchangeType.Direct);

            var json = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message));

            channel.BasicPublish("direct-exchange", topic, null, json);
        }

        static public List<CPublishDirectExchange> RSSURLToMessages(string url)
        {
            var messages = new List<CPublishDirectExchange>();

            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            foreach (var item in feed.Items)
            {
                messages.Add(new CPublishDirectExchange { title = item.Title.Text, summary = item.Summary.Text, author = item.Authors.ToString(), publish_date = item.PublishDate.ToString(), url = item.Links.ToString() });
            }

            return messages;
        }
    }
}
