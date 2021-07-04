using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Threading;

namespace WS
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class ws_chat : System.Web.Services.WebService
    {
        
        public event EventHandler<string> SendMessageEvent;
        [WebMethod]
        public List<Participant> Participer(string pseudo)
        {
            if (!DB.Exist(pseudo))
            {
                DB.Add(pseudo);
                return DB.getListParticipants();
            }
            

            return null;
        }

        [WebMethod]
        public void Quiter(string pseudo)
        {
            DB.Delete(pseudo);
        }

        [WebMethod]
        public void ClearAll()
        {
            DB.Clear();
        }

        [WebMethod]
        public List<ChatMessage> SendMessage(string text,string pseudo)
        {
            ChatMessage cm = new ChatMessage(text, pseudo);
            if(cm != null)
            {
                DB.AddMessage(cm);
                SendMessageEvent?.Invoke(this, text);
                return DB.getListMessages();
            }
            return null;
            
        }
        [WebMethod]
        public List<ChatMessage> AllMessages()
        {
            return DB.getListMessages();
        }
    }
}
