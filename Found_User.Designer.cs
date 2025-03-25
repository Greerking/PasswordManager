namespace Password_Manager_App
{
    partial class Found_User
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
            this.pb_exit = new System.Windows.Forms.Button();
            this.l_site = new System.Windows.Forms.Label();
            this.l_email = new System.Windows.Forms.Label();
            this.l_pswrd = new System.Windows.Forms.Label();
            this.bp_copy_site = new System.Windows.Forms.Button();
            this.pb_copy_email = new System.Windows.Forms.Button();
            this.pb_copy_pswrd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pb_exit
            // 
            this.pb_exit.Location = new System.Drawing.Point(174, 211);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(76, 35);
            this.pb_exit.TabIndex = 0;
            this.pb_exit.Text = "OK";
            this.pb_exit.UseVisualStyleBackColor = true;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // l_site
            // 
            this.l_site.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_site.Location = new System.Drawing.Point(52, 76);
            this.l_site.Name = "l_site";
            this.l_site.Size = new System.Drawing.Size(263, 50);
            this.l_site.TabIndex = 2;
            this.l_site.Text = "label2";
            // 
            // l_email
            // 
            this.l_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.l_email.Location = new System.Drawing.Point(52, 120);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(262, 65);
            this.l_email.TabIndex = 3;
            this.l_email.Text = "label3";
            // 
            // l_pswrd
            // 
            this.l_pswrd.AutoSize = true;
            this.l_pswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.l_pswrd.Location = new System.Drawing.Point(52, 166);
            this.l_pswrd.Name = "l_pswrd";
            this.l_pswrd.Size = new System.Drawing.Size(51, 20);
            this.l_pswrd.TabIndex = 4;
            this.l_pswrd.Text = "label4";
            // 
            // bp_copy_site
            // 
            this.bp_copy_site.Location = new System.Drawing.Point(321, 76);
            this.bp_copy_site.Name = "bp_copy_site";
            this.bp_copy_site.Size = new System.Drawing.Size(68, 35);
            this.bp_copy_site.TabIndex = 5;
            this.bp_copy_site.Text = "Copy";
            this.bp_copy_site.UseVisualStyleBackColor = true;
            this.bp_copy_site.Click += new System.EventHandler(this.bp_copy_site_Click);
            // 
            // pb_copy_email
            // 
            this.pb_copy_email.Location = new System.Drawing.Point(321, 114);
            this.pb_copy_email.Name = "pb_copy_email";
            this.pb_copy_email.Size = new System.Drawing.Size(68, 35);
            this.pb_copy_email.TabIndex = 6;
            this.pb_copy_email.Text = "Copy";
            this.pb_copy_email.UseVisualStyleBackColor = true;
            this.pb_copy_email.Click += new System.EventHandler(this.pb_copy_email_Click);
            // 
            // pb_copy_pswrd
            // 
            this.pb_copy_pswrd.Location = new System.Drawing.Point(321, 155);
            this.pb_copy_pswrd.Name = "pb_copy_pswrd";
            this.pb_copy_pswrd.Size = new System.Drawing.Size(68, 33);
            this.pb_copy_pswrd.TabIndex = 7;
            this.pb_copy_pswrd.Text = "Copy";
            this.pb_copy_pswrd.UseVisualStyleBackColor = true;
            this.pb_copy_pswrd.Click += new System.EventHandler(this.pb_copy_pswrd_Click);
            // 
            // Found_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 292);
            this.Controls.Add(this.pb_copy_pswrd);
            this.Controls.Add(this.pb_copy_email);
            this.Controls.Add(this.bp_copy_site);
            this.Controls.Add(this.l_pswrd);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.l_site);
            this.Controls.Add(this.pb_exit);
            this.Name = "Found_User";
            this.Text = "Found_User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pb_exit;
        private System.Windows.Forms.Label l_site;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Label l_pswrd;
        private System.Windows.Forms.Button bp_copy_site;
        private System.Windows.Forms.Button pb_copy_email;
        private System.Windows.Forms.Button pb_copy_pswrd;
    }
}