namespace InventoryManager
{
    partial class Alerts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alerts));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AlertsOrderItem = new System.Windows.Forms.Button();
            this.CloseAlerts = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Low Inventory";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(512, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // AlertsOrderItem
            // 
            this.AlertsOrderItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AlertsOrderItem.Location = new System.Drawing.Point(223, 318);
            this.AlertsOrderItem.Name = "AlertsOrderItem";
            this.AlertsOrderItem.Size = new System.Drawing.Size(102, 33);
            this.AlertsOrderItem.TabIndex = 1;
            this.AlertsOrderItem.Text = "Order Item";
            this.AlertsOrderItem.UseVisualStyleBackColor = false;
            this.AlertsOrderItem.Click += new System.EventHandler(this.AlertsOrderItem_Click);
            // 
            // CloseAlerts
            // 
            this.CloseAlerts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseAlerts.Location = new System.Drawing.Point(434, 318);
            this.CloseAlerts.Name = "CloseAlerts";
            this.CloseAlerts.Size = new System.Drawing.Size(102, 33);
            this.CloseAlerts.TabIndex = 2;
            this.CloseAlerts.Text = "Close";
            this.CloseAlerts.UseVisualStyleBackColor = false;
            this.CloseAlerts.Click += new System.EventHandler(this.CloseAlerts_Click);
            // 
            // Alerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 363);
            this.Controls.Add(this.CloseAlerts);
            this.Controls.Add(this.AlertsOrderItem);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Alerts";
            this.Text = "Alerts";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AlertsOrderItem;
        private System.Windows.Forms.Button CloseAlerts;
    }
}