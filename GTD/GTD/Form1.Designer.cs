namespace GTD
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStuffToInboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToInboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.remainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avilableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.addStuffToInboxToolStripMenuItem,
            this.goToInboxToolStripMenuItem,
            this.defineProjectToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1247, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(126, 36);
            this.ToolStripMenuItem.Text = "Go Back";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.测试一ToolStripMenuItem_Click);
            // 
            // addStuffToInboxToolStripMenuItem
            // 
            this.addStuffToInboxToolStripMenuItem.Name = "addStuffToInboxToolStripMenuItem";
            this.addStuffToInboxToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.addStuffToInboxToolStripMenuItem.Text = "Add Stuff to Inbox";
            // 
            // goToInboxToolStripMenuItem
            // 
            this.goToInboxToolStripMenuItem.Name = "goToInboxToolStripMenuItem";
            this.goToInboxToolStripMenuItem.Size = new System.Drawing.Size(168, 36);
            this.goToInboxToolStripMenuItem.Text = "Go to Inbox";
            // 
            // defineProjectToolStripMenuItem
            // 
            this.defineProjectToolStripMenuItem.Name = "defineProjectToolStripMenuItem";
            this.defineProjectToolStripMenuItem.Size = new System.Drawing.Size(196, 36);
            this.defineProjectToolStripMenuItem.Text = "Define Project";
            this.defineProjectToolStripMenuItem.Click += new System.EventHandler(this.defineProjectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remainingToolStripMenuItem,
            this.avilableToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.allActionsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 36);
            this.toolStripMenuItem1.Text = "Remaining";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // remainingToolStripMenuItem
            // 
            this.remainingToolStripMenuItem.Name = "remainingToolStripMenuItem";
            this.remainingToolStripMenuItem.Size = new System.Drawing.Size(219, 36);
            this.remainingToolStripMenuItem.Text = "Remaining";
            // 
            // avilableToolStripMenuItem
            // 
            this.avilableToolStripMenuItem.Name = "avilableToolStripMenuItem";
            this.avilableToolStripMenuItem.Size = new System.Drawing.Size(219, 36);
            this.avilableToolStripMenuItem.Text = "Available";
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(219, 36);
            this.nextToolStripMenuItem.Text = "Next";
            // 
            // allActionsToolStripMenuItem
            // 
            this.allActionsToolStripMenuItem.Name = "allActionsToolStripMenuItem";
            this.allActionsToolStripMenuItem.Size = new System.Drawing.Size(219, 36);
            this.allActionsToolStripMenuItem.Text = "All Actions";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(61, 4);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(438, 578);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(465, 159);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(762, 480);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.83246F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(478, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 57);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inbox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 902);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FirstPage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStuffToInboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToInboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defineProjectToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem remainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avilableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allActionsToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
    }
}

