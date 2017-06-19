namespace InventoryManager
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearSearch = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeleteItem = new System.Windows.Forms.Button();
            this.UpdateQuantity = new System.Windows.Forms.Button();
            this.CreateNewItem = new System.Windows.Forms.Button();
            this.EditItemDetails = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CheckAlerts = new System.Windows.Forms.Button();
            this.CloseProgram = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(535, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(523, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearSearch);
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Controls.Add(this.textBox_Search);
            this.groupBox2.Location = new System.Drawing.Point(551, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(229, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // ClearSearch
            // 
            this.ClearSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearSearch.Location = new System.Drawing.Point(152, 49);
            this.ClearSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearSearch.Name = "ClearSearch";
            this.ClearSearch.Size = new System.Drawing.Size(71, 32);
            this.ClearSearch.TabIndex = 2;
            this.ClearSearch.Text = "Clear";
            this.ClearSearch.UseVisualStyleBackColor = false;
            this.ClearSearch.Click += new System.EventHandler(this.ClearSearch_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search.Location = new System.Drawing.Point(75, 49);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(71, 32);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Search.Location = new System.Drawing.Point(5, 21);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Search.Size = new System.Drawing.Size(218, 22);
            this.textBox_Search.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DeleteItem);
            this.groupBox3.Controls.Add(this.UpdateQuantity);
            this.groupBox3.Controls.Add(this.CreateNewItem);
            this.groupBox3.Controls.Add(this.EditItemDetails);
            this.groupBox3.Location = new System.Drawing.Point(551, 114);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(229, 179);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items";
            // 
            // DeleteItem
            // 
            this.DeleteItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteItem.Location = new System.Drawing.Point(5, 133);
            this.DeleteItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(217, 32);
            this.DeleteItem.TabIndex = 6;
            this.DeleteItem.Text = "Delete Item";
            this.DeleteItem.UseVisualStyleBackColor = false;
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // UpdateQuantity
            // 
            this.UpdateQuantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateQuantity.Location = new System.Drawing.Point(5, 97);
            this.UpdateQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateQuantity.Name = "UpdateQuantity";
            this.UpdateQuantity.Size = new System.Drawing.Size(217, 32);
            this.UpdateQuantity.TabIndex = 5;
            this.UpdateQuantity.Text = "Update Quantity";
            this.UpdateQuantity.UseVisualStyleBackColor = false;
            this.UpdateQuantity.Click += new System.EventHandler(this.UpdateQuantity_Click);
            // 
            // CreateNewItem
            // 
            this.CreateNewItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateNewItem.Location = new System.Drawing.Point(5, 21);
            this.CreateNewItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateNewItem.Name = "CreateNewItem";
            this.CreateNewItem.Size = new System.Drawing.Size(217, 32);
            this.CreateNewItem.TabIndex = 4;
            this.CreateNewItem.Text = "Create New Item";
            this.CreateNewItem.UseVisualStyleBackColor = false;
            this.CreateNewItem.Click += new System.EventHandler(this.CreateNewItem_Click);
            // 
            // EditItemDetails
            // 
            this.EditItemDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditItemDetails.Location = new System.Drawing.Point(5, 59);
            this.EditItemDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditItemDetails.Name = "EditItemDetails";
            this.EditItemDetails.Size = new System.Drawing.Size(217, 32);
            this.EditItemDetails.TabIndex = 3;
            this.EditItemDetails.Text = "Edit Item Details";
            this.EditItemDetails.UseVisualStyleBackColor = false;
            this.EditItemDetails.Click += new System.EventHandler(this.EditItemDetails_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CheckAlerts);
            this.groupBox4.Location = new System.Drawing.Point(551, 297);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(229, 63);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alerts";
            // 
            // CheckAlerts
            // 
            this.CheckAlerts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckAlerts.Location = new System.Drawing.Point(5, 21);
            this.CheckAlerts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckAlerts.Name = "CheckAlerts";
            this.CheckAlerts.Size = new System.Drawing.Size(217, 32);
            this.CheckAlerts.TabIndex = 6;
            this.CheckAlerts.Text = "Check Alerts";
            this.CheckAlerts.UseVisualStyleBackColor = false;
            this.CheckAlerts.Click += new System.EventHandler(this.CheckAlerts_Click);
            // 
            // CloseProgram
            // 
            this.CloseProgram.Location = new System.Drawing.Point(703, 430);
            this.CloseProgram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseProgram.Name = "CloseProgram";
            this.CloseProgram.Size = new System.Drawing.Size(71, 32);
            this.CloseProgram.TabIndex = 3;
            this.CloseProgram.Text = "Exit";
            this.CloseProgram.UseVisualStyleBackColor = true;
            this.CloseProgram.Click += new System.EventHandler(this.CloseProgram_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(789, 473);
            this.Controls.Add(this.CloseProgram);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.Text = "Grand Canyon Hardware";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button ClearSearch;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CreateNewItem;
        private System.Windows.Forms.Button EditItemDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdateQuantity;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button CheckAlerts;
        private System.Windows.Forms.Button CloseProgram;
        private System.Windows.Forms.Button DeleteItem;
    }
}