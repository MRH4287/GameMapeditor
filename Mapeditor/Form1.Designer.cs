namespace Mapeditor
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Position = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vonNetzwerkLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insNetzwerkSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameDataDateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Systemcount = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.Min_distance = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tool_move = new System.Windows.Forms.ToolStripButton();
            this.tool_systemAdd = new System.Windows.Forms.ToolStripButton();
            this.tool_systemDell = new System.Windows.Forms.ToolStripButton();
            this.tool_NodeAdd = new System.Windows.Forms.ToolStripButton();
            this.tool_NodeDell = new System.Windows.Forms.ToolStripButton();
            this.tool_randomArea = new System.Windows.Forms.ToolStripButton();
            this.tool_delRandomArea = new System.Windows.Forms.ToolStripButton();
            this.tool_Info = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Position});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(812, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Position:";
            // 
            // Position
            // 
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(22, 17);
            this.Position.Text = "0:0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.gameDataDateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.ladenToolStripMenuItem,
            this.vonNetzwerkLadenToolStripMenuItem,
            this.insNetzwerkSpeichernToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            this.neuToolStripMenuItem.Text = "Neu ...";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            this.speichernToolStripMenuItem.Text = "Speichern ...";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            this.ladenToolStripMenuItem.Text = "Laden ...";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
            // 
            // vonNetzwerkLadenToolStripMenuItem
            // 
            this.vonNetzwerkLadenToolStripMenuItem.Name = "vonNetzwerkLadenToolStripMenuItem";
            this.vonNetzwerkLadenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.O)));
            this.vonNetzwerkLadenToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            this.vonNetzwerkLadenToolStripMenuItem.Text = "Von Netzwerk laden ...";
            this.vonNetzwerkLadenToolStripMenuItem.Click += new System.EventHandler(this.vonNetzwerkLadenToolStripMenuItem_Click);
            // 
            // insNetzwerkSpeichernToolStripMenuItem
            // 
            this.insNetzwerkSpeichernToolStripMenuItem.Name = "insNetzwerkSpeichernToolStripMenuItem";
            this.insNetzwerkSpeichernToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.insNetzwerkSpeichernToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            this.insNetzwerkSpeichernToolStripMenuItem.Text = "Ins Netzwerk speichern ...";
            this.insNetzwerkSpeichernToolStripMenuItem.Click += new System.EventHandler(this.insNetzwerkSpeichernToolStripMenuItem_Click);
            // 
            // gameDataDateiToolStripMenuItem
            // 
            this.gameDataDateiToolStripMenuItem.Name = "gameDataDateiToolStripMenuItem";
            this.gameDataDateiToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.gameDataDateiToolStripMenuItem.Text = "Game Data Datei laden ...";
            this.gameDataDateiToolStripMenuItem.Click += new System.EventHandler(this.gameDataDateiToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(812, 422);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(812, 472);
            this.toolStripContainer1.TabIndex = 19;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 422);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.Systemcount,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.Min_distance});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(293, 25);
            this.toolStrip2.TabIndex = 31;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "Zufällige Systeme";
            // 
            // Systemcount
            // 
            this.Systemcount.Name = "Systemcount";
            this.Systemcount.Size = new System.Drawing.Size(30, 25);
            this.Systemcount.Text = "20";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabel2.Text = "Minimaler Abstand:";
            // 
            // Min_distance
            // 
            this.Min_distance.Name = "Min_distance";
            this.Min_distance.Size = new System.Drawing.Size(30, 25);
            this.Min_distance.Text = "30";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_move,
            this.tool_systemAdd,
            this.tool_systemDell,
            this.tool_NodeAdd,
            this.tool_NodeDell,
            this.tool_randomArea,
            this.tool_delRandomArea,
            this.tool_Info});
            this.toolStrip1.Location = new System.Drawing.Point(3, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(196, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tool_move
            // 
            this.tool_move.Checked = true;
            this.tool_move.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tool_move.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_move.Image = ((System.Drawing.Image)(resources.GetObject("tool_move.Image")));
            this.tool_move.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_move.Name = "tool_move";
            this.tool_move.Size = new System.Drawing.Size(23, 22);
            this.tool_move.Text = "Ein Sonnensystem bewegen";
            this.tool_move.Click += new System.EventHandler(this.tool_systemAdd_Click);
            // 
            // tool_systemAdd
            // 
            this.tool_systemAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_systemAdd.Image = ((System.Drawing.Image)(resources.GetObject("tool_systemAdd.Image")));
            this.tool_systemAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_systemAdd.Name = "tool_systemAdd";
            this.tool_systemAdd.Size = new System.Drawing.Size(23, 22);
            this.tool_systemAdd.Text = "Ein neues Sonnensystem erstellen";
            this.tool_systemAdd.Click += new System.EventHandler(this.tool_systemAdd_Click);
            // 
            // tool_systemDell
            // 
            this.tool_systemDell.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_systemDell.Image = ((System.Drawing.Image)(resources.GetObject("tool_systemDell.Image")));
            this.tool_systemDell.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_systemDell.Name = "tool_systemDell";
            this.tool_systemDell.Size = new System.Drawing.Size(23, 22);
            this.tool_systemDell.Text = "Ein Sonnensystem löschen";
            this.tool_systemDell.Click += new System.EventHandler(this.tool_systemAdd_Click);
            // 
            // tool_NodeAdd
            // 
            this.tool_NodeAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_NodeAdd.Image = ((System.Drawing.Image)(resources.GetObject("tool_NodeAdd.Image")));
            this.tool_NodeAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_NodeAdd.Name = "tool_NodeAdd";
            this.tool_NodeAdd.Size = new System.Drawing.Size(23, 22);
            this.tool_NodeAdd.Text = "Eine neue Verbindung zwischen Sonnensystem herstellen";
            this.tool_NodeAdd.Click += new System.EventHandler(this.tool_systemAdd_Click);
            // 
            // tool_NodeDell
            // 
            this.tool_NodeDell.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_NodeDell.Image = ((System.Drawing.Image)(resources.GetObject("tool_NodeDell.Image")));
            this.tool_NodeDell.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_NodeDell.Name = "tool_NodeDell";
            this.tool_NodeDell.Size = new System.Drawing.Size(23, 22);
            this.tool_NodeDell.Text = "Eine Vorhandene Verbindung zwischen Systemen löschen";
            this.tool_NodeDell.Click += new System.EventHandler(this.tool_systemAdd_Click);
            // 
            // tool_randomArea
            // 
            this.tool_randomArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_randomArea.Image = ((System.Drawing.Image)(resources.GetObject("tool_randomArea.Image")));
            this.tool_randomArea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_randomArea.Name = "tool_randomArea";
            this.tool_randomArea.Size = new System.Drawing.Size(23, 22);
            this.tool_randomArea.Text = "Den Bereich, in dem die Systeme Zufällg  erstellt werden, definieren";
            this.tool_randomArea.Click += new System.EventHandler(this.tool_systemAdd_Click);
            // 
            // tool_delRandomArea
            // 
            this.tool_delRandomArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_delRandomArea.Image = ((System.Drawing.Image)(resources.GetObject("tool_delRandomArea.Image")));
            this.tool_delRandomArea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_delRandomArea.Name = "tool_delRandomArea";
            this.tool_delRandomArea.Size = new System.Drawing.Size(23, 22);
            this.tool_delRandomArea.Text = "Einen vorher definierten Bereich mit Zufälligen Systemen löschen";
            this.tool_delRandomArea.Click += new System.EventHandler(this.tool_systemAdd_Click);
            // 
            // tool_Info
            // 
            this.tool_Info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_Info.Image = ((System.Drawing.Image)(resources.GetObject("tool_Info.Image")));
            this.tool_Info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_Info.Name = "tool_Info";
            this.tool_Info.Size = new System.Drawing.Size(23, 22);
            this.tool_Info.Text = "Informationen über sonnensysteme";
            this.tool_Info.Click += new System.EventHandler(this.tool_systemAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 518);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "MapEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Position;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tool_move;
        private System.Windows.Forms.ToolStripButton tool_systemAdd;
        private System.Windows.Forms.ToolStripButton tool_systemDell;
        private System.Windows.Forms.ToolStripButton tool_NodeAdd;
        private System.Windows.Forms.ToolStripButton tool_NodeDell;
        private System.Windows.Forms.ToolStripButton tool_randomArea;
        private System.Windows.Forms.ToolStripButton tool_delRandomArea;
        private System.Windows.Forms.ToolStripButton tool_Info;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox Systemcount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox Min_distance;
        private System.Windows.Forms.ToolStripMenuItem gameDataDateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vonNetzwerkLadenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insNetzwerkSpeichernToolStripMenuItem;
    }
}

