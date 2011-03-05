namespace Mapeditor
{
    partial class SystemInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nodelist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PlanetTypes = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.planetList = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(59, 11);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(216, 20);
            this.name.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 284);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.planetList);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.PlanetTypes);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(200, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 259);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Planeten";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nodelist);
            this.groupBox2.Location = new System.Drawing.Point(8, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 259);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste der Verbindungen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(396, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(281, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Startpunkt";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anzahl der Planeten";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generieren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nodelist
            // 
            this.nodelist.BackColor = System.Drawing.SystemColors.MenuBar;
            this.nodelist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nodelist.Location = new System.Drawing.Point(6, 28);
            this.nodelist.Multiline = true;
            this.nodelist.Name = "nodelist";
            this.nodelist.ReadOnly = true;
            this.nodelist.Size = new System.Drawing.Size(174, 225);
            this.nodelist.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Typ";
            // 
            // PlanetTypes
            // 
            this.PlanetTypes.FormattingEnabled = true;
            this.PlanetTypes.Location = new System.Drawing.Point(56, 55);
            this.PlanetTypes.Name = "PlanetTypes";
            this.PlanetTypes.Size = new System.Drawing.Size(116, 21);
            this.PlanetTypes.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hinzufügen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // planetList
            // 
            this.planetList.Location = new System.Drawing.Point(13, 90);
            this.planetList.Multiline = true;
            this.planetList.Name = "planetList";
            this.planetList.ReadOnly = true;
            this.planetList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.planetList.Size = new System.Drawing.Size(236, 162);
            this.planetList.TabIndex = 7;
            // 
            // SystemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 327);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "SystemInfo";
            this.Text = "SystemInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SystemInfo_FormClosing);
            this.Load += new System.EventHandler(this.SystemInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox nodelist;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox PlanetTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox planetList;
    }
}