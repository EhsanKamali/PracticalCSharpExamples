
namespace Example12
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
            this.listBoxInputNumber = new System.Windows.Forms.ListBox();
            this.labelInputNumber = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAddValue = new System.Windows.Forms.Button();
            this.textBoxInputNumber = new System.Windows.Forms.TextBox();
            this.groupBoxFunctions = new System.Windows.Forms.GroupBox();
            this.radioButtonSortList = new System.Windows.Forms.RadioButton();
            this.radioButtonCountOfSortNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonStandardDeviation = new System.Windows.Forms.RadioButton();
            this.radioButtonVariance = new System.Windows.Forms.RadioButton();
            this.radioButtonHarmonicAvg = new System.Windows.Forms.RadioButton();
            this.radioButtonGeometricAvg = new System.Windows.Forms.RadioButton();
            this.radioButtonWeightedAvg = new System.Windows.Forms.RadioButton();
            this.radioButtonArithmeticAvg = new System.Windows.Forms.RadioButton();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxFunctions.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxInputNumber
            // 
            this.listBoxInputNumber.FormattingEnabled = true;
            this.listBoxInputNumber.ItemHeight = 23;
            this.listBoxInputNumber.Location = new System.Drawing.Point(13, 125);
            this.listBoxInputNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxInputNumber.Name = "listBoxInputNumber";
            this.listBoxInputNumber.Size = new System.Drawing.Size(218, 372);
            this.listBoxInputNumber.TabIndex = 0;
            // 
            // labelInputNumber
            // 
            this.labelInputNumber.AutoSize = true;
            this.labelInputNumber.Location = new System.Drawing.Point(13, 9);
            this.labelInputNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInputNumber.Name = "labelInputNumber";
            this.labelInputNumber.Size = new System.Drawing.Size(59, 23);
            this.labelInputNumber.TabIndex = 2;
            this.labelInputNumber.Text = "اعداد وارده:";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(712, 185);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(218, 37);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "شروع مجدد";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAddValue
            // 
            this.buttonAddValue.Location = new System.Drawing.Point(13, 76);
            this.buttonAddValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddValue.Name = "buttonAddValue";
            this.buttonAddValue.Size = new System.Drawing.Size(218, 41);
            this.buttonAddValue.TabIndex = 5;
            this.buttonAddValue.Text = "اضافه کردن";
            this.buttonAddValue.UseVisualStyleBackColor = true;
            this.buttonAddValue.Click += new System.EventHandler(this.buttonAddValue_Click);
            // 
            // textBoxInputNumber
            // 
            this.textBoxInputNumber.Location = new System.Drawing.Point(13, 33);
            this.textBoxInputNumber.Name = "textBoxInputNumber";
            this.textBoxInputNumber.Size = new System.Drawing.Size(218, 31);
            this.textBoxInputNumber.TabIndex = 6;
            // 
            // groupBoxFunctions
            // 
            this.groupBoxFunctions.Controls.Add(this.radioButtonSortList);
            this.groupBoxFunctions.Controls.Add(this.radioButtonCountOfSortNumber);
            this.groupBoxFunctions.Controls.Add(this.radioButtonStandardDeviation);
            this.groupBoxFunctions.Controls.Add(this.radioButtonVariance);
            this.groupBoxFunctions.Controls.Add(this.radioButtonHarmonicAvg);
            this.groupBoxFunctions.Controls.Add(this.radioButtonGeometricAvg);
            this.groupBoxFunctions.Controls.Add(this.radioButtonWeightedAvg);
            this.groupBoxFunctions.Controls.Add(this.radioButtonArithmeticAvg);
            this.groupBoxFunctions.Location = new System.Drawing.Point(463, 37);
            this.groupBoxFunctions.Name = "groupBoxFunctions";
            this.groupBoxFunctions.Size = new System.Drawing.Size(467, 140);
            this.groupBoxFunctions.TabIndex = 7;
            this.groupBoxFunctions.TabStop = false;
            this.groupBoxFunctions.Text = "Functions";
            // 
            // radioButtonSortList
            // 
            this.radioButtonSortList.AutoSize = true;
            this.radioButtonSortList.Location = new System.Drawing.Point(141, 62);
            this.radioButtonSortList.Name = "radioButtonSortList";
            this.radioButtonSortList.Size = new System.Drawing.Size(107, 27);
            this.radioButtonSortList.TabIndex = 17;
            this.radioButtonSortList.TabStop = true;
            this.radioButtonSortList.Text = "لیست مرتب شده";
            this.radioButtonSortList.UseVisualStyleBackColor = true;
            // 
            // radioButtonCountOfSortNumber
            // 
            this.radioButtonCountOfSortNumber.AutoSize = true;
            this.radioButtonCountOfSortNumber.Location = new System.Drawing.Point(144, 30);
            this.radioButtonCountOfSortNumber.Name = "radioButtonCountOfSortNumber";
            this.radioButtonCountOfSortNumber.Size = new System.Drawing.Size(104, 27);
            this.radioButtonCountOfSortNumber.TabIndex = 16;
            this.radioButtonCountOfSortNumber.TabStop = true;
            this.radioButtonCountOfSortNumber.Text = "تکرار اعداد ترتیبی";
            this.radioButtonCountOfSortNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonStandardDeviation
            // 
            this.radioButtonStandardDeviation.AutoSize = true;
            this.radioButtonStandardDeviation.Location = new System.Drawing.Point(266, 95);
            this.radioButtonStandardDeviation.Name = "radioButtonStandardDeviation";
            this.radioButtonStandardDeviation.Size = new System.Drawing.Size(86, 27);
            this.radioButtonStandardDeviation.TabIndex = 15;
            this.radioButtonStandardDeviation.TabStop = true;
            this.radioButtonStandardDeviation.Text = "انحراف معیار";
            this.radioButtonStandardDeviation.UseVisualStyleBackColor = true;
            // 
            // radioButtonVariance
            // 
            this.radioButtonVariance.AutoSize = true;
            this.radioButtonVariance.Location = new System.Drawing.Point(288, 62);
            this.radioButtonVariance.Name = "radioButtonVariance";
            this.radioButtonVariance.Size = new System.Drawing.Size(64, 27);
            this.radioButtonVariance.TabIndex = 14;
            this.radioButtonVariance.TabStop = true;
            this.radioButtonVariance.Text = "واریانس";
            this.radioButtonVariance.UseVisualStyleBackColor = true;
            // 
            // radioButtonHarmonicAvg
            // 
            this.radioButtonHarmonicAvg.AutoSize = true;
            this.radioButtonHarmonicAvg.Location = new System.Drawing.Point(254, 30);
            this.radioButtonHarmonicAvg.Name = "radioButtonHarmonicAvg";
            this.radioButtonHarmonicAvg.Size = new System.Drawing.Size(98, 27);
            this.radioButtonHarmonicAvg.TabIndex = 13;
            this.radioButtonHarmonicAvg.TabStop = true;
            this.radioButtonHarmonicAvg.Text = "میانگین همساز";
            this.radioButtonHarmonicAvg.UseVisualStyleBackColor = true;
            // 
            // radioButtonGeometricAvg
            // 
            this.radioButtonGeometricAvg.AutoSize = true;
            this.radioButtonGeometricAvg.Location = new System.Drawing.Point(361, 95);
            this.radioButtonGeometricAvg.Name = "radioButtonGeometricAvg";
            this.radioButtonGeometricAvg.Size = new System.Drawing.Size(100, 27);
            this.radioButtonGeometricAvg.TabIndex = 12;
            this.radioButtonGeometricAvg.TabStop = true;
            this.radioButtonGeometricAvg.Text = "میانگین هندسی";
            this.radioButtonGeometricAvg.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeightedAvg
            // 
            this.radioButtonWeightedAvg.AutoSize = true;
            this.radioButtonWeightedAvg.Location = new System.Drawing.Point(374, 62);
            this.radioButtonWeightedAvg.Name = "radioButtonWeightedAvg";
            this.radioButtonWeightedAvg.Size = new System.Drawing.Size(87, 27);
            this.radioButtonWeightedAvg.TabIndex = 11;
            this.radioButtonWeightedAvg.TabStop = true;
            this.radioButtonWeightedAvg.Text = "میانگین وزنی";
            this.radioButtonWeightedAvg.UseVisualStyleBackColor = true;
            // 
            // radioButtonArithmeticAvg
            // 
            this.radioButtonArithmeticAvg.AutoSize = true;
            this.radioButtonArithmeticAvg.Location = new System.Drawing.Point(358, 30);
            this.radioButtonArithmeticAvg.Name = "radioButtonArithmeticAvg";
            this.radioButtonArithmeticAvg.Size = new System.Drawing.Size(103, 27);
            this.radioButtonArithmeticAvg.TabIndex = 10;
            this.radioButtonArithmeticAvg.TabStop = true;
            this.radioButtonArithmeticAvg.Text = "میانگسن حسابی";
            this.radioButtonArithmeticAvg.UseVisualStyleBackColor = true;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(463, 185);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(218, 37);
            this.buttonCalc.TabIndex = 8;
            this.buttonCalc.Text = "محاسبه";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.richTextBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(238, 230);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(692, 269);
            this.groupBoxResult.TabIndex = 9;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "نتیجه";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(6, 30);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.ReadOnly = true;
            this.richTextBoxResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBoxResult.Size = new System.Drawing.Size(679, 233);
            this.richTextBoxResult.TabIndex = 13;
            this.richTextBoxResult.Text = "";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(6, 23);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 31);
            this.textBoxCount.TabIndex = 10;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(152, 26);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(63, 23);
            this.labelCount.TabIndex = 11;
            this.labelCount.Text = "تعداد رکورد:";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.textBoxCount);
            this.groupBoxInfo.Controls.Add(this.labelCount);
            this.groupBoxInfo.Location = new System.Drawing.Point(235, 33);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(221, 189);
            this.groupBoxInfo.TabIndex = 12;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "اطلاعات:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 511);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.groupBoxFunctions);
            this.Controls.Add(this.textBoxInputNumber);
            this.Controls.Add(this.buttonAddValue);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelInputNumber);
            this.Controls.Add(this.listBoxInputNumber);
            this.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "محاسبه فرمول های آماری";
            this.groupBoxFunctions.ResumeLayout(false);
            this.groupBoxFunctions.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInputNumber;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAddValue;
        private System.Windows.Forms.TextBox textBoxInputNumber;
        private System.Windows.Forms.GroupBox groupBoxFunctions;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.RadioButton radioButtonStandardDeviation;
        private System.Windows.Forms.RadioButton radioButtonVariance;
        private System.Windows.Forms.RadioButton radioButtonHarmonicAvg;
        private System.Windows.Forms.RadioButton radioButtonGeometricAvg;
        private System.Windows.Forms.RadioButton radioButtonWeightedAvg;
        private System.Windows.Forms.RadioButton radioButtonArithmeticAvg;
        private System.Windows.Forms.RadioButton radioButtonCountOfSortNumber;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        public System.Windows.Forms.ListBox listBoxInputNumber;
        private System.Windows.Forms.RadioButton radioButtonSortList;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
    }
}

