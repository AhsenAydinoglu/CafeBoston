﻿namespace CafeBoston.UI
{
    partial class MainForm
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
            this.msTop = new System.Windows.Forms.MenuStrip();
            this.tsmiProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrderHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwTables = new System.Windows.Forms.ListView();
            this.msTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // msTop
            // 
            this.msTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProducts,
            this.tsmiOrderHistory});
            this.msTop.Location = new System.Drawing.Point(0, 0);
            this.msTop.Name = "msTop";
            this.msTop.Size = new System.Drawing.Size(1029, 24);
            this.msTop.TabIndex = 0;
            this.msTop.Text = "menuStrip1";
            // 
            // tsmiProducts
            // 
            this.tsmiProducts.Name = "tsmiProducts";
            this.tsmiProducts.Size = new System.Drawing.Size(66, 20);
            this.tsmiProducts.Text = "Products";
            // 
            // tsmiOrderHistory
            // 
            this.tsmiOrderHistory.Name = "tsmiOrderHistory";
            this.tsmiOrderHistory.Size = new System.Drawing.Size(90, 20);
            this.tsmiOrderHistory.Text = "Order History";
            // 
            // lvwTables
            // 
            this.lvwTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTables.Location = new System.Drawing.Point(0, 24);
            this.lvwTables.Name = "lvwTables";
            this.lvwTables.Size = new System.Drawing.Size(1029, 606);
            this.lvwTables.TabIndex = 1;
            this.lvwTables.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.lvwTables);
            this.Controls.Add(this.msTop);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Cafe Boston";
            this.msTop.ResumeLayout(false);
            this.msTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msTop;
        private ToolStripMenuItem tsmiProducts;
        private ToolStripMenuItem tsmiOrderHistory;
        private ListView lvwTables;
    }
}