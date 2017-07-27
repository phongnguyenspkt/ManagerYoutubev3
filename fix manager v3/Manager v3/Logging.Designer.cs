namespace Manager_v3
{
    partial class Logging
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnname = new System.Windows.Forms.Button();
            this.btnsetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(118, 22);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(335, 20);
            this.txtname.TabIndex = 0;
            this.txtname.UseSystemPasswordChar = true;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(117, 69);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(335, 20);
            this.txtpass.TabIndex = 1;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.Visible = false;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // btnname
            // 
            this.btnname.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnname.Location = new System.Drawing.Point(27, 19);
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(75, 23);
            this.btnname.TabIndex = 2;
            this.btnname.Text = "Name";
            this.btnname.UseVisualStyleBackColor = false;
            // 
            // btnsetting
            // 
            this.btnsetting.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.Location = new System.Drawing.Point(27, 66);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(75, 23);
            this.btnsetting.TabIndex = 3;
            this.btnsetting.Text = "Password";
            this.btnsetting.UseVisualStyleBackColor = false;
            // 
            // Logging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(503, 129);
            this.Controls.Add(this.btnsetting);
            this.Controls.Add(this.btnname);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtname);
            this.Name = "Logging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logging";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Logging_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnname;
        private System.Windows.Forms.Button btnsetting;
    }
}