namespace Web_Browser
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBookmarkFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBookmarkFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBookmarkFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.listBoxBookMarks = new System.Windows.Forms.ListBox();
            this.textBoxSearchBar = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookmarkFileToolStripMenuItem,
            this.loadBookmarkFileToolStripMenuItem,
            this.saveBookmarkFileToolStripMenuItem,
            this.addBookmarkToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newBookmarkFileToolStripMenuItem
            // 
            this.newBookmarkFileToolStripMenuItem.Name = "newBookmarkFileToolStripMenuItem";
            this.newBookmarkFileToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.newBookmarkFileToolStripMenuItem.Text = "New Bookmark File";
            this.newBookmarkFileToolStripMenuItem.Click += new System.EventHandler(this.newBookmarkFileToolStripMenuItem_Click);
            // 
            // loadBookmarkFileToolStripMenuItem
            // 
            this.loadBookmarkFileToolStripMenuItem.Name = "loadBookmarkFileToolStripMenuItem";
            this.loadBookmarkFileToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.loadBookmarkFileToolStripMenuItem.Text = "Load Bookmark File";
            this.loadBookmarkFileToolStripMenuItem.Click += new System.EventHandler(this.loadBookmarkFileToolStripMenuItem_Click);
            // 
            // saveBookmarkFileToolStripMenuItem
            // 
            this.saveBookmarkFileToolStripMenuItem.Name = "saveBookmarkFileToolStripMenuItem";
            this.saveBookmarkFileToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveBookmarkFileToolStripMenuItem.Text = "Save Bookmark File";
            this.saveBookmarkFileToolStripMenuItem.Click += new System.EventHandler(this.saveBookmarkFileToolStripMenuItem_Click);
            // 
            // addBookmarkToolStripMenuItem
            // 
            this.addBookmarkToolStripMenuItem.Name = "addBookmarkToolStripMenuItem";
            this.addBookmarkToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.addBookmarkToolStripMenuItem.Text = "Add Bookmark";
            this.addBookmarkToolStripMenuItem.Click += new System.EventHandler(this.addBookmarkToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 56);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(560, 348);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // listBoxBookMarks
            // 
            this.listBoxBookMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBookMarks.FormattingEnabled = true;
            this.listBoxBookMarks.ItemHeight = 16;
            this.listBoxBookMarks.Location = new System.Drawing.Point(567, 28);
            this.listBoxBookMarks.Name = "listBoxBookMarks";
            this.listBoxBookMarks.Size = new System.Drawing.Size(221, 372);
            this.listBoxBookMarks.TabIndex = 2;
            this.listBoxBookMarks.SelectedIndexChanged += new System.EventHandler(this.listBoxBookMarks_SelectedIndexChanged);
            // 
            // textBoxSearchBar
            // 
            this.textBoxSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchBar.Location = new System.Drawing.Point(74, 28);
            this.textBoxSearchBar.Name = "textBoxSearchBar";
            this.textBoxSearchBar.Size = new System.Drawing.Size(427, 22);
            this.textBoxSearchBar.TabIndex = 3;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(0, 28);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(31, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForward.Location = new System.Drawing.Point(37, 28);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(31, 23);
            this.buttonForward.TabIndex = 5;
            this.buttonForward.Text = ">";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(507, 27);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(53, 23);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(0, 410);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(560, 22);
            this.textBoxStatus.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(567, 410);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(64, 22);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxSearchBar);
            this.Controls.Add(this.listBoxBookMarks);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBookmarkFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBookmarkFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBookmarkFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ListBox listBoxBookMarks;
        private System.Windows.Forms.TextBox textBoxSearchBar;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonDelete;
    }
}

