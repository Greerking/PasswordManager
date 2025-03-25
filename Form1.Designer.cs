namespace Password_Manager_App
{
    partial class main_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_window));
            this.pb_find = new System.Windows.Forms.Button();
            this.pb_generate_password = new System.Windows.Forms.Button();
            this.gb_main = new System.Windows.Forms.GroupBox();
            this.picture_lock = new System.Windows.Forms.PictureBox();
            this.pb_add_user = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_website = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.l_Password = new System.Windows.Forms.Label();
            this.l_email = new System.Windows.Forms.Label();
            this.l_Website = new System.Windows.Forms.Label();
            this.bp_hash = new System.Windows.Forms.Button();
            this.gb_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lock)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_find
            // 
            this.pb_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pb_find.Location = new System.Drawing.Point(511, 380);
            this.pb_find.Name = "pb_find";
            this.pb_find.Size = new System.Drawing.Size(154, 34);
            this.pb_find.TabIndex = 0;
            this.pb_find.Text = "Find";
            this.pb_find.UseVisualStyleBackColor = true;
            this.pb_find.Click += new System.EventHandler(this.pb_find_Click);
            // 
            // pb_generate_password
            // 
            this.pb_generate_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pb_generate_password.Location = new System.Drawing.Point(398, 456);
            this.pb_generate_password.Name = "pb_generate_password";
            this.pb_generate_password.Size = new System.Drawing.Size(154, 35);
            this.pb_generate_password.TabIndex = 1;
            this.pb_generate_password.Text = "Generate";
            this.pb_generate_password.UseVisualStyleBackColor = true;
            this.pb_generate_password.Click += new System.EventHandler(this.pb_generate_password_Click);
            // 
            // gb_main
            // 
            this.gb_main.Controls.Add(this.bp_hash);
            this.gb_main.Controls.Add(this.picture_lock);
            this.gb_main.Controls.Add(this.pb_add_user);
            this.gb_main.Controls.Add(this.tb_password);
            this.gb_main.Controls.Add(this.tb_website);
            this.gb_main.Controls.Add(this.tb_email);
            this.gb_main.Controls.Add(this.l_Password);
            this.gb_main.Controls.Add(this.l_email);
            this.gb_main.Controls.Add(this.l_Website);
            this.gb_main.Controls.Add(this.pb_find);
            this.gb_main.Controls.Add(this.pb_generate_password);
            this.gb_main.Location = new System.Drawing.Point(12, 12);
            this.gb_main.Name = "gb_main";
            this.gb_main.Size = new System.Drawing.Size(671, 543);
            this.gb_main.TabIndex = 2;
            this.gb_main.TabStop = false;
            // 
            // picture_lock
            // 
            this.picture_lock.Image = ((System.Drawing.Image)(resources.GetObject("picture_lock.Image")));
            this.picture_lock.Location = new System.Drawing.Point(195, 19);
            this.picture_lock.Name = "picture_lock";
            this.picture_lock.Size = new System.Drawing.Size(291, 338);
            this.picture_lock.TabIndex = 9;
            this.picture_lock.TabStop = false;
            // 
            // pb_add_user
            // 
            this.pb_add_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pb_add_user.Location = new System.Drawing.Point(172, 497);
            this.pb_add_user.Name = "pb_add_user";
            this.pb_add_user.Size = new System.Drawing.Size(493, 34);
            this.pb_add_user.TabIndex = 8;
            this.pb_add_user.Text = "Add";
            this.pb_add_user.UseVisualStyleBackColor = true;
            this.pb_add_user.Click += new System.EventHandler(this.pb_add_user_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(172, 464);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(220, 20);
            this.tb_password.TabIndex = 7;
            // 
            // tb_website
            // 
            this.tb_website.Location = new System.Drawing.Point(172, 388);
            this.tb_website.Name = "tb_website";
            this.tb_website.Size = new System.Drawing.Size(333, 20);
            this.tb_website.TabIndex = 6;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(172, 427);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(493, 20);
            this.tb_email.TabIndex = 5;
            // 
            // l_Password
            // 
            this.l_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Password.Location = new System.Drawing.Point(6, 456);
            this.l_Password.Name = "l_Password";
            this.l_Password.Size = new System.Drawing.Size(106, 34);
            this.l_Password.TabIndex = 4;
            this.l_Password.Text = "Password:";
            this.l_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_email
            // 
            this.l_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_email.Location = new System.Drawing.Point(2, 416);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(164, 34);
            this.l_email.TabIndex = 3;
            this.l_email.Text = "Email/Username:";
            this.l_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_Website
            // 
            this.l_Website.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Website.Location = new System.Drawing.Point(6, 382);
            this.l_Website.Name = "l_Website";
            this.l_Website.Size = new System.Drawing.Size(91, 34);
            this.l_Website.TabIndex = 2;
            this.l_Website.Text = "Website:";
            this.l_Website.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bp_hash
            // 
            this.bp_hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bp_hash.Location = new System.Drawing.Point(558, 456);
            this.bp_hash.Name = "bp_hash";
            this.bp_hash.Size = new System.Drawing.Size(107, 35);
            this.bp_hash.TabIndex = 10;
            this.bp_hash.Text = "Hash";
            this.bp_hash.UseVisualStyleBackColor = true;
            this.bp_hash.Click += new System.EventHandler(this.bp_hash_Click);
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 561);
            this.Controls.Add(this.gb_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_window";
            this.Text = "Password Manager";
            this.gb_main.ResumeLayout(false);
            this.gb_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pb_find;
        private System.Windows.Forms.Button pb_generate_password;
        private System.Windows.Forms.GroupBox gb_main;
        private System.Windows.Forms.Label l_Website;
        private System.Windows.Forms.Label l_Password;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_website;
        private System.Windows.Forms.Button pb_add_user;
        private System.Windows.Forms.PictureBox picture_lock;
        private System.Windows.Forms.Button bp_hash;
    }
}

