
namespace Example11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.labelSearchText = new System.Windows.Forms.Label();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.textBoxSearchText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.Location = new System.Drawing.Point(16, 11);
            this.labelSearchBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(73, 16);
            this.labelSearchBy.TabIndex = 7;
            this.labelSearchBy.Text = "Search By:";
            // 
            // labelSearchText
            // 
            this.labelSearchText.AutoSize = true;
            this.labelSearchText.Location = new System.Drawing.Point(16, 42);
            this.labelSearchText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchText.Name = "labelSearchText";
            this.labelSearchText.Size = new System.Drawing.Size(85, 16);
            this.labelSearchText.TabIndex = 8;
            this.labelSearchText.Text = "Search Text:";
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Location = new System.Drawing.Point(109, 7);
            this.comboBoxSearchBy.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(191, 24);
            this.comboBoxSearchBy.TabIndex = 0;
            this.comboBoxSearchBy.Text = "Title";
            // 
            // textBoxSearchText
            // 
            this.textBoxSearchText.Location = new System.Drawing.Point(109, 39);
            this.textBoxSearchText.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchText.Name = "textBoxSearchText";
            this.textBoxSearchText.Size = new System.Drawing.Size(191, 22);
            this.textBoxSearchText.TabIndex = 1;
            this.textBoxSearchText.TextChanged += new System.EventHandler(this.textBoxSearchText_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(284, 341);
            this.dataGridView1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.richTextBox1.Location = new System.Drawing.Point(309, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(416, 341);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(16, 415);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(81, 31);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(103, 415);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(81, 31);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(190, 415);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(81, 31);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(309, 8);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 9;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(309, 39);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(416, 22);
            this.textBoxTitle.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 458);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSearchText);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.labelSearchText);
            this.Controls.Add(this.labelSearchBy);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Readme DataBase";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchBy;
        private System.Windows.Forms.Label labelSearchText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.ComboBox comboBoxSearchBy;
        public System.Windows.Forms.TextBox textBoxSearchText;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxTitle;
    }
}

