namespace TicTacToe
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
            this.newGameBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.topRightLabel = new System.Windows.Forms.Label();
            this.topMidLabel = new System.Windows.Forms.Label();
            this.topLeftLabel = new System.Windows.Forms.Label();
            this.midLeftLabel = new System.Windows.Forms.Label();
            this.centerLabel = new System.Windows.Forms.Label();
            this.midRightLabel = new System.Windows.Forms.Label();
            this.bottomLeftLabel = new System.Windows.Forms.Label();
            this.bottomMidLabel = new System.Windows.Forms.Label();
            this.bottomRightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newGameBtn
            // 
            this.newGameBtn.Location = new System.Drawing.Point(75, 334);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(75, 23);
            this.newGameBtn.TabIndex = 9;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(178, 334);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // topRightLabel
            // 
            this.topRightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topRightLabel.Location = new System.Drawing.Point(216, 29);
            this.topRightLabel.Name = "topRightLabel";
            this.topRightLabel.Size = new System.Drawing.Size(83, 71);
            this.topRightLabel.TabIndex = 14;
            this.topRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topMidLabel
            // 
            this.topMidLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topMidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topMidLabel.Location = new System.Drawing.Point(117, 29);
            this.topMidLabel.Name = "topMidLabel";
            this.topMidLabel.Size = new System.Drawing.Size(83, 71);
            this.topMidLabel.TabIndex = 15;
            this.topMidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topLeftLabel
            // 
            this.topLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLeftLabel.Location = new System.Drawing.Point(12, 29);
            this.topLeftLabel.Name = "topLeftLabel";
            this.topLeftLabel.Size = new System.Drawing.Size(83, 71);
            this.topLeftLabel.TabIndex = 16;
            this.topLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // midLeftLabel
            // 
            this.midLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.midLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midLeftLabel.Location = new System.Drawing.Point(12, 115);
            this.midLeftLabel.Name = "midLeftLabel";
            this.midLeftLabel.Size = new System.Drawing.Size(83, 71);
            this.midLeftLabel.TabIndex = 17;
            this.midLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // centerLabel
            // 
            this.centerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.centerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerLabel.Location = new System.Drawing.Point(117, 115);
            this.centerLabel.Name = "centerLabel";
            this.centerLabel.Size = new System.Drawing.Size(83, 71);
            this.centerLabel.TabIndex = 18;
            this.centerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // midRightLabel
            // 
            this.midRightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.midRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midRightLabel.Location = new System.Drawing.Point(216, 115);
            this.midRightLabel.Name = "midRightLabel";
            this.midRightLabel.Size = new System.Drawing.Size(83, 71);
            this.midRightLabel.TabIndex = 19;
            this.midRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomLeftLabel
            // 
            this.bottomLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLeftLabel.Location = new System.Drawing.Point(12, 200);
            this.bottomLeftLabel.Name = "bottomLeftLabel";
            this.bottomLeftLabel.Size = new System.Drawing.Size(83, 71);
            this.bottomLeftLabel.TabIndex = 20;
            this.bottomLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomMidLabel
            // 
            this.bottomMidLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomMidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomMidLabel.Location = new System.Drawing.Point(117, 200);
            this.bottomMidLabel.Name = "bottomMidLabel";
            this.bottomMidLabel.Size = new System.Drawing.Size(83, 71);
            this.bottomMidLabel.TabIndex = 21;
            this.bottomMidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomRightLabel
            // 
            this.bottomRightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomRightLabel.Location = new System.Drawing.Point(216, 200);
            this.bottomRightLabel.Name = "bottomRightLabel";
            this.bottomRightLabel.Size = new System.Drawing.Size(83, 71);
            this.bottomRightLabel.TabIndex = 22;
            this.bottomRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 388);
            this.Controls.Add(this.bottomRightLabel);
            this.Controls.Add(this.bottomMidLabel);
            this.Controls.Add(this.bottomLeftLabel);
            this.Controls.Add(this.midRightLabel);
            this.Controls.Add(this.centerLabel);
            this.Controls.Add(this.midLeftLabel);
            this.Controls.Add(this.topLeftLabel);
            this.Controls.Add(this.topMidLabel);
            this.Controls.Add(this.topRightLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.newGameBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label topRightLabel;
        private System.Windows.Forms.Label topMidLabel;
        private System.Windows.Forms.Label topLeftLabel;
        private System.Windows.Forms.Label midLeftLabel;
        private System.Windows.Forms.Label centerLabel;
        private System.Windows.Forms.Label midRightLabel;
        private System.Windows.Forms.Label bottomLeftLabel;
        private System.Windows.Forms.Label bottomMidLabel;
        private System.Windows.Forms.Label bottomRightLabel;
    }
}

