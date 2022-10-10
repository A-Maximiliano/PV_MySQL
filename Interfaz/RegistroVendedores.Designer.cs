
namespace Interfaz
{
    partial class RegistroVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroVendedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbPregunta = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.lblResp = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblPreg = new System.Windows.Forms.Label();
            this.lblTelef = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.cmbPregunta);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtRespuesta);
            this.panel1.Controls.Add(this.lblResp);
            this.panel1.Controls.Add(this.lblDir);
            this.panel1.Controls.Add(this.lblCedula);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.lblPreg);
            this.panel1.Controls.Add(this.lblTelef);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(213, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 402);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(468, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 179;
            this.label1.Text = "Volver";
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(471, 356);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(41, 40);
            this.btnVolver.TabIndex = 178;
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbPregunta
            // 
            this.cmbPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cmbPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPregunta.ForeColor = System.Drawing.SystemColors.Menu;
            this.cmbPregunta.FormattingEnabled = true;
            this.cmbPregunta.Items.AddRange(new object[] {
            "¿Cúal es su color favorito?",
            "¿Cúal es su libro favorito?",
            "¿Cúal es su película favorita?",
            "¿Cuál es el nombre de su mascota?",
            "¿Cuál es su número de la suerte?"});
            this.cmbPregunta.Location = new System.Drawing.Point(260, 256);
            this.cmbPregunta.Name = "cmbPregunta";
            this.cmbPregunta.Size = new System.Drawing.Size(252, 26);
            this.cmbPregunta.TabIndex = 173;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Teal;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.Location = new System.Drawing.Point(168, 356);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(152, 31);
            this.btnRegistrar.TabIndex = 172;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(75, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(329, 21);
            this.label18.TabIndex = 146;
            this.label18.Text = "REGISTRO DE NUEVOS VENDEDORES";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtDireccion.Location = new System.Drawing.Point(260, 178);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(252, 24);
            this.txtDireccion.TabIndex = 171;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtRespuesta.Location = new System.Drawing.Point(260, 298);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(252, 24);
            this.txtRespuesta.TabIndex = 170;
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResp.Location = new System.Drawing.Point(14, 299);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(173, 21);
            this.lblResp.TabIndex = 169;
            this.lblResp.Text = "Respuesta secreta";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDir.Location = new System.Drawing.Point(12, 179);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(93, 21);
            this.lblDir.TabIndex = 166;
            this.lblDir.Text = "Dirección";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCedula.Location = new System.Drawing.Point(12, 67);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(136, 21);
            this.lblCedula.TabIndex = 155;
            this.lblCedula.Text = "No. de cédula";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtPassword.Location = new System.Drawing.Point(260, 219);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 24);
            this.txtPassword.TabIndex = 144;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNombre.Location = new System.Drawing.Point(260, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 24);
            this.txtNombre.TabIndex = 143;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtTelefono.Location = new System.Drawing.Point(260, 141);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(252, 24);
            this.txtTelefono.TabIndex = 142;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtCedula.Location = new System.Drawing.Point(260, 66);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(252, 24);
            this.txtCedula.TabIndex = 141;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPass.Location = new System.Drawing.Point(12, 220);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(114, 21);
            this.lblPass.TabIndex = 136;
            this.lblPass.Text = "Contraseña";
            // 
            // lblPreg
            // 
            this.lblPreg.AutoSize = true;
            this.lblPreg.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreg.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPreg.Location = new System.Drawing.Point(12, 257);
            this.lblPreg.Name = "lblPreg";
            this.lblPreg.Size = new System.Drawing.Size(211, 21);
            this.lblPreg.TabIndex = 135;
            this.lblPreg.Text = "Pregunta de seguridad";
            // 
            // lblTelef
            // 
            this.lblTelef.AutoSize = true;
            this.lblTelef.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelef.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelef.Location = new System.Drawing.Point(12, 142);
            this.lblTelef.Name = "lblTelef";
            this.lblTelef.Size = new System.Drawing.Size(149, 21);
            this.lblTelef.TabIndex = 134;
            this.lblTelef.Text = "No. de teléfono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(12, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(205, 21);
            this.lblNombre.TabIndex = 133;
            this.lblNombre.Text = "Nombre del vendedor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnAlmacen);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 399);
            this.panel2.TabIndex = 172;
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlmacen.BackgroundImage")));
            this.btnAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlmacen.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.Location = new System.Drawing.Point(47, 90);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(117, 112);
            this.btnAlmacen.TabIndex = 9;
            this.btnAlmacen.UseVisualStyleBackColor = true;
            // 
            // RegistroVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "RegistroVendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Vendedores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblPreg;
        private System.Windows.Forms.Label lblTelef;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbPregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
    }
}