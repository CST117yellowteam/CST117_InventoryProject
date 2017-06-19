namespace InventoryManager
{
    partial class CreateItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateItem));
            this.textBox_ItemNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateItemClose = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ItemNum
            // 
            this.textBox_ItemNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ItemNum.Location = new System.Drawing.Point(82, 29);
            this.textBox_ItemNum.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ItemNum.Name = "textBox_ItemNum";
            this.textBox_ItemNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_ItemNum.Size = new System.Drawing.Size(133, 22);
            this.textBox_ItemNum.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Item #";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(13, 278);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Quantity.Location = new System.Drawing.Point(82, 158);
            this.textBox_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Quantity.Size = new System.Drawing.Size(133, 22);
            this.textBox_Quantity.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantity";
            // 
            // textBox_Price
            // 
            this.textBox_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Price.Location = new System.Drawing.Point(82, 115);
            this.textBox_Price.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Price.Size = new System.Drawing.Size(133, 22);
            this.textBox_Price.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price";
            // 
            // textBox_Name
            // 
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Name.Location = new System.Drawing.Point(82, 72);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Name.Size = new System.Drawing.Size(133, 22);
            this.textBox_Name.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // CreateItemClose
            // 
            this.CreateItemClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateItemClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CreateItemClose.Location = new System.Drawing.Point(229, 278);
            this.CreateItemClose.Margin = new System.Windows.Forms.Padding(4);
            this.CreateItemClose.Name = "CreateItemClose";
            this.CreateItemClose.Size = new System.Drawing.Size(100, 28);
            this.CreateItemClose.TabIndex = 18;
            this.CreateItemClose.Text = "Close";
            this.CreateItemClose.UseVisualStyleBackColor = false;
            this.CreateItemClose.Click += new System.EventHandler(this.CreateItemClose_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Clear.Location = new System.Drawing.Point(121, 278);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(100, 28);
            this.button_Clear.TabIndex = 19;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_ItemNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Quantity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Price);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 201);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // CreateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(342, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.CreateItemClose);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateItem";
            this.Text = "Create New Item";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ItemNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateItemClose;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}