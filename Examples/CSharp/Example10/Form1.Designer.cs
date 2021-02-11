
namespace Example10
{
    partial class FormMain
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
            this.buttonGo = new System.Windows.Forms.Button();
            this.labelEnterNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.listBoxPrimeNumber = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(217, 8);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 1;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // labelEnterNumber
            // 
            this.labelEnterNumber.AutoSize = true;
            this.labelEnterNumber.Location = new System.Drawing.Point(12, 13);
            this.labelEnterNumber.Name = "labelEnterNumber";
            this.labelEnterNumber.Size = new System.Drawing.Size(75, 13);
            this.labelEnterNumber.TabIndex = 3;
            this.labelEnterNumber.Text = "Enter Number:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(93, 9);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(118, 20);
            this.textBoxNumber.TabIndex = 0;
            // 
            // listBoxPrimeNumber
            // 
            this.listBoxPrimeNumber.FormattingEnabled = true;
            this.listBoxPrimeNumber.Location = new System.Drawing.Point(15, 35);
            this.listBoxPrimeNumber.Name = "listBoxPrimeNumber";
            this.listBoxPrimeNumber.Size = new System.Drawing.Size(277, 303);
            this.listBoxPrimeNumber.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 353);
            this.Controls.Add(this.listBoxPrimeNumber);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelEnterNumber);
            this.Controls.Add(this.buttonGo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.Text = "Prime Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label labelEnterNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.ListBox listBoxPrimeNumber;
    }
}

