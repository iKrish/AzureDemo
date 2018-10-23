using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Storage.Queue;

namespace AzureDemo.Models
{
    public class QueueSa
    {

        public int TotalOfMessages { get; set; }
        public string Message { get; set; }
        public IEnumerable<CloudQueueMessage> Messages { get; set; }
    }
}