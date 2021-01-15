
namespace Example4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonNegativ = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMultipilication = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBackSpace = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonOnOff = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button21);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.button23);
            this.panel1.Controls.Add(this.button24);
            this.panel1.Controls.Add(this.button25);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonBackSpace);
            this.panel1.Controls.Add(this.buttonDivide);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.buttonMultipilication);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.buttonNegativ);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonEqual);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.buttonPoint);
            this.panel1.Location = new System.Drawing.Point(3, 140);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 345);
            this.panel1.TabIndex = 0;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(79, 281);
            this.button0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(67, 62);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.NumbersFunction);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(153, 281);
            this.buttonEqual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(67, 62);
            this.buttonEqual.TabIndex = 2;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(228, 281);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(67, 62);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.OperationFunction);
            // 
            // buttonNegativ
            // 
            this.buttonNegativ.Location = new System.Drawing.Point(228, 210);
            this.buttonNegativ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNegativ.Name = "buttonNegativ";
            this.buttonNegativ.Size = new System.Drawing.Size(67, 62);
            this.buttonNegativ.TabIndex = 7;
            this.buttonNegativ.Text = "-";
            this.buttonNegativ.UseVisualStyleBackColor = true;
            this.buttonNegativ.Click += new System.EventHandler(this.OperationFunction);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 210);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 62);
            this.button3.TabIndex = 6;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumbersFunction);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 210);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 62);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumbersFunction);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumbersFunction);
            // 
            // buttonMultipilication
            // 
            this.buttonMultipilication.Location = new System.Drawing.Point(228, 142);
            this.buttonMultipilication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMultipilication.Name = "buttonMultipilication";
            this.buttonMultipilication.Size = new System.Drawing.Size(67, 62);
            this.buttonMultipilication.TabIndex = 11;
            this.buttonMultipilication.Text = "*";
            this.buttonMultipilication.UseVisualStyleBackColor = true;
            this.buttonMultipilication.Click += new System.EventHandler(this.OperationFunction);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(153, 142);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 62);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumbersFunction);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(79, 142);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 62);
            this.button5.TabIndex = 9;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumbersFunction);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 142);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 62);
            this.button4.TabIndex = 8;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumbersFunction);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(228, 73);
            this.buttonDivide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(67, 62);
            this.buttonDivide.TabIndex = 15;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.OperationFunction);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(153, 73);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 62);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumbersFunction);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(79, 73);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 62);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumbersFunction);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(4, 73);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 62);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumbersFunction);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(153, 4);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(141, 62);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "&Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBackSpace
            // 
            this.buttonBackSpace.Location = new System.Drawing.Point(4, 4);
            this.buttonBackSpace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBackSpace.Name = "buttonBackSpace";
            this.buttonBackSpace.Size = new System.Drawing.Size(141, 62);
            this.buttonBackSpace.TabIndex = 16;
            this.buttonBackSpace.Text = "<====";
            this.buttonBackSpace.UseVisualStyleBackColor = true;
            this.buttonBackSpace.Click += new System.EventHandler(this.buttonBackSpace_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(303, 4);
            this.button21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(67, 62);
            this.button21.TabIndex = 24;
            this.button21.Text = "0";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(303, 73);
            this.button22.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(67, 62);
            this.button22.TabIndex = 23;
            this.button22.Text = "0";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(303, 142);
            this.button23.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(67, 62);
            this.button23.TabIndex = 22;
            this.button23.Text = "0";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(303, 210);
            this.button24.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(67, 62);
            this.button24.TabIndex = 21;
            this.button24.Text = "0";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(303, 281);
            this.button25.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(67, 62);
            this.button25.TabIndex = 20;
            this.button25.Text = "0";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(4, 281);
            this.buttonPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(67, 62);
            this.buttonPoint.TabIndex = 0;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.NumbersFunction);
            // 
            // buttonOnOff
            // 
            this.buttonOnOff.Location = new System.Drawing.Point(7, 74);
            this.buttonOnOff.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOnOff.Name = "buttonOnOff";
            this.buttonOnOff.Size = new System.Drawing.Size(141, 62);
            this.buttonOnOff.TabIndex = 25;
            this.buttonOnOff.Text = "ON";
            this.buttonOnOff.UseVisualStyleBackColor = true;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxInput.Location = new System.Drawing.Point(8, 3);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ReadOnly = true;
            this.textBoxInput.Size = new System.Drawing.Size(366, 64);
            this.textBoxInput.TabIndex = 26;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 487);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonOnOff);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "My Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBackSpace;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonMultipilication;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonNegativ;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonOnOff;
        private System.Windows.Forms.TextBox textBoxInput;
    }
}

