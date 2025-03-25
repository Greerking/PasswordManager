namespace Password_Manager_App
{
    partial class Hash_form
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
            this.l_origin_pswrd = new System.Windows.Forms.Label();
            this.l_display_pswrd = new System.Windows.Forms.Label();
            this.l_display_hash = new System.Windows.Forms.Label();
            this.l_get_hash = new System.Windows.Forms.Label();
            this.pb_generate_hash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_origin_pswrd
            // 
            this.l_origin_pswrd.AutoSize = true;
            this.l_origin_pswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.l_origin_pswrd.Location = new System.Drawing.Point(31, 75);
            this.l_origin_pswrd.Name = "l_origin_pswrd";
            this.l_origin_pswrd.Size = new System.Drawing.Size(98, 25);
            this.l_origin_pswrd.TabIndex = 0;
            this.l_origin_pswrd.Text = "Password";
            // 
            // l_display_pswrd
            // 
            this.l_display_pswrd.AutoSize = true;
            this.l_display_pswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.l_display_pswrd.Location = new System.Drawing.Point(154, 75);
            this.l_display_pswrd.Name = "l_display_pswrd";
            this.l_display_pswrd.Size = new System.Drawing.Size(64, 25);
            this.l_display_pswrd.TabIndex = 1;
            this.l_display_pswrd.Text = "label2";
            // 
            // l_display_hash
            // 
            this.l_display_hash.AutoSize = true;
            this.l_display_hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.l_display_hash.Location = new System.Drawing.Point(31, 129);
            this.l_display_hash.Name = "l_display_hash";
            this.l_display_hash.Size = new System.Drawing.Size(58, 25);
            this.l_display_hash.TabIndex = 2;
            this.l_display_hash.Text = "Hash";
            // 
            // l_get_hash
            // 
            this.l_get_hash.AutoSize = true;
            this.l_get_hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.l_get_hash.Location = new System.Drawing.Point(154, 129);
            this.l_get_hash.Name = "l_get_hash";
            this.l_get_hash.Size = new System.Drawing.Size(0, 25);
            this.l_get_hash.TabIndex = 3;
            // 
            // pb_generate_hash
            // 
            this.pb_generate_hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pb_generate_hash.Location = new System.Drawing.Point(219, 169);
            this.pb_generate_hash.Name = "pb_generate_hash";
            this.pb_generate_hash.Size = new System.Drawing.Size(183, 41);
            this.pb_generate_hash.TabIndex = 4;
            this.pb_generate_hash.Text = "Generate Hash";
            this.pb_generate_hash.UseVisualStyleBackColor = true;
            this.pb_generate_hash.Click += new System.EventHandler(this.pb_generate_hash_Click);
            // 
            // Hash_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 240);
            this.Controls.Add(this.pb_generate_hash);
            this.Controls.Add(this.l_get_hash);
            this.Controls.Add(this.l_display_hash);
            this.Controls.Add(this.l_display_pswrd);
            this.Controls.Add(this.l_origin_pswrd);
            this.Name = "Hash_form";
            this.Text = "Hash_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_origin_pswrd;
        private System.Windows.Forms.Label l_display_pswrd;
        private System.Windows.Forms.Label l_display_hash;
        private System.Windows.Forms.Label l_get_hash;
        private System.Windows.Forms.Button pb_generate_hash;
    }
}