
namespace Example13
{
    partial class MainForm
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
            this.buttonParty = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonParty
            // 
            this.buttonParty.Location = new System.Drawing.Point(34, 46);
            this.buttonParty.Name = "buttonParty";
            this.buttonParty.Size = new System.Drawing.Size(75, 23);
            this.buttonParty.TabIndex = 0;
            this.buttonParty.Text = "Party";
            this.buttonParty.UseVisualStyleBackColor = true;
            this.buttonParty.Click += new System.EventHandler(this.buttonParty_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(141, 46);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(75, 23);
            this.buttonUser.TabIndex = 1;
            this.buttonUser.Text = "User";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 264);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonParty);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonParty;
        private System.Windows.Forms.Button buttonUser;
    }
}