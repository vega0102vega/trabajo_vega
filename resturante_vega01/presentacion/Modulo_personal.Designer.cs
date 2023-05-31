namespace presentacion
{
    partial class Modulo_personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modulo_personal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_identificacion_personal = new System.Windows.Forms.TextBox();
            this.txt_nombre_personal = new System.Windows.Forms.TextBox();
            this.txt_contacto_personal = new System.Windows.Forms.TextBox();
            this.txt_correo_personal = new System.Windows.Forms.TextBox();
            this.bnt_actualizar = new System.Windows.Forms.PictureBox();
            this.bnt_consultar = new System.Windows.Forms.PictureBox();
            this.bnt_limpiar = new System.Windows.Forms.PictureBox();
            this.bnt_guardar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_actualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_consultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_limpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_guardar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 88);
            this.panel1.TabIndex = 0;
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(3, 3);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(25, 23);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modulo personal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ZapfHumnst Ult BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificacion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ZapfHumnst Ult BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ZapfHumnst Ult BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contacto :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ZapfHumnst Ult BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Correo :";
            // 
            // txt_identificacion_personal
            // 
            this.txt_identificacion_personal.Font = new System.Drawing.Font("ZapfHumnst Ult BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_identificacion_personal.Location = new System.Drawing.Point(166, 125);
            this.txt_identificacion_personal.Multiline = true;
            this.txt_identificacion_personal.Name = "txt_identificacion_personal";
            this.txt_identificacion_personal.Size = new System.Drawing.Size(159, 23);
            this.txt_identificacion_personal.TabIndex = 10;
            // 
            // txt_nombre_personal
            // 
            this.txt_nombre_personal.Location = new System.Drawing.Point(166, 181);
            this.txt_nombre_personal.Name = "txt_nombre_personal";
            this.txt_nombre_personal.Size = new System.Drawing.Size(159, 20);
            this.txt_nombre_personal.TabIndex = 11;
            // 
            // txt_contacto_personal
            // 
            this.txt_contacto_personal.Location = new System.Drawing.Point(166, 239);
            this.txt_contacto_personal.Name = "txt_contacto_personal";
            this.txt_contacto_personal.Size = new System.Drawing.Size(159, 20);
            this.txt_contacto_personal.TabIndex = 12;
            // 
            // txt_correo_personal
            // 
            this.txt_correo_personal.Location = new System.Drawing.Point(166, 292);
            this.txt_correo_personal.Name = "txt_correo_personal";
            this.txt_correo_personal.Size = new System.Drawing.Size(159, 20);
            this.txt_correo_personal.TabIndex = 13;
            // 
            // bnt_actualizar
            // 
            this.bnt_actualizar.Image = global::presentacion.Properties.Resources.sincronizar;
            this.bnt_actualizar.Location = new System.Drawing.Point(506, 269);
            this.bnt_actualizar.Name = "bnt_actualizar";
            this.bnt_actualizar.Size = new System.Drawing.Size(102, 86);
            this.bnt_actualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_actualizar.TabIndex = 17;
            this.bnt_actualizar.TabStop = false;
            this.bnt_actualizar.Click += new System.EventHandler(this.bnt_actualizar_Click);
            // 
            // bnt_consultar
            // 
            this.bnt_consultar.Image = global::presentacion.Properties.Resources.busqueda_de_datos;
            this.bnt_consultar.Location = new System.Drawing.Point(370, 269);
            this.bnt_consultar.Name = "bnt_consultar";
            this.bnt_consultar.Size = new System.Drawing.Size(102, 86);
            this.bnt_consultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_consultar.TabIndex = 16;
            this.bnt_consultar.TabStop = false;
            this.bnt_consultar.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bnt_limpiar
            // 
            this.bnt_limpiar.Image = global::presentacion.Properties.Resources.limpieza_de_datos1;
            this.bnt_limpiar.Location = new System.Drawing.Point(506, 156);
            this.bnt_limpiar.Name = "bnt_limpiar";
            this.bnt_limpiar.Size = new System.Drawing.Size(102, 86);
            this.bnt_limpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_limpiar.TabIndex = 15;
            this.bnt_limpiar.TabStop = false;
            this.bnt_limpiar.Click += new System.EventHandler(this.bnt_limpiar_Click);
            // 
            // bnt_guardar
            // 
            this.bnt_guardar.Image = global::presentacion.Properties.Resources.guardar_datos1;
            this.bnt_guardar.Location = new System.Drawing.Point(370, 156);
            this.bnt_guardar.Name = "bnt_guardar";
            this.bnt_guardar.Size = new System.Drawing.Size(102, 86);
            this.bnt_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_guardar.TabIndex = 14;
            this.bnt_guardar.TabStop = false;
            this.bnt_guardar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Modulo_personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 408);
            this.Controls.Add(this.bnt_actualizar);
            this.Controls.Add(this.bnt_consultar);
            this.Controls.Add(this.bnt_limpiar);
            this.Controls.Add(this.bnt_guardar);
            this.Controls.Add(this.txt_correo_personal);
            this.Controls.Add(this.txt_contacto_personal);
            this.Controls.Add(this.txt_nombre_personal);
            this.Controls.Add(this.txt_identificacion_personal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Modulo_personal";
            this.Text = "Modulo_personal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_actualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_consultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_limpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_guardar)).EndInit();
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
        private System.Windows.Forms.TextBox txt_identificacion_personal;
        private System.Windows.Forms.TextBox txt_nombre_personal;
        private System.Windows.Forms.TextBox txt_contacto_personal;
        private System.Windows.Forms.TextBox txt_correo_personal;
        private System.Windows.Forms.PictureBox bnt_guardar;
        private System.Windows.Forms.PictureBox bnt_limpiar;
        private System.Windows.Forms.PictureBox bnt_consultar;
        private System.Windows.Forms.PictureBox bnt_actualizar;
        private System.Windows.Forms.Button btn_salir;
    }
}