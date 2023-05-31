namespace presentacion
{
    partial class modulo_platos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_ingredientes = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.bnt_actualizar = new System.Windows.Forms.PictureBox();
            this.bnt_consultar = new System.Windows.Forms.PictureBox();
            this.bnt_limpiar = new System.Windows.Forms.PictureBox();
            this.bnt_guardar = new System.Windows.Forms.PictureBox();
            this.ptb_Foto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_actualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_consultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_limpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 87);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESTAURANTE PLATILLOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingredientes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(166, 115);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(180, 20);
            this.txt_Codigo.TabIndex = 7;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(166, 167);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(180, 20);
            this.txt_nombre.TabIndex = 8;
            // 
            // txt_ingredientes
            // 
            this.txt_ingredientes.Location = new System.Drawing.Point(166, 210);
            this.txt_ingredientes.Name = "txt_ingredientes";
            this.txt_ingredientes.Size = new System.Drawing.Size(180, 20);
            this.txt_ingredientes.TabIndex = 9;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(166, 265);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(180, 20);
            this.txt_valor.TabIndex = 10;
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Location = new System.Drawing.Point(166, 311);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(180, 21);
            this.cbx_tipo.TabIndex = 11;
            // 
            // cbx_estado
            // 
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Location = new System.Drawing.Point(166, 373);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(180, 21);
            this.cbx_estado.TabIndex = 12;
            // 
            // bnt_actualizar
            // 
            this.bnt_actualizar.Image = global::presentacion.Properties.Resources.flecha_de_carga;
            this.bnt_actualizar.Location = new System.Drawing.Point(603, 344);
            this.bnt_actualizar.Name = "bnt_actualizar";
            this.bnt_actualizar.Size = new System.Drawing.Size(92, 63);
            this.bnt_actualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_actualizar.TabIndex = 16;
            this.bnt_actualizar.TabStop = false;
            this.bnt_actualizar.Click += new System.EventHandler(this.bnt_actualizar_Click);
            // 
            // bnt_consultar
            // 
            this.bnt_consultar.Image = global::presentacion.Properties.Resources.consulta__1_;
            this.bnt_consultar.Location = new System.Drawing.Point(459, 344);
            this.bnt_consultar.Name = "bnt_consultar";
            this.bnt_consultar.Size = new System.Drawing.Size(86, 63);
            this.bnt_consultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_consultar.TabIndex = 15;
            this.bnt_consultar.TabStop = false;
            this.bnt_consultar.Click += new System.EventHandler(this.bnt_consultar_Click);
            // 
            // bnt_limpiar
            // 
            this.bnt_limpiar.Image = global::presentacion.Properties.Resources.limpieza_de_datos;
            this.bnt_limpiar.Location = new System.Drawing.Point(603, 249);
            this.bnt_limpiar.Name = "bnt_limpiar";
            this.bnt_limpiar.Size = new System.Drawing.Size(92, 72);
            this.bnt_limpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_limpiar.TabIndex = 14;
            this.bnt_limpiar.TabStop = false;
            this.bnt_limpiar.Click += new System.EventHandler(this.bnt_limpiar_Click);
            // 
            // bnt_guardar
            // 
            this.bnt_guardar.Image = global::presentacion.Properties.Resources.disco_flexible__1_;
            this.bnt_guardar.Location = new System.Drawing.Point(459, 249);
            this.bnt_guardar.Name = "bnt_guardar";
            this.bnt_guardar.Size = new System.Drawing.Size(86, 72);
            this.bnt_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_guardar.TabIndex = 13;
            this.bnt_guardar.TabStop = false;
            this.bnt_guardar.Click += new System.EventHandler(this.bnt_guardar_Click);
            // 
            // ptb_Foto
            // 
            this.ptb_Foto.Location = new System.Drawing.Point(529, 115);
            this.ptb_Foto.Name = "ptb_Foto";
            this.ptb_Foto.Size = new System.Drawing.Size(100, 103);
            this.ptb_Foto.TabIndex = 17;
            this.ptb_Foto.TabStop = false;
            // 
            // modulo_platos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.ptb_Foto);
            this.Controls.Add(this.bnt_actualizar);
            this.Controls.Add(this.bnt_consultar);
            this.Controls.Add(this.bnt_limpiar);
            this.Controls.Add(this.bnt_guardar);
            this.Controls.Add(this.cbx_estado);
            this.Controls.Add(this.cbx_tipo);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_ingredientes);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "modulo_platos";
            this.Text = "modulo_platos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_actualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_consultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_limpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_ingredientes;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.PictureBox bnt_guardar;
        private System.Windows.Forms.PictureBox bnt_limpiar;
        private System.Windows.Forms.PictureBox bnt_consultar;
        private System.Windows.Forms.PictureBox bnt_actualizar;
        private System.Windows.Forms.PictureBox ptb_Foto;
    }
}