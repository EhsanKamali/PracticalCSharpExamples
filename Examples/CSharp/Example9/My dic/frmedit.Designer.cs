namespace My_dic
{
    partial class frmedit
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
            this.btnclose = new System.Windows.Forms.Button();
            this.Btnapply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtenglish = new System.Windows.Forms.TextBox();
            this.txtfarsi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(54, 125);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Btnapply
            // 
            this.Btnapply.Location = new System.Drawing.Point(171, 125);
            this.Btnapply.Name = "Btnapply";
            this.Btnapply.Size = new System.Drawing.Size(75, 23);
            this.Btnapply.TabIndex = 1;
            this.Btnapply.Text = "Apply";
            this.Btnapply.UseVisualStyleBackColor = true;
            this.Btnapply.Click += new System.EventHandler(this.Btnapply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Farsi Word:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "English Word:";
            // 
            // txtenglish
            // 
            this.txtenglish.Enabled = false;
            this.txtenglish.Location = new System.Drawing.Point(101, 16);
            this.txtenglish.Name = "txtenglish";
            this.txtenglish.Size = new System.Drawing.Size(142, 20);
            this.txtenglish.TabIndex = 4;
            // 
            // txtfarsi
            // 
            this.txtfarsi.Location = new System.Drawing.Point(101, 45);
            this.txtfarsi.Multiline = true;
            this.txtfarsi.Name = "txtfarsi";
            this.txtfarsi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtfarsi.Size = new System.Drawing.Size(142, 62);
            this.txtfarsi.TabIndex = 5;
            // 
            // frmedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 160);
            this.Controls.Add(this.txtfarsi);
            this.Controls.Add(this.txtenglish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnapply);
            this.Controls.Add(this.btnclose);
            this.Name = "frmedit";
            this.Text = "frmedit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button Btnapply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtenglish;
        private System.Windows.Forms.TextBox txtfarsi;
    }
}