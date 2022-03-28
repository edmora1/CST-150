namespace Activity7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.reflectTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter # of terms: ";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(121, 26);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(130, 20);
            this.inputTextBox.TabIndex = 1;
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calcButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.calcButton.FlatAppearance.BorderSize = 2;
            this.calcButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calcButton.Location = new System.Drawing.Point(30, 66);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(85, 39);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "CALCULATE";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // reflectTextBox
            // 
            this.reflectTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reflectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reflectTextBox.Location = new System.Drawing.Point(30, 125);
            this.reflectTextBox.Name = "reflectTextBox";
            this.reflectTextBox.Size = new System.Drawing.Size(203, 13);
            this.reflectTextBox.TabIndex = 3;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.Location = new System.Drawing.Point(30, 160);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(265, 13);
            this.resultTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 199);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.reflectTextBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox reflectTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

