namespace ProjectAAA
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnPatientInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicalRecords = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlButton = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 11;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.pnlMain;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.gunaLineTextBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMain.Location = new System.Drawing.Point(298, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
            this.pnlMain.Size = new System.Drawing.Size(966, 678);
            this.pnlMain.TabIndex = 5;
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.White;
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Bold);
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(22, 29);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.ReadOnly = true;
            this.gunaLineTextBox1.SelectedText = "";
            this.gunaLineTextBox1.Size = new System.Drawing.Size(917, 60);
            this.gunaLineTextBox1.TabIndex = 0;
            this.gunaLineTextBox1.Text = "Dashboard";
            // 
            // btnPatientInfo
            // 
            this.btnPatientInfo.BorderRadius = 4;
            this.btnPatientInfo.CheckedState.Parent = this.btnPatientInfo;
            this.btnPatientInfo.CustomImages.Parent = this.btnPatientInfo;
            this.btnPatientInfo.FillColor = System.Drawing.Color.White;
            this.btnPatientInfo.Font = new System.Drawing.Font("Consolas", 17F);
            this.btnPatientInfo.ForeColor = System.Drawing.Color.Gray;
            this.btnPatientInfo.HoverState.Parent = this.btnPatientInfo;
            this.btnPatientInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPatientInfo.Location = new System.Drawing.Point(18, 176);
            this.btnPatientInfo.Name = "btnPatientInfo";
            this.btnPatientInfo.ShadowDecoration.Parent = this.btnPatientInfo;
            this.btnPatientInfo.Size = new System.Drawing.Size(265, 57);
            this.btnPatientInfo.TabIndex = 0;
            this.btnPatientInfo.Text = "Patient infomation";
            this.btnPatientInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPatientInfo.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // btnMedicalRecords
            // 
            this.btnMedicalRecords.BackColor = System.Drawing.Color.White;
            this.btnMedicalRecords.BorderRadius = 4;
            this.btnMedicalRecords.CheckedState.Parent = this.btnMedicalRecords;
            this.btnMedicalRecords.CustomImages.Parent = this.btnMedicalRecords;
            this.btnMedicalRecords.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.btnMedicalRecords.Font = new System.Drawing.Font("Consolas", 17F);
            this.btnMedicalRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.btnMedicalRecords.HoverState.Parent = this.btnMedicalRecords;
            this.btnMedicalRecords.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMedicalRecords.Location = new System.Drawing.Point(18, 237);
            this.btnMedicalRecords.Name = "btnMedicalRecords";
            this.btnMedicalRecords.ShadowDecoration.Parent = this.btnMedicalRecords;
            this.btnMedicalRecords.Size = new System.Drawing.Size(265, 57);
            this.btnMedicalRecords.TabIndex = 1;
            this.btnMedicalRecords.Text = "Medical records";
            this.btnMedicalRecords.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 4;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Consolas", 17F);
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Location = new System.Drawing.Point(18, 298);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(265, 57);
            this.guna2Button3.TabIndex = 2;
            this.guna2Button3.Text = "Treatment";
            this.guna2Button3.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 4;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Consolas", 17F);
            this.guna2Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.Location = new System.Drawing.Point(18, 359);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(265, 57);
            this.guna2Button4.TabIndex = 3;
            this.guna2Button4.Text = "Take medicine";
            this.guna2Button4.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderRadius = 4;
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Consolas", 17F);
            this.guna2Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(154)))), ((int)(((byte)(166)))));
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.Location = new System.Drawing.Point(18, 420);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(265, 57);
            this.guna2Button5.TabIndex = 4;
            this.guna2Button5.Text = "Set appointment";
            this.guna2Button5.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Gray;
            this.pnlButton.BorderRadius = 4;
            this.pnlButton.Location = new System.Drawing.Point(20, 227);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.ShadowDecoration.Parent = this.pnlButton;
            this.pnlButton.Size = new System.Drawing.Size(263, 5);
            this.pnlButton.TabIndex = 1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 1;
            this.guna2Elipse2.TargetControl = this.pnlButton;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1264, 678);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.btnMedicalRecords);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.btnPatientInfo);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Button btnPatientInfo;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnMedicalRecords;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Panel pnlButton;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
    }
}

