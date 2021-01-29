
namespace Example3
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
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonTree = new System.Windows.Forms.Button();
            this.labelControl = new System.Windows.Forms.Label();
            this.buttonForeach = new System.Windows.Forms.Button();
            this.buttonControlsName = new System.Windows.Forms.Button();
            this.buttonFor = new System.Windows.Forms.Button();
            this.buttonSizeChang = new System.Windows.Forms.Button();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.buttonRunTimeEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(21, 21);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(75, 23);
            this.buttonOne.TabIndex = 0;
            this.buttonOne.Text = "One";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.HelloFunction);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Location = new System.Drawing.Point(122, 21);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(75, 23);
            this.buttonTwo.TabIndex = 1;
            this.buttonTwo.Text = "Two";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.HelloFunction);
            // 
            // buttonFour
            // 
            this.buttonFour.Location = new System.Drawing.Point(122, 63);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(75, 23);
            this.buttonFour.TabIndex = 3;
            this.buttonFour.Text = "Four";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.HelloFunction);
            // 
            // buttonTree
            // 
            this.buttonTree.Location = new System.Drawing.Point(21, 63);
            this.buttonTree.Name = "buttonTree";
            this.buttonTree.Size = new System.Drawing.Size(75, 23);
            this.buttonTree.TabIndex = 2;
            this.buttonTree.Text = "Tree";
            this.buttonTree.UseVisualStyleBackColor = true;
            this.buttonTree.Click += new System.EventHandler(this.HelloFunction);
            // 
            // labelControl
            // 
            this.labelControl.Location = new System.Drawing.Point(81, 99);
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(60, 13);
            this.labelControl.TabIndex = 4;
            this.labelControl.Text = "Click Here";
            this.labelControl.Click += new System.EventHandler(this.HelloFunction);
            // 
            // buttonForeach
            // 
            this.buttonForeach.Location = new System.Drawing.Point(21, 167);
            this.buttonForeach.Name = "buttonForeach";
            this.buttonForeach.Size = new System.Drawing.Size(176, 34);
            this.buttonForeach.TabIndex = 5;
            this.buttonForeach.Text = "Foreach Sample";
            this.buttonForeach.UseVisualStyleBackColor = true;
            this.buttonForeach.Click += new System.EventHandler(this.buttonForeach_Click);
            // 
            // buttonControlsName
            // 
            this.buttonControlsName.Location = new System.Drawing.Point(21, 210);
            this.buttonControlsName.Name = "buttonControlsName";
            this.buttonControlsName.Size = new System.Drawing.Size(176, 34);
            this.buttonControlsName.TabIndex = 6;
            this.buttonControlsName.Text = "Controls Name";
            this.buttonControlsName.UseVisualStyleBackColor = true;
            this.buttonControlsName.Click += new System.EventHandler(this.buttonControlsName_Click);
            // 
            // buttonFor
            // 
            this.buttonFor.Location = new System.Drawing.Point(21, 123);
            this.buttonFor.Name = "buttonFor";
            this.buttonFor.Size = new System.Drawing.Size(176, 34);
            this.buttonFor.TabIndex = 7;
            this.buttonFor.Text = "For Sample";
            this.buttonFor.UseVisualStyleBackColor = true;
            this.buttonFor.Click += new System.EventHandler(this.buttonFor_Click);
            // 
            // buttonSizeChang
            // 
            this.buttonSizeChang.Location = new System.Drawing.Point(212, 123);
            this.buttonSizeChang.Name = "buttonSizeChang";
            this.buttonSizeChang.Size = new System.Drawing.Size(176, 34);
            this.buttonSizeChang.TabIndex = 8;
            this.buttonSizeChang.Text = "Size Change 2 pix";
            this.buttonSizeChang.UseVisualStyleBackColor = true;
            this.buttonSizeChang.Click += new System.EventHandler(this.buttonSizeChang_Click);
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Location = new System.Drawing.Point(212, 163);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(176, 34);
            this.buttonAddEvent.TabIndex = 9;
            this.buttonAddEvent.Text = "Add msg event to Control Event";
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // buttonRunTimeEvent
            // 
            this.buttonRunTimeEvent.Location = new System.Drawing.Point(212, 210);
            this.buttonRunTimeEvent.Name = "buttonRunTimeEvent";
            this.buttonRunTimeEvent.Size = new System.Drawing.Size(176, 34);
            this.buttonRunTimeEvent.TabIndex = 10;
            this.buttonRunTimeEvent.Text = "Create RunTime Event";
            this.buttonRunTimeEvent.UseVisualStyleBackColor = true;
            this.buttonRunTimeEvent.Click += new System.EventHandler(this.buttonRunTimeEvent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 298);
            this.Controls.Add(this.buttonRunTimeEvent);
            this.Controls.Add(this.buttonAddEvent);
            this.Controls.Add(this.buttonSizeChang);
            this.Controls.Add(this.buttonFor);
            this.Controls.Add(this.buttonControlsName);
            this.Controls.Add(this.buttonForeach);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonTree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonTree;
        private System.Windows.Forms.Label labelControl;
        private System.Windows.Forms.Button buttonForeach;
        private System.Windows.Forms.Button buttonControlsName;
        private System.Windows.Forms.Button buttonFor;
        private System.Windows.Forms.Button buttonSizeChang;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.Button buttonRunTimeEvent;
    }
}

