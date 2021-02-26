using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpamAPI.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string MessageFrom { get; set; }
        public string MessageSubject { get; set; }
        public string MessageDate { get; set; }
        public string MessageContent { get; set; }
    }
}
