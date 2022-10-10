
namespace Interfaz
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIngresarNuevoVend = new System.Windows.Forms.Label();
            this.lblMsjBienvenido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOlvidoPass = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblMsjLogin = new System.Windows.Forms.Label();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.lblIngresarNuevoVend);
            this.panel2.Controls.Add(this.lblMsjBienvenido);
            this.panel2.Location = new System.Drawing.Point(297, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 399);
            this.panel2.TabIndex = 3;
            // 
            // lblIngresarNuevoVend
            // 
            this.lblIngresarNuevoVend.AutoSize = true;
            this.lblIngresarNuevoVend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIngresarNuevoVend.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarNuevoVend.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIngresarNuevoVend.Location = new System.Drawing.Point(58, 355);
            this.lblIngresarNuevoVend.Name = "lblIngresarNuevoVend";
            this.lblIngresarNuevoVend.Size = new System.Drawing.Size(248, 22);
            this.lblIngresarNuevoVend.TabIndex = 13;
            this.lblIngresarNuevoVend.Text = "Ingresar nuevo vendedor";
            this.lblIngresarNuevoVend.Click += new System.EventHandler(this.lblIngresarNuevoVend_Click);
            // 
            // lblMsjBienvenido
            // 
            this.lblMsjBienvenido.AutoSize = true;
            this.lblMsjBienvenido.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjBienvenido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMsjBienvenido.Location = new System.Drawing.Point(136, 8);
            this.lblMsjBienvenido.Name = "lblMsjBienvenido";
            this.lblMsjBienvenido.Size = new System.Drawing.Size(107, 21);
            this.lblMsjBienvenido.TabIndex = 12;
            this.lblMsjBienvenido.Text = "Bienvenido";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblOlvidoPass);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.lblMsjLogin);
            this.panel1.Controls.Add(this.btnAlmacen);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 399);
            this.panel1.TabIndex = 2;
            // 
            // lblOlvidoPass
            // 
            this.lblOlvidoPass.AutoSize = true;
            this.lblOlvidoPass.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblOlvidoPass.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvidoPass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOlvidoPass.Location = new System.Drawing.Point(56, 355);
            this.lblOlvidoPass.Name = "lblOlvidoPass";
            this.lblOlvidoPass.Size = new System.Drawing.Size(187, 21);
            this.lblOlvidoPass.TabIndex = 13;
            this.lblOlvidoPass.Text = "Olvidó Contraseña?";
            this.lblOlvidoPass.Click += new System.EventHandler(this.lblOlvidoPass_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Teal;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEntrar.Location = new System.Drawing.Point(36, 302);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(207, 23);
            this.btnEntrar.TabIndex = 14;
            this.btnEntrar.Text = "ACCEDER";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Teal;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPassword.Location = new System.Drawing.Point(36, 250);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(188, 19);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Teal;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtUsuario.Location = new System.Drawing.Point(36, 205);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(188, 24);
            this.txtUsuario.TabIndex = 12;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lblMsjLogin
            // 
            this.lblMsjLogin.AutoSize = true;
            this.lblMsjLogin.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMsjLogin.Location = new System.Drawing.Point(103, 8);
            this.lblMsjLogin.Name = "lblMsjLogin";
            this.lblMsjLogin.Size = new System.Drawing.Size(68, 21);
            this.lblMsjLogin.TabIndex = 11;
            this.lblMsjLogin.Text = "LOGIN";
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlmacen.BackgroundImage")));
            this.btnAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlmacen.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.Location = new System.Drawing.Point(82, 53);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(101, 90);
            this.btnAlmacen.TabIndex = 9;
            this.btnAlmacen.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMsjBienvenido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblMsjLogin;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Label lblIngresarNuevoVend;
        private System.Windows.Forms.Label lblOlvidoPass;
    }
}

