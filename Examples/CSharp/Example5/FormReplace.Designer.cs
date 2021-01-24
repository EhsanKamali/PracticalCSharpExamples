
namespace Example5
{
    partial class FormReplace
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
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonReplaceAll = new System.Windows.Forms.Button();
            this.labelReplace = new System.Windows.Forms.Label();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.groupBoxDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(391, 96);
            // 
            // checkBoxMatchCase
            // 
            this.checkBoxMatchCase.Location = new System.Drawing.Point(15, 96);
            // 
            // groupBoxDirection
            // 
            this.groupBoxDirection.Location = new System.Drawing.Point(213, 72);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(391, 38);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonReplace.TabIndex = 6;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // buttonReplaceAll
            // 
            this.buttonReplaceAll.Location = new System.Drawing.Point(391, 67);
            this.buttonReplaceAll.Name = "buttonReplaceAll";
            this.buttonReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.buttonReplaceAll.TabIndex = 7;
            this.buttonReplaceAll.Text = "ReplaceAll";
            this.buttonReplaceAll.UseVisualStyleBackColor = true;
            this.buttonReplaceAll.Click += new System.EventHandler(this.buttonReplaceAll_Click);
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Location = new System.Drawing.Point(12, 48);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(50, 13);
            this.labelReplace.TabIndex = 8;
            this.labelReplace.Text = "Replace:";
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(74, 43);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(297, 20);
            this.textBoxReplace.TabIndex = 9;
            // 
            // FormReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(478, 148);
            this.Controls.Add(this.textBoxReplace);
            this.Controls.Add(this.labelReplace);
            this.Controls.Add(this.buttonReplaceAll);
            this.Controls.Add(this.buttonReplace);
            this.Name = "FormReplace";
            this.Text = "Replace";
            this.Load += new System.EventHandler(this.FormReplace_Load);
            this.Controls.SetChildIndex(this.labelFindWhat, 0);
            this.Controls.SetChildIndex(this.textBoxFindWhat, 0);
            this.Controls.SetChildIndex(this.buttonFindNext, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.checkBoxMatchCase, 0);
            this.Controls.SetChildIndex(this.groupBoxDirection, 0);
            this.Controls.SetChildIndex(this.buttonReplace, 0);
            this.Controls.SetChildIndex(this.buttonReplaceAll, 0);
            this.Controls.SetChildIndex(this.labelReplace, 0);
            this.Controls.SetChildIndex(this.textBoxReplace, 0);
            this.groupBoxDirection.ResumeLayout(false);
            this.groupBoxDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonReplaceAll;
        private System.Windows.Forms.Label labelReplace;
        private System.Windows.Forms.TextBox textBoxReplace;
    }
}
