
namespace Discussion
{
    partial class Auth
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
            this.btnParticiper = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pseudotxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnParticiper
            // 
            this.btnParticiper.Location = new System.Drawing.Point(579, 237);
            this.btnParticiper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParticiper.Name = "btnParticiper";
            this.btnParticiper.Size = new System.Drawing.Size(112, 35);
            this.btnParticiper.TabIndex = 0;
            this.btnParticiper.Text = "Participer";
            this.btnParticiper.UseVisualStyleBackColor = true;
            this.btnParticiper.Click += new System.EventHandler(this.btnParticiper_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mon Pseudo";
            // 
            // pseudotxtBox
            // 
            this.pseudotxtBox.Location = new System.Drawing.Point(324, 83);
            this.pseudotxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pseudotxtBox.Name = "pseudotxtBox";
            this.pseudotxtBox.Size = new System.Drawing.Size(278, 26);
            this.pseudotxtBox.TabIndex = 2;
           
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 315);
            this.Controls.Add(this.pseudotxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnParticiper);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Auth";
            this.Text = "Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParticiper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pseudotxtBox;
    }
}