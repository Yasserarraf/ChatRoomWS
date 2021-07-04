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
    public partial class Auth : Form
    {
        srv.ws_chatSoapClient srv = new srv.ws_chatSoapClient();
        public Auth()
        {
            InitializeComponent();
        }

        private void btnParticiper_Click(object sender, EventArgs e)
        {
            srv.Participant[] participants = srv.Participer(pseudotxtBox.Text);
            srv.ChatMessage[] messages = srv.AllMessages();

            if(participants == null)
            {
                Text = "votre pseudo est deja utilise !";
               
                Participation participationfrm = new Participation(pseudotxtBox.Text, participants, messages);
                //participationfrm.ShowDialog();
                participationfrm.Show();

            }
            else
            {
                Text = "votre partiipation est accepté";
                Participation participationfrm = new Participation(pseudotxtBox.Text, participants, messages);
                //participationfrm.ShowDialog();
                participationfrm.Show();
            }
        }

        
    }
}
