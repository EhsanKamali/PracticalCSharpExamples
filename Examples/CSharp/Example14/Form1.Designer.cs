
namespace Example14
{
    partial class Form1
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
            this.labelTool = new System.Windows.Forms.Label();
            this.labelArz = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.maskedTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.textBoxTool = new System.Windows.Forms.TextBox();
            this.textBoxArz = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelMohit = new System.Windows.Forms.Label();
            this.labelMasahat = new System.Windows.Forms.Label();
            this.linkLabelMostatil = new System.Windows.Forms.LinkLabel();
            this.linkLabelMasahat = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelTool
            // 
            this.labelTool.AutoSize = true;
            this.labelTool.Location = new System.Drawing.Point(25, 61);
            this.labelTool.Name = "labelTool";
            this.labelTool.Size = new System.Drawing.Size(30, 13);
            this.labelTool.TabIndex = 0;
            this.labelTool.Text = "طول:";
            // 
            // labelArz
            // 
            this.labelArz.AutoSize = true;
            this.labelArz.Location = new System.Drawing.Point(22, 97);
            this.labelArz.Name = "labelArz";
            this.labelArz.Size = new System.Drawing.Size(33, 13);
            this.labelArz.TabIndex = 1;
            this.labelArz.Text = "عرض:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(22, 25);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date:";
            // 
            // maskedTextBoxDate
            // 
            this.maskedTextBoxDate.Location = new System.Drawing.Point(71, 21);
            this.maskedTextBoxDate.Mask = "0000/00/00";
            this.maskedTextBoxDate.Name = "maskedTextBoxDate";
            this.maskedTextBoxDate.Size = new System.Drawing.Size(69, 20);
            this.maskedTextBoxDate.TabIndex = 3;
            // 
            // textBoxTool
            // 
            this.textBoxTool.Location = new System.Drawing.Point(71, 57);
            this.textBoxTool.Name = "textBoxTool";
            this.textBoxTool.Size = new System.Drawing.Size(69, 20);
            this.textBoxTool.TabIndex = 4;
            // 
            // textBoxArz
            // 
            this.textBoxArz.Location = new System.Drawing.Point(71, 93);
            this.textBoxArz.Name = "textBoxArz";
            this.textBoxArz.Size = new System.Drawing.Size(69, 20);
            this.textBoxArz.TabIndex = 5;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonCalc.Location = new System.Drawing.Point(25, 129);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(210, 35);
            this.buttonCalc.TabIndex = 6;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelMohit
            // 
            this.labelMohit.AutoSize = true;
            this.labelMohit.Location = new System.Drawing.Point(25, 192);
            this.labelMohit.Name = "labelMohit";
            this.labelMohit.Size = new System.Drawing.Size(0, 13);
            this.labelMohit.TabIndex = 7;
            // 
            // labelMasahat
            // 
            this.labelMasahat.AutoSize = true;
            this.labelMasahat.Location = new System.Drawing.Point(25, 224);
            this.labelMasahat.Name = "labelMasahat";
            this.labelMasahat.Size = new System.Drawing.Size(0, 13);
            this.labelMasahat.TabIndex = 8;
            // 
            // linkLabelMostatil
            // 
            this.linkLabelMostatil.AutoSize = true;
            this.linkLabelMostatil.Location = new System.Drawing.Point(25, 167);
            this.linkLabelMostatil.Name = "linkLabelMostatil";
            this.linkLabelMostatil.Size = new System.Drawing.Size(0, 13);
            this.linkLabelMostatil.TabIndex = 9;
            this.linkLabelMostatil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMostatil_LinkClicked);
            // 
            // linkLabelMasahat
            // 
            this.linkLabelMasahat.AutoEllipsis = true;
            this.linkLabelMasahat.Location = new System.Drawing.Point(25, 254);
            this.linkLabelMasahat.Name = "linkLabelMasahat";
            this.linkLabelMasahat.Size = new System.Drawing.Size(126, 23);
            this.linkLabelMasahat.TabIndex = 10;
            this.linkLabelMasahat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMasahat_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 287);
            this.Controls.Add(this.linkLabelMasahat);
            this.Controls.Add(this.linkLabelMostatil);
            this.Controls.Add(this.labelMasahat);
            this.Controls.Add(this.labelMohit);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxArz);
            this.Controls.Add(this.textBoxTool);
            this.Controls.Add(this.maskedTextBoxDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelArz);
            this.Controls.Add(this.labelTool);
            this.Name = "Form1";
            this.Text = "Rectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTool;
        private System.Windows.Forms.Label labelArz;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDate;
        private System.Windows.Forms.TextBox textBoxTool;
        private System.Windows.Forms.TextBox textBoxArz;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelMohit;
        private System.Windows.Forms.Label labelMasahat;
        private System.Windows.Forms.LinkLabel linkLabelMostatil;
        private System.Windows.Forms.LinkLabel linkLabelMasahat;
    }
}

