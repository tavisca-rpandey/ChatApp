using System;

namespace ChatApp
{
    public class Message
    {
        private string _text;

        public Message(string msg)
        {
            _text = msg;
        }
        public void DisplayRecievedMsg()
        {
            const string format = "{0,52}";

            Console.WriteLine(format,_text);
        }
    }
}
