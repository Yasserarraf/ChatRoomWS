
namespace Discussion
{
    partial class Participation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstParticipants = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.messagetxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstParticipants
            // 
            this.lstParticipants.FormattingEnabled = true;
            this.lstParticipants.ItemHeight = 20;
            this.lstParticipants.Items.AddRange(new object[] {
            "lstParticipants"});
            this.lstParticipants.Location = new System.Drawing.Point(18, 89);
            this.lstParticipants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstParticipants.Name = "lstParticipants";
            this.lstParticipants.Size = new System.Drawing.Size(236, 484);
            this.lstParticipants.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Participants";
            // 
            // messagetxtBox
            // 
            this.messagetxtBox.Location = new System.Drawing.Point(261, 532);
            this.messagetxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.messagetxtBox.Multiline = true;
            this.messagetxtBox.Name = "messagetxtBox";
            this.messagetxtBox.Size = new System.Drawing.Size(727, 41);
            this.messagetxtBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 437);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message Recus";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(997, 532);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(191, 41);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstMessages
            // 
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 20;
            this.lstMessages.Items.AddRange(new object[] {
            "Messages"});
            this.lstMessages.Location = new System.Drawing.Point(261, 89);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(922, 424);
            this.lstMessages.TabIndex = 8;
            // 
            // Participation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messagetxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstParticipants);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Participation";
            this.Text = "Participation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Participation_Close);
            this.Load += new System.EventHandler(this.Participation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstParticipants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox messagetxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstMessages;
    }
}