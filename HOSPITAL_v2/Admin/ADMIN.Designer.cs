namespace HOSPITAL_v2.ADMIN
{
    partial class ADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Form = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Dashboard = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnDashBoard = new Guna.UI2.WinForms.Guna2Button();
            this.btnRequest = new Guna.UI2.WinForms.Guna2Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.btnRequest);
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 681);
            this.panel1.TabIndex = 0;
            // 
            // Form
            // 
            this.Form.Radius = 14;
            this.Form.TargetControl = this;
            // 
            // Dashboard
            // 
            this.Dashboard.Radius = 3;
            this.Dashboard.TargetControl = this.btnDashBoard;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.CheckedState.Parent = this.btnDashBoard;
            this.btnDashBoard.CustomImages.Parent = this.btnDashBoard;
            this.btnDashBoard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.btnDashBoard.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.Black;
            this.btnDashBoard.HoverState.Parent = this.btnDashBoard;
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashBoard.ImageOffset = new System.Drawing.Point(14, 0);
            this.btnDashBoard.Location = new System.Drawing.Point(12, 162);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.PressedColor = System.Drawing.Color.White;
            this.btnDashBoard.ShadowDecoration.Parent = this.btnDashBoard;
            this.btnDashBoard.Size = new System.Drawing.Size(270, 41);
            this.btnDashBoard.TabIndex = 0;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashBoard.TextOffset = new System.Drawing.Point(14, 0);
            // 
            // btnRequest
            // 
            this.btnRequest.CheckedState.Parent = this.btnRequest;
            this.btnRequest.CustomImages.Parent = this.btnRequest;
            this.btnRequest.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.btnRequest.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.ForeColor = System.Drawing.Color.Black;
            this.btnRequest.HoverState.Parent = this.btnRequest;
            this.btnRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnRequest.Image")));
            this.btnRequest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRequest.ImageOffset = new System.Drawing.Point(14, 0);
            this.btnRequest.Location = new System.Drawing.Point(12, 209);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.PressedColor = System.Drawing.Color.White;
            this.btnRequest.ShadowDecoration.Parent = this.btnRequest;
            this.btnRequest.Size = new System.Drawing.Size(270, 41);
            this.btnRequest.TabIndex = 1;
            this.btnRequest.Text = "Request";
            this.btnRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRequest.TextOffset = new System.Drawing.Point(14, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ADMIN";
            this.Text = "ADMIN";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnRequest;
        private Guna.UI2.WinForms.Guna2Button btnDashBoard;
        private Guna.UI.WinForms.GunaElipse Form;
        private Guna.UI.WinForms.GunaElipse Dashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}