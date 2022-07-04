namespace DuAnCuaRiengToi
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptc_avt = new System.Windows.Forms.PictureBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.cb_rememberpass = new System.Windows.Forms.CheckBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptc_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên đăng nhập";
            // 
            // ptc_avt
            // 
            this.ptc_avt.Image = ((System.Drawing.Image)(resources.GetObject("ptc_avt.Image")));
            this.ptc_avt.Location = new System.Drawing.Point(543, 95);
            this.ptc_avt.Name = "ptc_avt";
            this.ptc_avt.Size = new System.Drawing.Size(165, 209);
            this.ptc_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptc_avt.TabIndex = 21;
            this.ptc_avt.TabStop = false;
            this.ptc_avt.Click += new System.EventHandler(this.ptc_avt_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_signup.Location = new System.Drawing.Point(205, 256);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(259, 48);
            this.btn_signup.TabIndex = 20;
            this.btn_signup.Text = "Đăng nhập";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // cb_rememberpass
            // 
            this.cb_rememberpass.AutoSize = true;
            this.cb_rememberpass.Location = new System.Drawing.Point(205, 203);
            this.cb_rememberpass.Name = "cb_rememberpass";
            this.cb_rememberpass.Size = new System.Drawing.Size(121, 19);
            this.cb_rememberpass.TabIndex = 19;
            this.cb_rememberpass.Text = "Ghi nhớ mật khẩu";
            this.cb_rememberpass.UseVisualStyleBackColor = true;
            this.cb_rememberpass.CheckedChanged += new System.EventHandler(this.cb_rememberpass_CheckedChanged);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(205, 174);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(259, 23);
            this.tb_pass.TabIndex = 16;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(205, 115);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(259, 23);
            this.tb_user.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptc_avt);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.cb_rememberpass);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptc_avt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label1;
        private PictureBox ptc_avt;
        private Button btn_signup;
        private CheckBox cb_rememberpass;
        private TextBox tb_pass;
        private TextBox tb_user;
    }
}