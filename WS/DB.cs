using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS
{
    public class DB
    {
        static List<Participant> participants = new List<Participant>();
        static List<ChatMessage> messages = new List<ChatMessage>();


        public static void Add(string pseudo)
        {
            participants.Add(new Participant(pseudo));
        }
        public static void AddMessage(ChatMessage message)
        {
            messages.Add(new ChatMessage(message.Text, message.Pseudo));
        }
        
        public static List<Participant> getListParticipants()
        {
            return participants;
        }
        public static List<ChatMessage> getListMessages()
        {
            return messages;
        }
        public static bool Exist(string pseudo)
        {
            Participant participant = participants.Where(p => p.Pseudo.Equals(pseudo)).FirstOrDefault();

            return participant != null;
        }
        
        public static void Delete(string pseudo)
        {
            participants = participants.Where(p => !p.Pseudo.Equals(pseudo)).ToList();
        }

        public static void Clear()
        {
            participants.Clear();
        }
        public static void ClearMessages()
        {
            messages.Clear();
        }
    }
}