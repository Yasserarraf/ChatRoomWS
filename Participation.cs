
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discussion
{
    public partial class Participation : Form
    {
        srv.ws_chatSoapClient srv = new srv.ws_chatSoapClient();
        public string Pseudo { get; set; }
        
        List<srv.Participant> Participants { get; set; }
        List<srv.ChatMessage> chatMessages { get; set; }

        public Participation()
        {
            InitializeComponent();
            WireUpForm();
        }
        public void WireUpForm()
        {
            
        }
        private void CheckingMessages_SendMessageApprovedEvent(object sender, string e)
        {
            lstMessages.DataSource = null;
            lstMessages.DataSource = chatMessages.ToList();
            lstMessages.DisplayMember = "text";
        }
        public Participation(string pseudo, srv.Participant [] participants, srv.ChatMessage [] messages)
        {
            InitializeComponent();
            Pseudo = pseudo;
            if (participants != null)
            {
                Participants = participants.ToList();
            }
            
            chatMessages = messages.ToList();
           
        }

        private void Participation_Load(object sender, EventArgs e)
        {
            Text = "Mon pseudo est " + Pseudo;
            if(Participants !=null)
            {
                lstParticipants.DataSource = Participants.Where(p => !p.Pseudo.Equals(Pseudo)).ToList();
                lstParticipants.DisplayMember = "pseudo";
                lstMessages.DataSource = chatMessages.ToList();
                lstMessages.DisplayMember = "text";
            }
           
            
        }
        private void Participation_Close(object sender, EventArgs e)
        {
            srv.Quiter(Pseudo);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            srv.ChatMessage[] cMessages = srv.SendMessage(messagetxtBox.Text, Pseudo);
            srv.ChatMessage[] messages = srv.AllMessages();

            // sync the messages box
            if (cMessages != null)
            {
                lstMessages.DataSource = cMessages.ToList();
                lstMessages.DisplayMember = "text";
            }
            
        }
    }
}
