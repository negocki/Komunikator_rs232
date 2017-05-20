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
            //bit startu 0 i 2 bity stopu 1
            message_encoded.Clear();

            foreach(char c in message)
            {
                int ascii_code = (int)c;
                string num_binary = Convert.ToString(ascii_code, 2);
                num_binary = num_binary.Insert(0, "0"); //bit startu
                num_binary = num_binary.Insert(num_binary.Length, "11"); //bity stopu
                message_encoded.Add(num_binary);
            }

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
