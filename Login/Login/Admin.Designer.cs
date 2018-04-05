namespace Login
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnInfo_users = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Informacion_Users = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.btnDesbloquear);
            this.panel1.Controls.Add(this.btnInfo_users);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 510);
            this.panel1.TabIndex = 0;
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(12, 260);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(145, 67);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            this.btnReportes.MouseLeave += new System.EventHandler(this.btnReportes_MouseLeave);
            this.btnReportes.MouseHover += new System.EventHandler(this.btnReportes_MouseHover);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.FlatAppearance.BorderSize = 0;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesbloquear.ForeColor = System.Drawing.Color.White;
            this.btnDesbloquear.Location = new System.Drawing.Point(12, 187);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(148, 67);
            this.btnDesbloquear.TabIndex = 2;
            this.btnDesbloquear.Text = "Desbloquear Users";
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            this.btnDesbloquear.MouseLeave += new System.EventHandler(this.btnDesbloquear_MouseLeave);
            this.btnDesbloquear.MouseHover += new System.EventHandler(this.btnDesbloquear_MouseHover);
            // 
            // btnInfo_users
            // 
            this.btnInfo_users.FlatAppearance.BorderSize = 0;
            this.btnInfo_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo_users.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo_users.ForeColor = System.Drawing.Color.White;
            this.btnInfo_users.Location = new System.Drawing.Point(12, 114);
            this.btnInfo_users.Name = "btnInfo_users";
            this.btnInfo_users.Size = new System.Drawing.Size(148, 67);
            this.btnInfo_users.TabIndex = 1;
            this.btnInfo_users.Text = "Info Users";
            this.btnInfo_users.UseVisualStyleBackColor = true;
            this.btnInfo_users.Click += new System.EventHandler(this.btnInfo_users_Click);
            this.btnInfo_users.MouseLeave += new System.EventHandler(this.btnInfo_users_MouseLeave);
            this.btnInfo_users.MouseHover += new System.EventHandler(this.btnInfo_users_MouseHover);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.btnRegresar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(160, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(967, 34);
            this.panel3.TabIndex = 1;
            // 
            // Informacion_Users
            // 
            this.Informacion_Users.BackColor = System.Drawing.Color.Silver;
            this.Informacion_Users.Location = new System.Drawing.Point(160, 35);
            this.Informacion_Users.Name = "Informacion_Users";
            this.Informacion_Users.Size = new System.Drawing.Size(967, 472);
            this.Informacion_Users.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(3, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 67);
            this.panel2.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(907, 0);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(60, 34);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "X";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 510);
            this.Controls.Add(this.Informacion_Users);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnInfo_users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel Informacion_Users;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegresar;
    }
}