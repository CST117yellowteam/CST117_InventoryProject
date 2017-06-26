namespace InventoryManager
{
    partial class DeleteConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteConfirm));
            this.YesDelete = new System.Windows.Forms.Button();
            this.NoDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YesDelete
            // 
            this.YesDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YesDelete.Location = new System.Drawing.Point(62, 69);
            this.YesDelete.Name = "YesDelete";
            this.YesDelete.Size = new System.Drawing.Size(75, 23);
            this.YesDelete.TabIndex = 0;
            this.YesDelete.Text = "Yes";
            this.YesDelete.UseVisualStyleBackColor = false;
            this.YesDelete.Click += new System.EventHandler(this.YesDelete_Click);
            // 
            // NoDelete
            // 
            this.NoDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoDelete.Location = new System.Drawing.Point(143, 69);
            this.NoDelete.Name = "NoDelete";
            this.NoDelete.Size = new System.Drawing.Size(75, 23);
            this.NoDelete.TabIndex = 1;
            this.NoDelete.Text = "No";
            this.NoDelete.UseVisualStyleBackColor = false;
            this.NoDelete.Click += new System.EventHandler(this.NoDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you sure you want to permanently \r\ndelete this item?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(10, 78);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(46, 17);
            this.label_ID.TabIndex = 3;
            this.label_ID.Text = "label2";
            this.label_ID.Visible = false;
            // 
            // DeleteConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(273, 104);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoDelete);
            this.Controls.Add(this.YesDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteConfirm";
            this.Text = "Delete Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YesDelete;
        private System.Windows.Forms.Button NoDelete;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label_ID;
    }
}