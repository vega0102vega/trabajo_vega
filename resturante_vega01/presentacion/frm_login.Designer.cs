namespace presentacion
{
    partial class frm_login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.ptb_foto = new System.Windows.Forms.PictureBox();
            this.bnt_salir = new System.Windows.Forms.PictureBox();
            this.bnt_registrar = new System.Windows.Forms.PictureBox();
            this.bnt_login = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_registrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_login)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 96);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso de sección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR-A BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR-A BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(167, 141);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(169, 20);
            this.txt_usuario.TabIndex = 3;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(167, 208);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(169, 20);
            this.txt_contraseña.TabIndex = 4;
            // 
            // ptb_foto
            // 
            this.ptb_foto.Image = global::presentacion.Properties.Resources.perfil;
            this.ptb_foto.Location = new System.Drawing.Point(443, 126);
            this.ptb_foto.Name = "ptb_foto";
            this.ptb_foto.Size = new System.Drawing.Size(163, 134);
            this.ptb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_foto.TabIndex = 8;
            this.ptb_foto.TabStop = false;
            // 
            // bnt_salir
            // 
            this.bnt_salir.Image = global::presentacion.Properties.Resources.boton;
            this.bnt_salir.Location = new System.Drawing.Point(316, 296);
            this.bnt_salir.Name = "bnt_salir";
            this.bnt_salir.Size = new System.Drawing.Size(100, 82);
            this.bnt_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_salir.TabIndex = 7;
            this.bnt_salir.TabStop = false;
            this.bnt_salir.Click += new System.EventHandler(this.bnt_salir_Click);
            // 
            // bnt_registrar
            // 
            this.bnt_registrar.Image = global::presentacion.Properties.Resources.nota;
            this.bnt_registrar.Location = new System.Drawing.Point(183, 296);
            this.bnt_registrar.Name = "bnt_registrar";
            this.bnt_registrar.Size = new System.Drawing.Size(100, 82);
            this.bnt_registrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_registrar.TabIndex = 6;
            this.bnt_registrar.TabStop = false;
            this.bnt_registrar.Click += new System.EventHandler(this.bnt_registrar_Click);
            // 
            // bnt_login
            // 
            this.bnt_login.Image = global::presentacion.Properties.Resources.acceso;
            this.bnt_login.Location = new System.Drawing.Point(51, 296);
            this.bnt_login.Name = "bnt_login";
            this.bnt_login.Size = new System.Drawing.Size(100, 82);
            this.bnt_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_login.TabIndex = 5;
            this.bnt_login.TabStop = false;
            this.bnt_login.Click += new System.EventHandler(this.bnt_login_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.ptb_foto);
            this.Controls.Add(this.bnt_salir);
            this.Controls.Add(this.bnt_registrar);
            this.Controls.Add(this.bnt_login);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_login";
            this.Text = "frm_login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_registrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.PictureBox bnt_login;
        private System.Windows.Forms.PictureBox bnt_registrar;
        private System.Windows.Forms.PictureBox bnt_salir;
        private System.Windows.Forms.PictureBox ptb_foto;
    }
}