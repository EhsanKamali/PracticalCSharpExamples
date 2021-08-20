namespace MD5Form
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
            this.labelMainText = new System.Windows.Forms.Label();
            this.textBoxMainText = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelHashText = new System.Windows.Forms.Label();
            this.textBoxHashString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelMainText
            // 
            this.labelMainText.AutoSize = true;
            this.labelMainText.Location = new System.Drawing.Point(23, 24);
            this.labelMainText.Name = "labelMainText";
            this.labelMainText.Size = new System.Drawing.Size(54, 13);
            this.labelMainText.TabIndex = 0;
            this.labelMainText.Text = "Main Text";
            // 
            // textBoxMainText
            // 
            this.textBoxMainText.Location = new System.Drawing.Point(87, 20);
            this.textBoxMainText.Name = "textBoxMainText";
            this.textBoxMainText.Size = new System.Drawing.Size(100, 20);
            this.textBoxMainText.TabIndex = 1;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(240, 18);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelHashText
            // 
            this.labelHashText.AutoSize = true;
            this.labelHashText.Location = new System.Drawing.Point(21, 74);
            this.labelHashText.Name = "labelHashText";
            this.labelHashText.Size = new System.Drawing.Size(56, 13);
            this.labelHashText.TabIndex = 3;
            this.labelHashText.Text = "Hash Text";
            // 
            // textBoxHashString
            // 
            this.textBoxHashString.Location = new System.Drawing.Point(87, 70);
            this.textBoxHashString.Name = "textBoxHashString";
            this.textBoxHashString.Size = new System.Drawing.Size(228, 20);
            this.textBoxHashString.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 129);
            this.Controls.Add(this.textBoxHashString);
            this.Controls.Add(this.labelHashText);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxMainText);
            this.Controls.Add(this.labelMainText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainText;
        private System.Windows.Forms.TextBox textBoxMainText;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelHashText;
        private System.Windows.Forms.TextBox textBoxHashString;
    }
}

