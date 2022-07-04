namespace DuAnCuaRiengToi
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_repass = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.cb_privacy = new System.Windows.Forms.CheckBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.ptc_avt = new System.Windows.Forms.PictureBox();
            this.btn_avt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptc_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(269, 63);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(259, 23);
            this.tb_user.TabIndex = 0;
            // 
            // tb_repass
            // 
            this.tb_repass.Location = new System.Drawing.Point(269, 184);
            this.tb_repass.Name = "tb_repass";
            this.tb_repass.Size = new System.Drawing.Size(259, 23);
            this.tb_repass.TabIndex = 1;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(269, 122);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(259, 23);
            this.tb_pass.TabIndex = 2;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(269, 249);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(259, 23);
            this.tb_email.TabIndex = 3;
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(269, 305);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(121, 23);
            this.cb_gender.TabIndex = 4;
            // 
            // cb_privacy
            // 
            this.cb_privacy.AutoSize = true;
            this.cb_privacy.Location = new System.Drawing.Point(269, 334);
            this.cb_privacy.Name = "cb_privacy";
            this.cb_privacy.Size = new System.Drawing.Size(223, 19);
            this.cb_privacy.TabIndex = 5;
            this.cb_privacy.Text = "Tôi đồng ý với điều khoản và sử dụng";
            this.cb_privacy.UseVisualStyleBackColor = true;
            // 
            // btn_signup
            // 
            this.btn_signup.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_signup.Location = new System.Drawing.Point(269, 369);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(259, 48);
            this.btn_signup.TabIndex = 6;
            this.btn_signup.Text = "Đăng ký";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // ptc_avt
            // 
            this.ptc_avt.Image = ((System.Drawing.Image)(resources.GetObject("ptc_avt.Image")));
            this.ptc_avt.Location = new System.Drawing.Point(605, 63);
            this.ptc_avt.Name = "ptc_avt";
            this.ptc_avt.Size = new System.Drawing.Size(165, 209);
            this.ptc_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptc_avt.TabIndex = 7;
            this.ptc_avt.TabStop = false;
            // 
            // btn_avt
            // 
            this.btn_avt.Location = new System.Drawing.Point(634, 305);
            this.btn_avt.Name = "btn_avt";
            this.btn_avt.Size = new System.Drawing.Size(115, 23);
            this.btn_avt.TabIndex = 8;
            this.btn_avt.Text = "Chọn ảnh đại diện";
            this.btn_avt.UseVisualStyleBackColor = true;
            this.btn_avt.Click += new System.EventHandler(this.btn_avt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên đăng nhập";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giới tính";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_avt);
            this.Controls.Add(this.ptc_avt);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.cb_privacy);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_repass);
            this.Controls.Add(this.tb_user);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptc_avt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_user;
        private TextBox tb_repass;
        private TextBox tb_pass;
        private TextBox tb_email;
        private ComboBox cb_gender;
        private CheckBox cb_privacy;
        private Button btn_signup;
        private PictureBox ptc_avt;
        private Button btn_avt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}