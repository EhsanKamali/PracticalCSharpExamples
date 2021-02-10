
namespace Example7
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
            this.labelEnglishWords = new System.Windows.Forms.Label();
            this.textBoxEnglishWords = new System.Windows.Forms.TextBox();
            this.labelTranslate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxTranslate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEnglishWords
            // 
            this.labelEnglishWords.AutoSize = true;
            this.labelEnglishWords.Location = new System.Drawing.Point(12, 9);
            this.labelEnglishWords.Name = "labelEnglishWords";
            this.labelEnglishWords.Size = new System.Drawing.Size(78, 13);
            this.labelEnglishWords.TabIndex = 0;
            this.labelEnglishWords.Text = "English Words:";
            // 
            // textBoxEnglishWords
            // 
            this.textBoxEnglishWords.Location = new System.Drawing.Point(96, 9);
            this.textBoxEnglishWords.Name = "textBoxEnglishWords";
            this.textBoxEnglishWords.Size = new System.Drawing.Size(187, 20);
            this.textBoxEnglishWords.TabIndex = 1;
            this.textBoxEnglishWords.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxEnglishWords_KeyUp);
            // 
            // labelTranslate
            // 
            this.labelTranslate.AutoSize = true;
            this.labelTranslate.Location = new System.Drawing.Point(436, 9);
            this.labelTranslate.Name = "labelTranslate";
            this.labelTranslate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTranslate.Size = new System.Drawing.Size(36, 13);
            this.labelTranslate.TabIndex = 2;
            this.labelTranslate.Text = "ترجمه:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(271, 366);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxTranslate
            // 
            this.textBoxTranslate.Location = new System.Drawing.Point(289, 35);
            this.textBoxTranslate.Multiline = true;
            this.textBoxTranslate.Name = "textBoxTranslate";
            this.textBoxTranslate.Size = new System.Drawing.Size(180, 366);
            this.textBoxTranslate.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 413);
            this.Controls.Add(this.textBoxTranslate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTranslate);
            this.Controls.Add(this.textBoxEnglishWords);
            this.Controls.Add(this.labelEnglishWords);
            this.Name = "FormMain";
            this.Text = "My Dic";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnglishWords;
        private System.Windows.Forms.TextBox textBoxEnglishWords;
        private System.Windows.Forms.Label labelTranslate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxTranslate;
    }
}

