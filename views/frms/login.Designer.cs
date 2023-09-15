namespace projeto2023.views.frms
{
    partial class login
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.btn_limparcampos = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txb_pass = new System.Windows.Forms.TextBox();
            this.txb_user = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::projeto2023.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(67, 112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_login
            // 
            this.pnl_login.Controls.Add(this.btn_limparcampos);
            this.pnl_login.Controls.Add(this.btn_login);
            this.pnl_login.Controls.Add(this.lbl_login);
            this.pnl_login.Controls.Add(this.lbl_pass);
            this.pnl_login.Controls.Add(this.lbl_user);
            this.pnl_login.Controls.Add(this.txb_pass);
            this.pnl_login.Controls.Add(this.txb_user);
            this.pnl_login.Location = new System.Drawing.Point(489, 112);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(300, 309);
            this.pnl_login.TabIndex = 1;
            // 
            // btn_limparcampos
            // 
            this.btn_limparcampos.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btn_limparcampos.Location = new System.Drawing.Point(170, 245);
            this.btn_limparcampos.Name = "btn_limparcampos";
            this.btn_limparcampos.Size = new System.Drawing.Size(75, 44);
            this.btn_limparcampos.TabIndex = 6;
            this.btn_limparcampos.Text = "LIMPAR";
            this.btn_limparcampos.UseVisualStyleBackColor = true;
            this.btn_limparcampos.Click += new System.EventHandler(this.btn_limparcampos_Click);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btn_login.Location = new System.Drawing.Point(57, 245);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 44);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(131, 19);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(70, 22);
            this.lbl_login.TabIndex = 4;
            this.lbl_login.Text = "LOGIN";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(54, 153);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(73, 22);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "SENHA";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(54, 64);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(94, 22);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "USUÁRIO";
            // 
            // txb_pass
            // 
            this.txb_pass.Location = new System.Drawing.Point(57, 188);
            this.txb_pass.Name = "txb_pass";
            this.txb_pass.PasswordChar = '*';
            this.txb_pass.Size = new System.Drawing.Size(188, 30);
            this.txb_pass.TabIndex = 1;
            this.txb_pass.UseSystemPasswordChar = true;
            // 
            // txb_user
            // 
            this.txb_user.Location = new System.Drawing.Point(57, 102);
            this.txb_user.Name = "txb_user";
            this.txb_user.Size = new System.Drawing.Size(188, 30);
            this.txb_user.TabIndex = 0;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(864, 503);
            this.Controls.Add(this.pnl_login);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Button btn_limparcampos;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txb_pass;
        private System.Windows.Forms.TextBox txb_user;
    }
}