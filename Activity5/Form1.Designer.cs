namespace Activity5
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textLowerCase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstWordText = new System.Windows.Forms.TextBox();
            this.lastWordText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.longWordText = new System.Windows.Forms.TextBox();
            this.vowelText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select File: ";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(199, 23);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(227, 23);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Click to Select File";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // textLowerCase
            // 
            this.textLowerCase.Location = new System.Drawing.Point(134, 52);
            this.textLowerCase.Multiline = true;
            this.textLowerCase.Name = "textLowerCase";
            this.textLowerCase.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textLowerCase.Size = new System.Drawing.Size(400, 250);
            this.textLowerCase.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(131, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Word Alphabetically: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Word Alphabetically: ";
            // 
            // firstWordText
            // 
            this.firstWordText.Location = new System.Drawing.Point(264, 331);
            this.firstWordText.Name = "firstWordText";
            this.firstWordText.Size = new System.Drawing.Size(270, 20);
            this.firstWordText.TabIndex = 5;
            // 
            // lastWordText
            // 
            this.lastWordText.Location = new System.Drawing.Point(264, 362);
            this.lastWordText.Name = "lastWordText";
            this.lastWordText.Size = new System.Drawing.Size(270, 20);
            this.lastWordText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Longest Word: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Word with Most Vowels: ";
            // 
            // longWordText
            // 
            this.longWordText.Location = new System.Drawing.Point(264, 392);
            this.longWordText.Name = "longWordText";
            this.longWordText.Size = new System.Drawing.Size(270, 20);
            this.longWordText.TabIndex = 9;
            // 
            // vowelText
            // 
            this.vowelText.Location = new System.Drawing.Point(264, 418);
            this.vowelText.Name = "vowelText";
            this.vowelText.Size = new System.Drawing.Size(270, 20);
            this.vowelText.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.vowelText);
            this.Controls.Add(this.longWordText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastWordText);
            this.Controls.Add(this.firstWordText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLowerCase);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CST-150 Activity 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox textLowerCase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstWordText;
        private System.Windows.Forms.TextBox lastWordText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox longWordText;
        private System.Windows.Forms.TextBox vowelText;
    }
}

