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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Form = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Staff = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.List = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Request = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DashBoard = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnDashBoard = new Guna.UI2.WinForms.Guna2Button();
            this.btnRequest = new Guna.UI2.WinForms.Guna2Button();
            this.btnList = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Controls.Add(this.btnRequest);
            this.panel1.Controls.Add(this.btnList);
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 722);
            this.panel1.TabIndex = 0;
            // 
            // Form
            // 
            this.Form.BorderRadius = 14;
            this.Form.TargetControl = this;
            // 
            // Staff
            // 
            this.Staff.BorderRadius = 14;
            this.Staff.TargetControl = this.btnStaff;
            // 
            // List
            // 
            this.List.BorderRadius = 14;
            this.List.TargetControl = this.btnList;
            // 
            // Request
            // 
            this.Request.BorderRadius = 14;
            this.Request.TargetControl = this.btnRequest;
            // 
            // DashBoard
            // 
            this.DashBoard.BorderRadius = 14;
            this.DashBoard.TargetControl = this.btnDashBoard;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackgroundImage = global::HOSPITAL_v2.Properties.Resources.staff;
            this.btnDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDashBoard.CheckedState.Parent = this.btnDashBoard;
            this.btnDashBoard.CustomImages.Parent = this.btnDashBoard;
            this.btnDashBoard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.btnDashBoard.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.Black;
            this.btnDashBoard.HoverState.Parent = this.btnDashBoard;
            this.btnDashBoard.Image = global::HOSPITAL_v2.Properties.Resources.dashboard;
            this.btnDashBoard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashBoard.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnDashBoard.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDashBoard.Location = new System.Drawing.Point(12, 279);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.PressedColor = System.Drawing.Color.White;
            this.btnDashBoard.ShadowDecoration.Parent = this.btnDashBoard;
            this.btnDashBoard.Size = new System.Drawing.Size(270, 45);
            this.btnDashBoard.TabIndex = 3;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashBoard.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // btnRequest
            // 
            this.btnRequest.BackgroundImage = global::HOSPITAL_v2.Properties.Resources.staff;
            this.btnRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRequest.CheckedState.Parent = this.btnRequest;
            this.btnRequest.CustomImages.Parent = this.btnRequest;
            this.btnRequest.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.btnRequest.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.ForeColor = System.Drawing.Color.Black;
            this.btnRequest.HoverState.Parent = this.btnRequest;
            this.btnRequest.Image = global::HOSPITAL_v2.Properties.Resources.check_mark;
            this.btnRequest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRequest.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnRequest.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRequest.Location = new System.Drawing.Point(12, 228);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.PressedColor = System.Drawing.Color.White;
            this.btnRequest.ShadowDecoration.Parent = this.btnRequest;
            this.btnRequest.Size = new System.Drawing.Size(270, 45);
            this.btnRequest.TabIndex = 2;
            this.btnRequest.Text = "Request";
            this.btnRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRequest.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // btnList
            // 
            this.btnList.BackgroundImage = global::HOSPITAL_v2.Properties.Resources.staff;
            this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnList.CheckedState.Parent = this.btnList;
            this.btnList.CustomImages.Parent = this.btnList;
            this.btnList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.btnList.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.Color.Black;
            this.btnList.HoverState.Parent = this.btnList;
            this.btnList.Image = global::HOSPITAL_v2.Properties.Resources.paper;
            this.btnList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnList.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnList.ImageSize = new System.Drawing.Size(25, 25);
            this.btnList.Location = new System.Drawing.Point(12, 177);
            this.btnList.Name = "btnList";
            this.btnList.PressedColor = System.Drawing.Color.White;
            this.btnList.ShadowDecoration.Parent = this.btnList;
            this.btnList.Size = new System.Drawing.Size(270, 45);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnList.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // btnStaff
            // 
            this.btnStaff.BackgroundImage = global::HOSPITAL_v2.Properties.Resources.staff;
            this.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStaff.CheckedState.Parent = this.btnStaff;
            this.btnStaff.CustomImages.Parent = this.btnStaff;
            this.btnStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.btnStaff.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.HoverState.Parent = this.btnStaff;
            this.btnStaff.Image = global::HOSPITAL_v2.Properties.Resources.staff;
            this.btnStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnStaff.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStaff.Location = new System.Drawing.Point(12, 126);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.PressedColor = System.Drawing.Color.White;
            this.btnStaff.ShadowDecoration.Parent = this.btnStaff;
            this.btnStaff.Size = new System.Drawing.Size(270, 45);
            this.btnStaff.TabIndex = 0;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADMIN";
            this.Text = "ADMIN";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Elipse Form;
        private Guna.UI2.WinForms.Guna2Elipse Staff;
        private Guna.UI2.WinForms.Guna2Button btnList;
        private Guna.UI2.WinForms.Guna2Button btnRequest;
        private Guna.UI2.WinForms.Guna2Elipse List;
        private Guna.UI2.WinForms.Guna2Button btnDashBoard;
        private Guna.UI2.WinForms.Guna2Elipse Request;
        private Guna.UI2.WinForms.Guna2Elipse DashBoard;
    }
}