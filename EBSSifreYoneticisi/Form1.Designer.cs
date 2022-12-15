namespace EBSSifreYoneticisi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sfr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mailadresi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_platform = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ebubekirBastamaV01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.facebookPasswordsChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterPasswordsChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedinPasswordsChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gmailPasswordsChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(569, 800);
            this.splitContainer1.SplitterDistance = 149;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_sfr);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_mailadresi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_platform);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 76);
            this.panel2.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(298, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Encrypted Passwd";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(298, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // txt_sfr
            // 
            this.txt_sfr.Location = new System.Drawing.Point(405, 11);
            this.txt_sfr.Name = "txt_sfr";
            this.txt_sfr.Size = new System.Drawing.Size(131, 23);
            this.txt_sfr.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail address";
            // 
            // txt_mailadresi
            // 
            this.txt_mailadresi.Location = new System.Drawing.Point(155, 41);
            this.txt_mailadresi.Name = "txt_mailadresi";
            this.txt_mailadresi.Size = new System.Drawing.Size(131, 23);
            this.txt_mailadresi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Platform";
            // 
            // txt_platform
            // 
            this.txt_platform.Location = new System.Drawing.Point(155, 12);
            this.txt_platform.Name = "txt_platform";
            this.txt_platform.Size = new System.Drawing.Size(131, 23);
            this.txt_platform.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 73);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(569, 647);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ebubekirBastamaV01ToolStripMenuItem,
            this.toolStripSeparator1,
            this.facebookPasswordsChangeToolStripMenuItem,
            this.twitterPasswordsChangeToolStripMenuItem,
            this.linkedinPasswordsChangeToolStripMenuItem,
            this.gmailPasswordsChangeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(228, 120);
            // 
            // ebubekirBastamaV01ToolStripMenuItem
            // 
            this.ebubekirBastamaV01ToolStripMenuItem.Enabled = false;
            this.ebubekirBastamaV01ToolStripMenuItem.Name = "ebubekirBastamaV01ToolStripMenuItem";
            this.ebubekirBastamaV01ToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ebubekirBastamaV01ToolStripMenuItem.Text = "Ebubekir Bastama V 0.1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // facebookPasswordsChangeToolStripMenuItem
            // 
            this.facebookPasswordsChangeToolStripMenuItem.Name = "facebookPasswordsChangeToolStripMenuItem";
            this.facebookPasswordsChangeToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.facebookPasswordsChangeToolStripMenuItem.Text = "Facebook Passwords Change";
            this.facebookPasswordsChangeToolStripMenuItem.Click += new System.EventHandler(this.facebookPasswordsChangeToolStripMenuItem_Click);
            // 
            // twitterPasswordsChangeToolStripMenuItem
            // 
            this.twitterPasswordsChangeToolStripMenuItem.Name = "twitterPasswordsChangeToolStripMenuItem";
            this.twitterPasswordsChangeToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.twitterPasswordsChangeToolStripMenuItem.Text = "Twitter Passwords Change";
            this.twitterPasswordsChangeToolStripMenuItem.Click += new System.EventHandler(this.twitterPasswordsChangeToolStripMenuItem_Click);
            // 
            // linkedinPasswordsChangeToolStripMenuItem
            // 
            this.linkedinPasswordsChangeToolStripMenuItem.Name = "linkedinPasswordsChangeToolStripMenuItem";
            this.linkedinPasswordsChangeToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.linkedinPasswordsChangeToolStripMenuItem.Text = "Linkedin Passwords Change";
            this.linkedinPasswordsChangeToolStripMenuItem.Click += new System.EventHandler(this.linkedinPasswordsChangeToolStripMenuItem_Click);
            // 
            // gmailPasswordsChangeToolStripMenuItem
            // 
            this.gmailPasswordsChangeToolStripMenuItem.Name = "gmailPasswordsChangeToolStripMenuItem";
            this.gmailPasswordsChangeToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.gmailPasswordsChangeToolStripMenuItem.Text = "Gmail Passwords Change";
            this.gmailPasswordsChangeToolStripMenuItem.Click += new System.EventHandler(this.gmailPasswordsChangeToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 800);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EBS Password Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private TextBox txt_platform;
        private Label label2;
        private TextBox txt_mailadresi;
        private Label label3;
        private TextBox txt_sfr;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ebubekirBastamaV01ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ErrorProvider errorProvider1;
        private CheckBox checkBox1;
        private ToolStripMenuItem facebookPasswordsChangeToolStripMenuItem;
        private ToolStripMenuItem twitterPasswordsChangeToolStripMenuItem;
        private ToolStripMenuItem linkedinPasswordsChangeToolStripMenuItem;
        private ToolStripMenuItem gmailPasswordsChangeToolStripMenuItem;
        private DataGridView dataGridView1;
    }
}