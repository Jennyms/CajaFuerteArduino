namespace Login
{
    partial class CerrarCaja
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
            this.btnCerrarCuenta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCerrarCuenta
            // 
            this.btnCerrarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.btnCerrarCuenta.FlatAppearance.BorderSize = 0;
            this.btnCerrarCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.btnCerrarCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(75)))), ((int)(((byte)(61)))));
            this.btnCerrarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarCuenta.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCerrarCuenta.Location = new System.Drawing.Point(12, 330);
            this.btnCerrarCuenta.Name = "btnCerrarCuenta";
            this.btnCerrarCuenta.Size = new System.Drawing.Size(283, 82);
            this.btnCerrarCuenta.TabIndex = 0;
            this.btnCerrarCuenta.Text = "Cerrar Cuenta";
            this.btnCerrarCuenta.UseVisualStyleBackColor = false;
            this.btnCerrarCuenta.Click += new System.EventHandler(this.btnCerrarCuenta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 14);
            this.panel1.TabIndex = 1;
            // 
            // CerrarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImage = global::Login.Properties.Resources.euro;
            this.ClientSize = new System.Drawing.Size(734, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrarCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CerrarCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CerrarCaja";
            this.Load += new System.EventHandler(this.CerrarCaja_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarCuenta;
        private System.Windows.Forms.Panel panel1;
    }
}