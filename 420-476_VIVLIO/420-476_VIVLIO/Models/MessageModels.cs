using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _420_476_VIVLIO.Models
{
    public class MessageModels
    {
        public int MessageID { get; set; }
        public int ReceiverID { get; set; }
        public int SenderID { get; set; }
        public string Message { get; set; }
    }
}