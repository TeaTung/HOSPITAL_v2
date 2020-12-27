namespace HOSPITAL_v2
{
    partial class LOGIN_FORM
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
            this.components = new System.ComponentModel.Container();
            this.tbUserName = new Guna.UI.WinForms.GunaLineTextBox();
            this.tbPasswork = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbForgot = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lbSignUp = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.White;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.tbUserName.ForeColor = System.Drawing.Color.Indigo;
            this.tbUserName.LineColor = System.Drawing.Color.Gainsboro;
            this.tbUserName.Location = new System.Drawing.Point(478, 265);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.SelectedText = "";
            this.tbUserName.Size = new System.Drawing.Size(331, 44);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.Text = "Username";
            // 
            // tbPasswork
            // 
            this.tbPasswork.BackColor = System.Drawing.Color.White;
            this.tbPasswork.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPasswork.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbPasswork.Font = new System.Drawing.Font("San Francisco Text Thin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswork.ForeColor = System.Drawing.Color.Indigo;
            this.tbPasswork.LineColor = System.Drawing.Color.Gainsboro;
            this.tbPasswork.Location = new System.Drawing.Point(478, 336);
            this.tbPasswork.Name = "tbPasswork";
            this.tbPasswork.PasswordChar = '●';
            this.tbPasswork.SelectedText = "";
            this.tbPasswork.Size = new System.Drawing.Size(331, 44);
            this.tbPasswork.TabIndex = 1;
            this.tbPasswork.Text = "Password";
            // 
            // lbForgot
            // 
            this.lbForgot.AutoSize = true;
            this.lbForgot.BackColor = System.Drawing.Color.Transparent;
            this.lbForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbForgot.ForeColor = System.Drawing.Color.DarkGray;
            this.lbForgot.Location = new System.Drawing.Point(559, 409);
            this.lbForgot.Name = "lbForgot";
            this.lbForgot.Size = new System.Drawing.Size(152, 24);
            this.lbForgot.TabIndex = 2;
            this.lbForgot.Text = "Forgot Password";
            this.lbForgot.Click += new System.EventHandler(this.lbForgot_Click);
            this.lbForgot.MouseEnter += new System.EventHandler(this.lbForgot_MouseEnter);
            this.lbForgot.MouseLeave += new System.EventHandler(this.lbForgot_MouseLeave);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(192)))), ((int)(((byte)(220)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(542, 456);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(189, 45);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Login";
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lbSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbSignUp.ForeColor = System.Drawing.Color.Indigo;
            this.lbSignUp.Location = new System.Drawing.Point(595, 525);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(82, 24);
            this.lbSignUp.TabIndex = 4;
            this.lbSignUp.Text = "Sign Up ";
            this.lbSignUp.Click += new System.EventHandler(this.lbSignUp_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 14;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HOSPITAL_v2.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(1214, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LOGIN_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HOSPITAL_v2.Properties.Resources.LOGIN_FORM;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbSignUp);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lbForgot);
            this.Controls.Add(this.tbPasswork);
            this.Controls.Add(this.tbUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox tbUserName;
        private Guna.UI.WinForms.GunaLineTextBox tbPasswork;
        private System.Windows.Forms.Label lbForgot;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label lbSignUp;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

