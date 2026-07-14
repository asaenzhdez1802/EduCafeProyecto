namespace EduCafeProyecto._1_login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTituloApp = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.lblO = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelSeparador = new System.Windows.Forms.Panel();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.chkMostrarContrasena = new System.Windows.Forms.CheckBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSubBienvenido = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.panelIzquierdo.Controls.Add(this.lblSubtitulo);
            this.panelIzquierdo.Controls.Add(this.lblTituloApp);
            this.panelIzquierdo.Controls.Add(this.picLogo);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(487, 700);
            this.panelIzquierdo.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.Location = new System.Drawing.Point(3, 476);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(484, 32);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "SISTEMA DE CONTROL DE VENTAS";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloApp
            // 
            this.lblTituloApp.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloApp.ForeColor = System.Drawing.Color.White;
            this.lblTituloApp.Location = new System.Drawing.Point(0, 405);
            this.lblTituloApp.Name = "lblTituloApp";
            this.lblTituloApp.Size = new System.Drawing.Size(487, 64);
            this.lblTituloApp.TabIndex = 1;
            this.lblTituloApp.Text = "Edu Café";
            this.lblTituloApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(120, 138);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(267, 246);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelDerecho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDerecho.Controls.Add(this.lblO);
            this.panelDerecho.Controls.Add(this.btnSalir);
            this.panelDerecho.Controls.Add(this.panelSeparador);
            this.panelDerecho.Controls.Add(this.btnIniciarSesion);
            this.panelDerecho.Controls.Add(this.chkMostrarContrasena);
            this.panelDerecho.Controls.Add(this.txtContrasena);
            this.panelDerecho.Controls.Add(this.lblContrasena);
            this.panelDerecho.Controls.Add(this.txtUsuario);
            this.panelDerecho.Controls.Add(this.lblUsuario);
            this.panelDerecho.Controls.Add(this.lblSubBienvenido);
            this.panelDerecho.Controls.Add(this.lblBienvenido);
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDerecho.Location = new System.Drawing.Point(487, 0);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(713, 700);
            this.panelDerecho.TabIndex = 1;
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lblO.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblO.ForeColor = System.Drawing.Color.Gray;
            this.lblO.Location = new System.Drawing.Point(350, 481);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(20, 23);
            this.lblO.TabIndex = 0;
            this.lblO.Text = "o";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(204)))), ((int)(((byte)(200)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(114, 542);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(492, 53);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // panelSeparador
            // 
            this.panelSeparador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSeparador.BackColor = System.Drawing.Color.DarkGray;
            this.panelSeparador.Location = new System.Drawing.Point(114, 494);
            this.panelSeparador.Name = "panelSeparador";
            this.panelSeparador.Size = new System.Drawing.Size(492, 2);
            this.panelSeparador.TabIndex = 8;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(33)))));
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(114, 414);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(492, 53);
            this.btnIniciarSesion.TabIndex = 7;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // chkMostrarContrasena
            // 
            this.chkMostrarContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMostrarContrasena.AutoSize = true;
            this.chkMostrarContrasena.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.chkMostrarContrasena.Location = new System.Drawing.Point(114, 361);
            this.chkMostrarContrasena.Name = "chkMostrarContrasena";
            this.chkMostrarContrasena.Size = new System.Drawing.Size(206, 28);
            this.chkMostrarContrasena.TabIndex = 6;
            this.chkMostrarContrasena.Text = "Mostrar contraseña";
            this.chkMostrarContrasena.UseVisualStyleBackColor = true;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtContrasena.Location = new System.Drawing.Point(114, 302);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(492, 39);
            this.txtContrasena.TabIndex = 5;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblContrasena
            // 
            this.lblContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.lblContrasena.Location = new System.Drawing.Point(110, 270);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(130, 30);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtUsuario.Location = new System.Drawing.Point(114, 195);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(492, 39);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.lblUsuario.Location = new System.Drawing.Point(110, 163);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(92, 28);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // lblSubBienvenido
            // 
            this.lblSubBienvenido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubBienvenido.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.lblSubBienvenido.Location = new System.Drawing.Point(2, 92);
            this.lblSubBienvenido.Name = "lblSubBienvenido";
            this.lblSubBienvenido.Size = new System.Drawing.Size(709, 32);
            this.lblSubBienvenido.TabIndex = 1;
            this.lblSubBienvenido.Text = "Iniciar sesión para continuar";
            this.lblSubBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBienvenido.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.lblBienvenido.Location = new System.Drawing.Point(0, 31);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(711, 75);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Name";
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelDerecho.ResumeLayout(false);
            this.panelDerecho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTituloApp;
        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblSubBienvenido;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.CheckBox chkMostrarContrasena;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Panel panelSeparador;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Button btnSalir;
    }
}