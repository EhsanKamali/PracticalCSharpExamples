
namespace Example13
{
    partial class LoginForm
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.LableUserName = new System.Windows.Forms.Label();
            this.LabelPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(79, 6);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 0;
            // 
            // LableUserName
            // 
            this.LableUserName.AutoSize = true;
            this.LableUserName.Location = new System.Drawing.Point(13, 13);
            this.LableUserName.Name = "LableUserName";
            this.LableUserName.Size = new System.Drawing.Size(60, 13);
            this.LableUserName.TabIndex = 4;
            this.LableUserName.Text = "UserName:";
            // 
            // LabelPass
            // 
            this.LabelPass.AutoSize = true;
            this.LabelPass.Location = new System.Drawing.Point(13, 30);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(56, 13);
            this.LabelPass.TabIndex = 5;
            this.LabelPass.Text = "Password:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(79, 30);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(16, 67);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(98, 67);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 117);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.LabelPass);
            this.Controls.Add(this.LableUserName);
            this.Controls.Add(this.textBoxUserName);
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label LableUserName;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}

