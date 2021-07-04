using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public string Pseudo { get; set; }

        public ChatMessage()
        {
        }

        public ChatMessage(string text,string pseudo)
        {
            Text = text;
            Pseudo = pseudo;
        }
    }
}