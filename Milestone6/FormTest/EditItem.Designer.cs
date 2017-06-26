namespace InventoryManager
{
    partial class EditItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItem));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_NewQuantity = new System.Windows.Forms.TextBox();
            this.textBox_NewPrice = new System.Windows.Forms.TextBox();
            this.textBox_NewName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EditItemSave = new System.Windows.Forms.Button();
            this.EditItemReset = new System.Windows.Forms.Button();
            this.EditItemClose = new System.Windows.Forms.Button();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_NewQuantity);
            this.groupBox1.Controls.Add(this.textBox_NewPrice);
            this.groupBox1.Controls.Add(this.textBox_NewName);
            this.groupBox1.Location = new System.Drawing.Point(265, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(165, 274);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Values";
            // 
            // textBox_NewQuantity
            // 
            this.textBox_NewQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NewQuantity.Location = new System.Drawing.Point(13, 199);
            this.textBox_NewQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_NewQuantity.Name = "textBox_NewQuantity";
            this.textBox_NewQuantity.Size = new System.Drawing.Size(139, 22);
            this.textBox_NewQuantity.TabIndex = 7;
            // 
            // textBox_NewPrice
            // 
            this.textBox_NewPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NewPrice.Location = new System.Drawing.Point(13, 121);
            this.textBox_NewPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_NewPrice.Name = "textBox_NewPrice";
            this.textBox_NewPrice.Size = new System.Drawing.Size(139, 22);
            this.textBox_NewPrice.TabIndex = 6;
            // 
            // textBox_NewName
            // 
            this.textBox_NewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NewName.Location = new System.Drawing.Point(13, 41);
            this.textBox_NewName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_NewName.Name = "textBox_NewName";
            this.textBox_NewName.Size = new System.Drawing.Size(139, 22);
            this.textBox_NewName.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(165, 274);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Values";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(13, 199);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(139, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(12, 121);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(139, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(139, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EditItemSave
            // 
            this.EditItemSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditItemSave.Location = new System.Drawing.Point(195, 377);
            this.EditItemSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditItemSave.Name = "EditItemSave";
            this.EditItemSave.Size = new System.Drawing.Size(75, 23);
            this.EditItemSave.TabIndex = 5;
            this.EditItemSave.Text = "Save";
            this.EditItemSave.UseVisualStyleBackColor = false;
            this.EditItemSave.Click += new System.EventHandler(this.EditItemSave_Click);
            // 
            // EditItemReset
            // 
            this.EditItemReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditItemReset.Location = new System.Drawing.Point(275, 377);
            this.EditItemReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditItemReset.Name = "EditItemReset";
            this.EditItemReset.Size = new System.Drawing.Size(75, 23);
            this.EditItemReset.TabIndex = 6;
            this.EditItemReset.Text = "Reset";
            this.EditItemReset.UseVisualStyleBackColor = false;
            this.EditItemReset.Click += new System.EventHandler(this.EditItemReset_Click);
            // 
            // EditItemClose
            // 
            this.EditItemClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditItemClose.Location = new System.Drawing.Point(356, 377);
            this.EditItemClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditItemClose.Name = "EditItemClose";
            this.EditItemClose.Size = new System.Drawing.Size(75, 23);
            this.EditItemClose.TabIndex = 7;
            this.EditItemClose.Text = "Close";
            this.EditItemClose.UseVisualStyleBackColor = false;
            this.EditItemClose.Click += new System.EventHandler(this.EditItemClose_Click);
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ID.Location = new System.Drawing.Point(66, 22);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(33, 22);
            this.textBox_ID.TabIndex = 9;
            this.textBox_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_ID.Visible = false;
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(443, 428);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.EditItemClose);
            this.Controls.Add(this.EditItemReset);
            this.Controls.Add(this.EditItemSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditItem";
            this.Text = "Edit Item Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_NewQuantity;
        private System.Windows.Forms.TextBox textBox_NewPrice;
        private System.Windows.Forms.TextBox textBox_NewName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EditItemSave;
        private System.Windows.Forms.Button EditItemReset;
        private System.Windows.Forms.Button EditItemClose;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox_ID;
    }
}