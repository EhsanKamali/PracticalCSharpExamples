
namespace Example8
{
    partial class FormDataControl
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
            this.labelEnglishWord = new System.Windows.Forms.Label();
            this.labelTranslate = new System.Windows.Forms.Label();
            this.textBoxEnglishWord = new System.Windows.Forms.TextBox();
            this.textBoxTranslate = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEnglishWord
            // 
            this.labelEnglishWord.AutoSize = true;
            this.labelEnglishWord.Location = new System.Drawing.Point(16, 11);
            this.labelEnglishWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnglishWord.Name = "labelEnglishWord";
            this.labelEnglishWord.Size = new System.Drawing.Size(94, 16);
            this.labelEnglishWord.TabIndex = 0;
            this.labelEnglishWord.Text = "English Word:";
            // 
            // labelTranslate
            // 
            this.labelTranslate.AutoSize = true;
            this.labelTranslate.Location = new System.Drawing.Point(16, 51);
            this.labelTranslate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTranslate.Name = "labelTranslate";
            this.labelTranslate.Size = new System.Drawing.Size(70, 16);
            this.labelTranslate.TabIndex = 1;
            this.labelTranslate.Text = "Translate:";
            // 
            // textBoxEnglishWord
            // 
            this.textBoxEnglishWord.Location = new System.Drawing.Point(121, 7);
            this.textBoxEnglishWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEnglishWord.Name = "textBoxEnglishWord";
            this.textBoxEnglishWord.Size = new System.Drawing.Size(472, 22);
            this.textBoxEnglishWord.TabIndex = 2;
            // 
            // textBoxTranslate
            // 
            this.textBoxTranslate.Location = new System.Drawing.Point(121, 42);
            this.textBoxTranslate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTranslate.Name = "textBoxTranslate";
            this.textBoxTranslate.Size = new System.Drawing.Size(472, 22);
            this.textBoxTranslate.TabIndex = 3;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(121, 71);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 28);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(207, 71);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 106);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.textBoxTranslate);
            this.Controls.Add(this.textBoxEnglishWord);
            this.Controls.Add(this.labelTranslate);
            this.Controls.Add(this.labelEnglishWord);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDataControl";
            this.Text = "FormDataControl";
            this.Load += new System.EventHandler(this.FormDataControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnglishWord;
        private System.Windows.Forms.Label labelTranslate;
        private System.Windows.Forms.TextBox textBoxEnglishWord;
        private System.Windows.Forms.TextBox textBoxTranslate;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
    }
}