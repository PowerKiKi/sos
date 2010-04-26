namespace SOS
{
    partial class Form1
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
           System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
           this.button1 = new System.Windows.Forms.Button();
           this.menuStrip1 = new System.Windows.Forms.MenuStrip();
           this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
           this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
           this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           this.statuBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
           this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
           this.txtNumbers = new System.Windows.Forms.TextBox();
           this.label2 = new System.Windows.Forms.Label();
           this.txtMessage = new System.Windows.Forms.TextBox();
           this.statusStrip1 = new System.Windows.Forms.StatusStrip();
           this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
           this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
           this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
           this.menuStrip1.SuspendLayout();
           this.statusStrip1.SuspendLayout();
           this.tableLayoutPanel1.SuspendLayout();
           this.tableLayoutPanel2.SuspendLayout();
           this.SuspendLayout();
           // 
           // button1
           // 
           this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
           this.button1.Location = new System.Drawing.Point(124, 158);
           this.button1.Name = "button1";
           this.button1.Size = new System.Drawing.Size(75, 23);
           this.button1.TabIndex = 1;
           this.button1.Text = "Send";
           this.button1.UseVisualStyleBackColor = true;
           this.button1.Click += new System.EventHandler(this.button1_Click);
           // 
           // menuStrip1
           // 
           this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.optionsToolStripMenuItem});
           this.menuStrip1.Location = new System.Drawing.Point(0, 0);
           this.menuStrip1.Name = "menuStrip1";
           this.menuStrip1.Size = new System.Drawing.Size(226, 24);
           this.menuStrip1.TabIndex = 3;
           this.menuStrip1.Text = "menuStrip1";
           this.menuStrip1.Visible = false;
           // 
           // toolStripMenuItem1
           // 
           this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
           this.toolStripMenuItem1.Name = "toolStripMenuItem1";
           this.toolStripMenuItem1.Size = new System.Drawing.Size(35, 20);
           this.toolStripMenuItem1.Text = "File";
           // 
           // fileToolStripMenuItem
           // 
           this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
           this.fileToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
           this.fileToolStripMenuItem.Text = "Send";
           // 
           // toolStripSeparator1
           // 
           this.toolStripSeparator1.Name = "toolStripSeparator1";
           this.toolStripSeparator1.Size = new System.Drawing.Size(106, 6);
           // 
           // exitToolStripMenuItem
           // 
           this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
           this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
           this.exitToolStripMenuItem.Text = "Exit";
           // 
           // optionsToolStripMenuItem
           // 
           this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuBarToolStripMenuItem,
            this.optionsToolStripMenuItem1});
           this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
           this.optionsToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
           this.optionsToolStripMenuItem.Text = "Edit";
           // 
           // statuBarToolStripMenuItem
           // 
           this.statuBarToolStripMenuItem.Name = "statuBarToolStripMenuItem";
           this.statuBarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
           this.statuBarToolStripMenuItem.Text = "Status bar";
           // 
           // optionsToolStripMenuItem1
           // 
           this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
           this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
           this.optionsToolStripMenuItem1.Text = "Options";
           // 
           // txtNumbers
           // 
           this.txtNumbers.AutoCompleteCustomSource.AddRange(new string[] {
            "test",
            "toto",
            "testoro",
            "testora",
            "testorb",
            "abc youpi",
            "tactp"});
           this.txtNumbers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
           this.txtNumbers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
           this.txtNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
           this.txtNumbers.Location = new System.Drawing.Point(35, 3);
           this.txtNumbers.Name = "txtNumbers";
           this.txtNumbers.Size = new System.Drawing.Size(158, 20);
           this.txtNumbers.TabIndex = 2;
           this.txtNumbers.Text = "0774100629";
           // 
           // label2
           // 
           this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
           this.label2.AutoSize = true;
           this.label2.Location = new System.Drawing.Point(3, 8);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(26, 13);
           this.label2.TabIndex = 3;
           this.label2.Text = "To :";
           // 
           // txtMessage
           // 
           this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
           this.txtMessage.Location = new System.Drawing.Point(6, 38);
           this.txtMessage.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
           this.txtMessage.MaxLength = 100;
           this.txtMessage.Multiline = true;
           this.txtMessage.Name = "txtMessage";
           this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
           this.txtMessage.Size = new System.Drawing.Size(190, 114);
           this.txtMessage.TabIndex = 0;
           this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
           // 
           // statusStrip1
           // 
           this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
           this.statusStrip1.Location = new System.Drawing.Point(0, 184);
           this.statusStrip1.Name = "statusStrip1";
           this.statusStrip1.Size = new System.Drawing.Size(202, 22);
           this.statusStrip1.TabIndex = 5;
           this.statusStrip1.Text = "statusStrip1";
           // 
           // toolStripStatusLabel1
           // 
           this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
           this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
           this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
           // 
           // tableLayoutPanel1
           // 
           this.tableLayoutPanel1.ColumnCount = 1;
           this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
           this.tableLayoutPanel1.Controls.Add(this.txtMessage, 0, 1);
           this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
           this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
           this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
           this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
           this.tableLayoutPanel1.Name = "tableLayoutPanel1";
           this.tableLayoutPanel1.RowCount = 3;
           this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
           this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
           this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
           this.tableLayoutPanel1.Size = new System.Drawing.Size(202, 184);
           this.tableLayoutPanel1.TabIndex = 6;
           // 
           // tableLayoutPanel2
           // 
           this.tableLayoutPanel2.ColumnCount = 2;
           this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
           this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
           this.tableLayoutPanel2.Controls.Add(this.txtNumbers, 1, 0);
           this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
           this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
           this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
           this.tableLayoutPanel2.Name = "tableLayoutPanel2";
           this.tableLayoutPanel2.RowCount = 1;
           this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
           this.tableLayoutPanel2.Size = new System.Drawing.Size(196, 29);
           this.tableLayoutPanel2.TabIndex = 2;
           // 
           // Form1
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(202, 206);
           this.Controls.Add(this.tableLayoutPanel1);
           this.Controls.Add(this.statusStrip1);
           this.Controls.Add(this.menuStrip1);
           this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
           this.MainMenuStrip = this.menuStrip1;
           this.MinimumSize = new System.Drawing.Size(210, 240);
           this.Name = "Form1";
           this.Text = "SoS";
           this.Load += new System.EventHandler(this.Form1_Load);
           this.menuStrip1.ResumeLayout(false);
           this.menuStrip1.PerformLayout();
           this.statusStrip1.ResumeLayout(false);
           this.statusStrip1.PerformLayout();
           this.tableLayoutPanel1.ResumeLayout(false);
           this.tableLayoutPanel1.PerformLayout();
           this.tableLayoutPanel2.ResumeLayout(false);
           this.tableLayoutPanel2.PerformLayout();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statuBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Label label2;
       private System.Windows.Forms.TextBox txtMessage;
       private System.Windows.Forms.StatusStrip statusStrip1;
       private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
       private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
       private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

