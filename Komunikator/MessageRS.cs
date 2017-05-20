using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komunikator
{
    class MessageRS
    {
        private string message;
        private List<string> message_encoded = new List<string>();

        public string GetMessage()
        {
            return message;
        }
        public void SetMessage(string message)
        {
            this.message = message;
        }
        public string GetEncodedMessage()
        {
            string return_message = string.Join(" ", message_encoded.ToArray()); //konwertujemy liste stringów na stringa
            return return_message;
        }
        public void SetEncodedMessage(List<string> message)
        {
            message_encoded.Clear();
            foreach(string item in message)
            {
                message_encoded.Add(item);
            }

        }
        public void EncodeMessage()
        {
            //TODO kodowanie wiadomosci do RS
        }
        public void DecodeMessage()
        {
            //TODO dekodowanie wiadomosci z RS

        }
        public MessageRS()
        {
            message = "";
            message_encoded.Clear();
        }
    }
}
