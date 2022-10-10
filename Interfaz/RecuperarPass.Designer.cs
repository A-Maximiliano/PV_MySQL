
namespace Interfaz
{
    partial class RecuperarPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarPass));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbPregunta = new System.Windows.Forms.ComboBox();
            this.lblCedulaPag = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.txtCedulaPag = new System.Windows.Forms.TextBox();
            this.lblApellidoPag = new System.Windows.Forms.Label();
            this.lblNombrePag = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.dgvVendedor = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.cmbPregunta);
            this.panel1.Controls.Add(this.lblCedulaPag);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtRespuesta);
            this.panel1.Controls.Add(this.txtCedulaPag);
            this.panel1.Controls.Add(this.lblApellidoPag);
            this.panel1.Controls.Add(this.lblNombrePag);
            this.panel1.Location = new System.Drawing.Point(213, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 231);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(455, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 177;
            this.label1.Text = "Volver";
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(458, 184);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(41, 40);
            this.btnVolver.TabIndex = 176;
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Teal;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.Location = new System.Drawing.Point(173, 182);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(152, 31);
            this.btnRegistrar.TabIndex = 175;
            this.btnRegistrar.Text = "RECUPERAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
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
            this.cmbPregunta.Location = new System.Drawing.Point(247, 90);
            this.cmbPregunta.Name = "cmbPregunta";
            this.cmbPregunta.Size = new System.Drawing.Size(252, 26);
            this.cmbPregunta.TabIndex = 174;
            // 
            // lblCedulaPag
            // 
            this.lblCedulaPag.AutoSize = true;
            this.lblCedulaPag.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaPag.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCedulaPag.Location = new System.Drawing.Point(17, 53);
            this.lblCedulaPag.Name = "lblCedulaPag";
            this.lblCedulaPag.Size = new System.Drawing.Size(136, 21);
            this.lblCedulaPag.TabIndex = 155;
            this.lblCedulaPag.Text = "No. de cédula";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(91, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(312, 21);
            this.label18.TabIndex = 146;
            this.label18.Text = "RECUPERACION DE CONTRASEÑA";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtRespuesta.Location = new System.Drawing.Point(247, 127);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(252, 24);
            this.txtRespuesta.TabIndex = 142;
            // 
            // txtCedulaPag
            // 
            this.txtCedulaPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCedulaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaPag.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtCedulaPag.Location = new System.Drawing.Point(247, 52);
            this.txtCedulaPag.Name = "txtCedulaPag";
            this.txtCedulaPag.Size = new System.Drawing.Size(252, 24);
            this.txtCedulaPag.TabIndex = 141;
            // 
            // lblApellidoPag
            // 
            this.lblApellidoPag.AutoSize = true;
            this.lblApellidoPag.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPag.ForeColor = System.Drawing.SystemColors.Control;
            this.lblApellidoPag.Location = new System.Drawing.Point(17, 128);
            this.lblApellidoPag.Name = "lblApellidoPag";
            this.lblApellidoPag.Size = new System.Drawing.Size(173, 21);
            this.lblApellidoPag.TabIndex = 134;
            this.lblApellidoPag.Text = "Respuesta secreta";
            // 
            // lblNombrePag
            // 
            this.lblNombrePag.AutoSize = true;
            this.lblNombrePag.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePag.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombrePag.Location = new System.Drawing.Point(17, 91);
            this.lblNombrePag.Name = "lblNombrePag";
            this.lblNombrePag.Size = new System.Drawing.Size(211, 21);
            this.lblNombrePag.TabIndex = 133;
            this.lblNombrePag.Text = "Pregunta de seguridad";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnAlmacen);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 231);
            this.panel2.TabIndex = 173;
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlmacen.BackgroundImage")));
            this.btnAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlmacen.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.Location = new System.Drawing.Point(56, 52);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(96, 94);
            this.btnAlmacen.TabIndex = 9;
            this.btnAlmacen.UseVisualStyleBackColor = true;
            // 
            // dgvVendedor
            // 
            this.dgvVendedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedor.Location = new System.Drawing.Point(1, 230);
            this.dgvVendedor.Name = "dgvVendedor";
            this.dgvVendedor.Size = new System.Drawing.Size(725, 207);
            this.dgvVendedor.TabIndex = 174;
            // 
            // RecuperarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 438);
            this.Controls.Add(this.dgvVendedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "RecuperarPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCedulaPag;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.TextBox txtCedulaPag;
        private System.Windows.Forms.Label lblApellidoPag;
        private System.Windows.Forms.Label lblNombrePag;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.ComboBox cmbPregunta;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVendedor;
    }
}