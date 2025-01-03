﻿namespace online_store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.управлениеЗаказамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеКлиентамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеТоварамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеЗаказамиToolStripMenuItem,
            this.управлениеКлиентамиToolStripMenuItem,
            this.управлениеТоварамиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // управлениеЗаказамиToolStripMenuItem
            // 
            this.управлениеЗаказамиToolStripMenuItem.Name = "управлениеЗаказамиToolStripMenuItem";
            this.управлениеЗаказамиToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.управлениеЗаказамиToolStripMenuItem.Text = "Управление заказами";
            this.управлениеЗаказамиToolStripMenuItem.Click += new System.EventHandler(this.ManageProductsToolStripMenuItem_Click);
            // 
            // управлениеКлиентамиToolStripMenuItem
            // 
            this.управлениеКлиентамиToolStripMenuItem.Name = "управлениеКлиентамиToolStripMenuItem";
            this.управлениеКлиентамиToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.управлениеКлиентамиToolStripMenuItem.Text = "Управление клиентами";
            this.управлениеКлиентамиToolStripMenuItem.Click += new System.EventHandler(this.ManageClientsToolStripMenuItem_Click);
            // 
            // управлениеТоварамиToolStripMenuItem
            // 
            this.управлениеТоварамиToolStripMenuItem.Name = "управлениеТоварамиToolStripMenuItem";
            this.управлениеТоварамиToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.управлениеТоварамиToolStripMenuItem.Text = "Управление товарами";
            this.управлениеТоварамиToolStripMenuItem.Click += new System.EventHandler(this.ManageOrdersToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 232);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(681, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExport.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton1.Text = "Экспорт";
            this.toolStripButton1.ToolTipText = "Экспорт";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripExport_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripImport.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton2.Text = "Импорт";
            this.toolStripButton2.ToolTipText = "Импорт";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripImport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 257);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem управлениеЗаказамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеКлиентамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеТоварамиToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}