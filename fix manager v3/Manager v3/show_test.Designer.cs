namespace Manager_v3
{
    partial class show_test
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
            this.btnExit = new System.Windows.Forms.Button();
            this.listchannel = new System.Windows.Forms.ListView();
            this.clid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btngetnote = new System.Windows.Forms.Button();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.listtest = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listnovideo = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(814, 626);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 27);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listchannel
            // 
            this.listchannel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clid,
            this.clName,
            this.clmail,
            this.clga,
            this.clnote});
            this.listchannel.Cursor = System.Windows.Forms.Cursors.Default;
            this.listchannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listchannel.FullRowSelect = true;
            this.listchannel.GridLines = true;
            this.listchannel.Location = new System.Drawing.Point(19, 31);
            this.listchannel.Name = "listchannel";
            this.listchannel.Size = new System.Drawing.Size(924, 121);
            this.listchannel.TabIndex = 14;
            this.listchannel.UseCompatibleStateImageBehavior = false;
            this.listchannel.View = System.Windows.Forms.View.Details;
            this.listchannel.SelectedIndexChanged += new System.EventHandler(this.listchannel_SelectedIndexChanged);
            // 
            // clid
            // 
            this.clid.Text = "Id";
            this.clid.Width = 46;
            // 
            // clName
            // 
            this.clName.Text = "Name";
            this.clName.Width = 300;
            // 
            // clmail
            // 
            this.clmail.Text = "Mail";
            this.clmail.Width = 200;
            // 
            // clga
            // 
            this.clga.Text = "Ga";
            this.clga.Width = 200;
            // 
            // clnote
            // 
            this.clnote.Text = "Note";
            this.clnote.Width = 500;
            // 
            // btngetnote
            // 
            this.btngetnote.BackColor = System.Drawing.Color.CadetBlue;
            this.btngetnote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngetnote.Location = new System.Drawing.Point(14, 542);
            this.btngetnote.Name = "btngetnote";
            this.btngetnote.Size = new System.Drawing.Size(97, 23);
            this.btngetnote.TabIndex = 20;
            this.btngetnote.Text = "Note";
            this.btngetnote.UseVisualStyleBackColor = false;
            this.btngetnote.Click += new System.EventHandler(this.btngetnote_Click);
            // 
            // txtnote
            // 
            this.txtnote.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtnote.Location = new System.Drawing.Point(129, 544);
            this.txtnote.Multiline = true;
            this.txtnote.Name = "txtnote";
            this.txtnote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtnote.Size = new System.Drawing.Size(814, 76);
            this.txtnote.TabIndex = 19;
            // 
            // listtest
            // 
            this.listtest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listtest.Cursor = System.Windows.Forms.Cursors.Default;
            this.listtest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listtest.FullRowSelect = true;
            this.listtest.GridLines = true;
            this.listtest.Location = new System.Drawing.Point(12, 187);
            this.listtest.Name = "listtest";
            this.listtest.Size = new System.Drawing.Size(924, 161);
            this.listtest.TabIndex = 21;
            this.listtest.UseCompatibleStateImageBehavior = false;
            this.listtest.View = System.Windows.Forms.View.Details;
            this.listtest.SelectedIndexChanged += new System.EventHandler(this.listtest_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 46;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mail";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ga";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Note";
            this.columnHeader5.Width = 500;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(19, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Channel die";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(19, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Channel non money";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(19, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "No video";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // listnovideo
            // 
            this.listnovideo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listnovideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.listnovideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listnovideo.FullRowSelect = true;
            this.listnovideo.GridLines = true;
            this.listnovideo.Location = new System.Drawing.Point(12, 393);
            this.listnovideo.Name = "listnovideo";
            this.listnovideo.Size = new System.Drawing.Size(924, 129);
            this.listnovideo.TabIndex = 24;
            this.listnovideo.UseCompatibleStateImageBehavior = false;
            this.listnovideo.View = System.Windows.Forms.View.Details;
            this.listnovideo.SelectedIndexChanged += new System.EventHandler(this.listnovideo_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            this.columnHeader6.Width = 46;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            this.columnHeader7.Width = 300;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mail";
            this.columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ga";
            this.columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Note";
            this.columnHeader10.Width = 500;
            // 
            // show_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Manager_v3.Properties.Resources.nen2;
            this.ClientSize = new System.Drawing.Size(971, 668);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listnovideo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listtest);
            this.Controls.Add(this.btngetnote);
            this.Controls.Add(this.txtnote);
            this.Controls.Add(this.listchannel);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "show_test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show test";
            this.Load += new System.EventHandler(this.show_test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView listchannel;
        private System.Windows.Forms.ColumnHeader clid;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clmail;
        private System.Windows.Forms.ColumnHeader clga;
        private System.Windows.Forms.ColumnHeader clnote;
        private System.Windows.Forms.Button btngetnote;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.ListView listtest;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listnovideo;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;

    }
}