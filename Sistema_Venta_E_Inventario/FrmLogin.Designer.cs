namespace Sistema_Venta_E_Inventario
{
    partial class FrmLogin
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSistemaVentaInventarioRS = new System.Windows.Forms.Label();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.lblContrasenaLogin = new System.Windows.Forms.Label();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtContrasenaLogin = new System.Windows.Forms.TextBox();
            this.btnIngresarLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogin.Location = new System.Drawing.Point(351, 150);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(72, 27);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblSistemaVentaInventarioRS
            // 
            this.lblSistemaVentaInventarioRS.AutoSize = true;
            this.lblSistemaVentaInventarioRS.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaVentaInventarioRS.Location = new System.Drawing.Point(177, 77);
            this.lblSistemaVentaInventarioRS.Name = "lblSistemaVentaInventarioRS";
            this.lblSistemaVentaInventarioRS.Size = new System.Drawing.Size(445, 33);
            this.lblSistemaVentaInventarioRS.TabIndex = 1;
            this.lblSistemaVentaInventarioRS.Text = "Sistema de venta e inventario RS";
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogin.Location = new System.Drawing.Point(222, 205);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(88, 20);
            this.lblUsuarioLogin.TabIndex = 2;
            this.lblUsuarioLogin.Text = "USUARIO:";
            // 
            // lblContrasenaLogin
            // 
            this.lblContrasenaLogin.AutoSize = true;
            this.lblContrasenaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenaLogin.Location = new System.Drawing.Point(187, 261);
            this.lblContrasenaLogin.Name = "lblContrasenaLogin";
            this.lblContrasenaLogin.Size = new System.Drawing.Size(123, 20);
            this.lblContrasenaLogin.TabIndex = 3;
            this.lblContrasenaLogin.Text = "CONTRASENA:";
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioLogin.Location = new System.Drawing.Point(316, 205);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(162, 20);
            this.txtUsuarioLogin.TabIndex = 4;
            // 
            // txtContrasenaLogin
            // 
            this.txtContrasenaLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasenaLogin.Location = new System.Drawing.Point(316, 261);
            this.txtContrasenaLogin.Name = "txtContrasenaLogin";
            this.txtContrasenaLogin.PasswordChar = '*';
            this.txtContrasenaLogin.Size = new System.Drawing.Size(162, 20);
            this.txtContrasenaLogin.TabIndex = 5;
            // 
            // btnIngresarLogin
            // 
            this.btnIngresarLogin.Location = new System.Drawing.Point(348, 315);
            this.btnIngresarLogin.Name = "btnIngresarLogin";
            this.btnIngresarLogin.Size = new System.Drawing.Size(75, 34);
            this.btnIngresarLogin.TabIndex = 6;
            this.btnIngresarLogin.Text = "Ingresar";
            this.btnIngresarLogin.UseVisualStyleBackColor = true;
            this.btnIngresarLogin.Click += new System.EventHandler(this.btnIngresarLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresarLogin);
            this.Controls.Add(this.txtContrasenaLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.lblContrasenaLogin);
            this.Controls.Add(this.lblUsuarioLogin);
            this.Controls.Add(this.lblSistemaVentaInventarioRS);
            this.Controls.Add(this.lblLogin);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSistemaVentaInventarioRS;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.Label lblContrasenaLogin;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtContrasenaLogin;
        private System.Windows.Forms.Button btnIngresarLogin;
    }
}