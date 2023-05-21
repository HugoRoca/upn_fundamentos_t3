namespace upn_fundamentos_t3_equipo_06
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnunciadoUno = new System.Windows.Forms.Button();
            this.btnEnunciadoDos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEnunciadoUno
            // 
            this.btnEnunciadoUno.Location = new System.Drawing.Point(20, 135);
            this.btnEnunciadoUno.Name = "btnEnunciadoUno";
            this.btnEnunciadoUno.Size = new System.Drawing.Size(123, 45);
            this.btnEnunciadoUno.TabIndex = 1;
            this.btnEnunciadoUno.Text = "Enunciado 1";
            this.btnEnunciadoUno.UseVisualStyleBackColor = true;
            this.btnEnunciadoUno.Click += new System.EventHandler(this.btnEnunciadoUno_Click);
            // 
            // btnEnunciadoDos
            // 
            this.btnEnunciadoDos.Location = new System.Drawing.Point(149, 135);
            this.btnEnunciadoDos.Name = "btnEnunciadoDos";
            this.btnEnunciadoDos.Size = new System.Drawing.Size(123, 45);
            this.btnEnunciadoDos.TabIndex = 2;
            this.btnEnunciadoDos.Text = "Enunciado 2";
            this.btnEnunciadoDos.UseVisualStyleBackColor = true;
            this.btnEnunciadoDos.Click += new System.EventHandler(this.btnEnunciadoDos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 194);
            this.Controls.Add(this.btnEnunciadoDos);
            this.Controls.Add(this.btnEnunciadoUno);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnunciadoUno;
        private System.Windows.Forms.Button btnEnunciadoDos;
    }
}

