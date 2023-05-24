namespace upn_fundamentos_t3_equipo_06
{
    partial class frmEnunciado2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnunciado2));
            this.lvLista = new System.Windows.Forms.ListView();
            this.txtNumeroIngresar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnOrdenarDesc = new System.Windows.Forms.Button();
            this.btnOrdenarAsc = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroEliminar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvLista
            // 
            this.lvLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLista.HideSelection = false;
            this.lvLista.Location = new System.Drawing.Point(12, 12);
            this.lvLista.Name = "lvLista";
            this.lvLista.Size = new System.Drawing.Size(196, 352);
            this.lvLista.TabIndex = 0;
            this.lvLista.UseCompatibleStateImageBehavior = false;
            this.lvLista.View = System.Windows.Forms.View.List;
            // 
            // txtNumeroIngresar
            // 
            this.txtNumeroIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroIngresar.Location = new System.Drawing.Point(132, 13);
            this.txtNumeroIngresar.Name = "txtNumeroIngresar";
            this.txtNumeroIngresar.Size = new System.Drawing.Size(72, 24);
            this.txtNumeroIngresar.TabIndex = 1;
            this.txtNumeroIngresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroIngresar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar número:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(39, 48);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(126, 37);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnOrdenarDesc
            // 
            this.btnOrdenarDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarDesc.Location = new System.Drawing.Point(39, 75);
            this.btnOrdenarDesc.Name = "btnOrdenarDesc";
            this.btnOrdenarDesc.Size = new System.Drawing.Size(126, 50);
            this.btnOrdenarDesc.TabIndex = 4;
            this.btnOrdenarDesc.Text = "Ordenar Descendente";
            this.btnOrdenarDesc.UseVisualStyleBackColor = true;
            this.btnOrdenarDesc.Click += new System.EventHandler(this.btnOrdenarDesc_Click);
            // 
            // btnOrdenarAsc
            // 
            this.btnOrdenarAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarAsc.Location = new System.Drawing.Point(39, 19);
            this.btnOrdenarAsc.Name = "btnOrdenarAsc";
            this.btnOrdenarAsc.Size = new System.Drawing.Size(126, 50);
            this.btnOrdenarAsc.TabIndex = 5;
            this.btnOrdenarAsc.Text = "Ordener Ascendente";
            this.btnOrdenarAsc.UseVisualStyleBackColor = true;
            this.btnOrdenarAsc.Click += new System.EventHandler(this.btnOrdenarAsc_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(39, 53);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 33);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumeroIngresar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(214, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Número";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOrdenarAsc);
            this.groupBox2.Controls.Add(this.btnOrdenarDesc);
            this.groupBox2.Location = new System.Drawing.Point(214, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 140);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar lista";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.txtNumeroEliminar);
            this.groupBox3.Location = new System.Drawing.Point(214, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingresar número:";
            // 
            // txtNumeroEliminar
            // 
            this.txtNumeroEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroEliminar.Location = new System.Drawing.Point(132, 19);
            this.txtNumeroEliminar.Name = "txtNumeroEliminar";
            this.txtNumeroEliminar.Size = new System.Drawing.Size(72, 24);
            this.txtNumeroEliminar.TabIndex = 4;
            this.txtNumeroEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroEliminar_KeyPress);
            // 
            // frmEnunciado2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 372);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvLista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEnunciado2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enunciado 2";
            this.Load += new System.EventHandler(this.frmEnunciado2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLista;
        private System.Windows.Forms.TextBox txtNumeroIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnOrdenarDesc;
        private System.Windows.Forms.Button btnOrdenarAsc;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroEliminar;
    }
}