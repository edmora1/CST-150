namespace Milestone2InventoryClass
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
            this.inventoryList = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.costTxtBx = new System.Windows.Forms.TextBox();
            this.qtyTxtBx = new System.Windows.Forms.TextBox();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryList
            // 
            this.inventoryList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.inventoryList.AutoArrange = false;
            this.inventoryList.HideSelection = false;
            this.inventoryList.LabelWrap = false;
            this.inventoryList.Location = new System.Drawing.Point(28, 34);
            this.inventoryList.Name = "inventoryList";
            this.inventoryList.Size = new System.Drawing.Size(310, 198);
            this.inventoryList.TabIndex = 0;
            this.inventoryList.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addItemBtn);
            this.groupBox1.Controls.Add(this.qtyTxtBx);
            this.groupBox1.Controls.Add(this.costTxtBx);
            this.groupBox1.Controls.Add(this.nameTxtBx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(60, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantitiy";
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(120, 13);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBx.TabIndex = 3;
            // 
            // costTxtBx
            // 
            this.costTxtBx.Location = new System.Drawing.Point(120, 39);
            this.costTxtBx.Name = "costTxtBx";
            this.costTxtBx.Size = new System.Drawing.Size(100, 20);
            this.costTxtBx.TabIndex = 4;
            // 
            // qtyTxtBx
            // 
            this.qtyTxtBx.Location = new System.Drawing.Point(120, 63);
            this.qtyTxtBx.Name = "qtyTxtBx";
            this.qtyTxtBx.Size = new System.Drawing.Size(100, 20);
            this.qtyTxtBx.TabIndex = 5;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(120, 104);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(100, 23);
            this.addItemBtn.TabIndex = 6;
            this.addItemBtn.Text = "Add to Inventory";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(180, 238);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(100, 23);
            this.showBtn.TabIndex = 4;
            this.showBtn.Text = "Show Inventory";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 438);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inventoryList);
            this.Name = "Form1";
            this.Text = "Inventory Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView inventoryList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.TextBox qtyTxtBx;
        private System.Windows.Forms.TextBox costTxtBx;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showBtn;
    }
}

