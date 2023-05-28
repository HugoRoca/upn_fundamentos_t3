namespace upn_fundamentos_t3_equipo_06
{
    partial class frmEnunciado1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnunciado1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDuenio = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvDuenios = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarDuenio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoDuenio = new System.Windows.Forms.Button();
            this.txtNombreDuenio = new System.Windows.Forms.TextBox();
            this.txtCodigoDuenio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccionDuenio = new System.Windows.Forms.TextBox();
            this.txtTelefonoDuenio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tpMascotas = new System.Windows.Forms.TabPage();
            this.gbListadoMascota = new System.Windows.Forms.GroupBox();
            this.lvMascotas = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscarMascota = new System.Windows.Forms.Button();
            this.txtBuscaMascota = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxDuenio = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegistrarMascota = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNuevoMascota = new System.Windows.Forms.Button();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.txtCodigoMascota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdadMascota = new System.Windows.Forms.TextBox();
            this.txtRazaMascota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpDuenio.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpMascotas.SuspendLayout();
            this.gbListadoMascota.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDuenio);
            this.tabControl1.Controls.Add(this.tpMascotas);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(452, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tpDuenio
            // 
            this.tpDuenio.Controls.Add(this.groupBox2);
            this.tpDuenio.Controls.Add(this.groupBox1);
            this.tpDuenio.Location = new System.Drawing.Point(4, 22);
            this.tpDuenio.Name = "tpDuenio";
            this.tpDuenio.Padding = new System.Windows.Forms.Padding(3);
            this.tpDuenio.Size = new System.Drawing.Size(444, 420);
            this.tpDuenio.TabIndex = 0;
            this.tpDuenio.Text = "Dueños";
            this.tpDuenio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvDuenios);
            this.groupBox2.Location = new System.Drawing.Point(8, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 267);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de dueños";
            // 
            // lvDuenios
            // 
            this.lvDuenios.HideSelection = false;
            this.lvDuenios.Location = new System.Drawing.Point(6, 19);
            this.lvDuenios.Name = "lvDuenios";
            this.lvDuenios.Size = new System.Drawing.Size(417, 242);
            this.lvDuenios.TabIndex = 0;
            this.lvDuenios.UseCompatibleStateImageBehavior = false;
            this.lvDuenios.View = System.Windows.Forms.View.List;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarDuenio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnNuevoDuenio);
            this.groupBox1.Controls.Add(this.txtNombreDuenio);
            this.groupBox1.Controls.Add(this.txtCodigoDuenio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDireccionDuenio);
            this.groupBox1.Controls.Add(this.txtTelefonoDuenio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 135);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // btnRegistrarDuenio
            // 
            this.btnRegistrarDuenio.Location = new System.Drawing.Point(332, 72);
            this.btnRegistrarDuenio.Name = "btnRegistrarDuenio";
            this.btnRegistrarDuenio.Size = new System.Drawing.Size(93, 33);
            this.btnRegistrarDuenio.TabIndex = 23;
            this.btnRegistrarDuenio.Text = "Registrar";
            this.btnRegistrarDuenio.UseVisualStyleBackColor = true;
            this.btnRegistrarDuenio.Click += new System.EventHandler(this.btnRegistrarDuenio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnNuevoDuenio
            // 
            this.btnNuevoDuenio.Location = new System.Drawing.Point(332, 33);
            this.btnNuevoDuenio.Name = "btnNuevoDuenio";
            this.btnNuevoDuenio.Size = new System.Drawing.Size(93, 33);
            this.btnNuevoDuenio.TabIndex = 0;
            this.btnNuevoDuenio.Text = "Nuevo";
            this.btnNuevoDuenio.UseVisualStyleBackColor = true;
            this.btnNuevoDuenio.Click += new System.EventHandler(this.btnNuevoDuenio_Click);
            // 
            // txtNombreDuenio
            // 
            this.txtNombreDuenio.Location = new System.Drawing.Point(98, 46);
            this.txtNombreDuenio.MaxLength = 30;
            this.txtNombreDuenio.Name = "txtNombreDuenio";
            this.txtNombreDuenio.Size = new System.Drawing.Size(228, 20);
            this.txtNombreDuenio.TabIndex = 20;
            this.txtNombreDuenio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreDuenio_KeyPress);
            // 
            // txtCodigoDuenio
            // 
            this.txtCodigoDuenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDuenio.Location = new System.Drawing.Point(98, 20);
            this.txtCodigoDuenio.Name = "txtCodigoDuenio";
            this.txtCodigoDuenio.ReadOnly = true;
            this.txtCodigoDuenio.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDuenio.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Código:";
            // 
            // txtDireccionDuenio
            // 
            this.txtDireccionDuenio.Location = new System.Drawing.Point(98, 72);
            this.txtDireccionDuenio.MaxLength = 30;
            this.txtDireccionDuenio.Name = "txtDireccionDuenio";
            this.txtDireccionDuenio.Size = new System.Drawing.Size(228, 20);
            this.txtDireccionDuenio.TabIndex = 21;
            // 
            // txtTelefonoDuenio
            // 
            this.txtTelefonoDuenio.Location = new System.Drawing.Point(98, 98);
            this.txtTelefonoDuenio.MaxLength = 9;
            this.txtTelefonoDuenio.Name = "txtTelefonoDuenio";
            this.txtTelefonoDuenio.Size = new System.Drawing.Size(228, 20);
            this.txtTelefonoDuenio.TabIndex = 22;
            this.txtTelefonoDuenio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoDuenio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teléfono:";
            // 
            // tpMascotas
            // 
            this.tpMascotas.Controls.Add(this.gbListadoMascota);
            this.tpMascotas.Controls.Add(this.groupBox4);
            this.tpMascotas.Controls.Add(this.groupBox3);
            this.tpMascotas.Location = new System.Drawing.Point(4, 22);
            this.tpMascotas.Name = "tpMascotas";
            this.tpMascotas.Padding = new System.Windows.Forms.Padding(3);
            this.tpMascotas.Size = new System.Drawing.Size(444, 420);
            this.tpMascotas.TabIndex = 1;
            this.tpMascotas.Text = "Mascotas";
            this.tpMascotas.UseVisualStyleBackColor = true;
            // 
            // gbListadoMascota
            // 
            this.gbListadoMascota.Controls.Add(this.lvMascotas);
            this.gbListadoMascota.Location = new System.Drawing.Point(6, 235);
            this.gbListadoMascota.Name = "gbListadoMascota";
            this.gbListadoMascota.Size = new System.Drawing.Size(431, 179);
            this.gbListadoMascota.TabIndex = 27;
            this.gbListadoMascota.TabStop = false;
            this.gbListadoMascota.Text = "Listado";
            // 
            // lvMascotas
            // 
            this.lvMascotas.HideSelection = false;
            this.lvMascotas.Location = new System.Drawing.Point(6, 19);
            this.lvMascotas.Name = "lvMascotas";
            this.lvMascotas.Size = new System.Drawing.Size(419, 154);
            this.lvMascotas.TabIndex = 0;
            this.lvMascotas.UseCompatibleStateImageBehavior = false;
            this.lvMascotas.View = System.Windows.Forms.View.List;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btnBuscarMascota);
            this.groupBox4.Controls.Add(this.txtBuscaMascota);
            this.groupBox4.Location = new System.Drawing.Point(6, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(431, 53);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Búsqueda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Nombre:";
            // 
            // btnBuscarMascota
            // 
            this.btnBuscarMascota.Location = new System.Drawing.Point(332, 14);
            this.btnBuscarMascota.Name = "btnBuscarMascota";
            this.btnBuscarMascota.Size = new System.Drawing.Size(93, 33);
            this.btnBuscarMascota.TabIndex = 27;
            this.btnBuscarMascota.Text = "Buscar";
            this.btnBuscarMascota.UseVisualStyleBackColor = true;
            this.btnBuscarMascota.Click += new System.EventHandler(this.btnBuscarMascota_Click);
            // 
            // txtBuscaMascota
            // 
            this.txtBuscaMascota.Location = new System.Drawing.Point(98, 19);
            this.txtBuscaMascota.MaxLength = 30;
            this.txtBuscaMascota.Name = "txtBuscaMascota";
            this.txtBuscaMascota.Size = new System.Drawing.Size(217, 20);
            this.txtBuscaMascota.TabIndex = 28;
            this.txtBuscaMascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscaMascota_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxDuenio);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnRegistrarMascota);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnNuevoMascota);
            this.groupBox3.Controls.Add(this.txtNombreMascota);
            this.groupBox3.Controls.Add(this.txtCodigoMascota);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtEdadMascota);
            this.groupBox3.Controls.Add(this.txtRazaMascota);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 164);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registro";
            // 
            // cbxDuenio
            // 
            this.cbxDuenio.FormattingEnabled = true;
            this.cbxDuenio.Location = new System.Drawing.Point(98, 124);
            this.cbxDuenio.Name = "cbxDuenio";
            this.cbxDuenio.Size = new System.Drawing.Size(217, 21);
            this.cbxDuenio.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Dueño:";
            // 
            // btnRegistrarMascota
            // 
            this.btnRegistrarMascota.Location = new System.Drawing.Point(332, 72);
            this.btnRegistrarMascota.Name = "btnRegistrarMascota";
            this.btnRegistrarMascota.Size = new System.Drawing.Size(93, 33);
            this.btnRegistrarMascota.TabIndex = 23;
            this.btnRegistrarMascota.Text = "Registrar";
            this.btnRegistrarMascota.UseVisualStyleBackColor = true;
            this.btnRegistrarMascota.Click += new System.EventHandler(this.btnRegistrarMascota_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre:";
            // 
            // btnNuevoMascota
            // 
            this.btnNuevoMascota.Location = new System.Drawing.Point(332, 33);
            this.btnNuevoMascota.Name = "btnNuevoMascota";
            this.btnNuevoMascota.Size = new System.Drawing.Size(93, 33);
            this.btnNuevoMascota.TabIndex = 0;
            this.btnNuevoMascota.Text = "Nuevo";
            this.btnNuevoMascota.UseVisualStyleBackColor = true;
            this.btnNuevoMascota.Click += new System.EventHandler(this.btnNuevoMascota_Click);
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(98, 46);
            this.txtNombreMascota.MaxLength = 30;
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(217, 20);
            this.txtNombreMascota.TabIndex = 20;
            this.txtNombreMascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMascota_KeyPress);
            // 
            // txtCodigoMascota
            // 
            this.txtCodigoMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMascota.Location = new System.Drawing.Point(98, 20);
            this.txtCodigoMascota.Name = "txtCodigoMascota";
            this.txtCodigoMascota.ReadOnly = true;
            this.txtCodigoMascota.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoMascota.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Edad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Código:";
            // 
            // txtEdadMascota
            // 
            this.txtEdadMascota.Location = new System.Drawing.Point(98, 72);
            this.txtEdadMascota.MaxLength = 10;
            this.txtEdadMascota.Name = "txtEdadMascota";
            this.txtEdadMascota.Size = new System.Drawing.Size(100, 20);
            this.txtEdadMascota.TabIndex = 21;
            this.txtEdadMascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdadMascota_KeyPress);
            // 
            // txtRazaMascota
            // 
            this.txtRazaMascota.Location = new System.Drawing.Point(98, 98);
            this.txtRazaMascota.MaxLength = 20;
            this.txtRazaMascota.Name = "txtRazaMascota";
            this.txtRazaMascota.Size = new System.Drawing.Size(100, 20);
            this.txtRazaMascota.TabIndex = 22;
            this.txtRazaMascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaMascota_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Raza:";
            // 
            // frmEnunciado1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 448);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnunciado1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enunciado 1";
            this.Load += new System.EventHandler(this.frmEnunciado1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpDuenio.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpMascotas.ResumeLayout(false);
            this.gbListadoMascota.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDuenio;
        private System.Windows.Forms.TabPage tpMascotas;
        private System.Windows.Forms.TextBox txtCodigoDuenio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefonoDuenio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccionDuenio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreDuenio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarDuenio;
        private System.Windows.Forms.Button btnNuevoDuenio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvDuenios;
        private System.Windows.Forms.GroupBox gbListadoMascota;
        private System.Windows.Forms.ListView lvMascotas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscarMascota;
        private System.Windows.Forms.TextBox txtBuscaMascota;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxDuenio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRegistrarMascota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevoMascota;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.TextBox txtCodigoMascota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEdadMascota;
        private System.Windows.Forms.TextBox txtRazaMascota;
        private System.Windows.Forms.Label label8;
    }
}