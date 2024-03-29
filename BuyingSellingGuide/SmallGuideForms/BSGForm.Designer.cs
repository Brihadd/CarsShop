﻿namespace BuyingSellingGuide.SmallGuideForms
{
    partial class BSGForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buyingGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellingGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyingGuideToolStripMenuItem,
            this.sellingGuideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buyingGuideToolStripMenuItem
            // 
            this.buyingGuideToolStripMenuItem.Name = "buyingGuideToolStripMenuItem";
            this.buyingGuideToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.buyingGuideToolStripMenuItem.Text = "Buying Guide";
            this.buyingGuideToolStripMenuItem.Click += new System.EventHandler(this.buyingGuideToolStripMenuItem_Click);
            // 
            // sellingGuideToolStripMenuItem
            // 
            this.sellingGuideToolStripMenuItem.Name = "sellingGuideToolStripMenuItem";
            this.sellingGuideToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.sellingGuideToolStripMenuItem.Text = "Selling Guide";
            this.sellingGuideToolStripMenuItem.Click += new System.EventHandler(this.sellingGuideToolStripMenuItem_Click);
            // 
            // BSGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BSGForm";
            this.Text = "Buying/Selling guide";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BSGForm_FormClosing);
            this.Load += new System.EventHandler(this.BSGForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buyingGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellingGuideToolStripMenuItem;
    }
}