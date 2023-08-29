namespace prySaleskiPOO
{
    partial class frmMain
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFuerza = new System.Windows.Forms.TextBox();
            this.txtDestreza = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.lblDestreza = new System.Windows.Forms.Label();
            this.mrcCrear = new System.Windows.Forms.GroupBox();
            this.lblAqui = new System.Windows.Forms.Label();
            this.mrcCrear.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(163, 106);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(88, 27);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtFuerza
            // 
            this.txtFuerza.Location = new System.Drawing.Point(96, 46);
            this.txtFuerza.Name = "txtFuerza";
            this.txtFuerza.Size = new System.Drawing.Size(30, 20);
            this.txtFuerza.TabIndex = 1;
            // 
            // txtDestreza
            // 
            this.txtDestreza.Location = new System.Drawing.Point(96, 72);
            this.txtDestreza.Name = "txtDestreza";
            this.txtDestreza.Size = new System.Drawing.Size(30, 20);
            this.txtDestreza.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(42, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "nombre";
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Location = new System.Drawing.Point(6, 49);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(36, 13);
            this.lblFuerza.TabIndex = 5;
            this.lblFuerza.Text = "fuerza";
            // 
            // lblDestreza
            // 
            this.lblDestreza.AutoSize = true;
            this.lblDestreza.Location = new System.Drawing.Point(6, 75);
            this.lblDestreza.Name = "lblDestreza";
            this.lblDestreza.Size = new System.Drawing.Size(47, 13);
            this.lblDestreza.TabIndex = 6;
            this.lblDestreza.Text = "destreza";
            // 
            // mrcCrear
            // 
            this.mrcCrear.Controls.Add(this.lblNombre);
            this.mrcCrear.Controls.Add(this.btnCrear);
            this.mrcCrear.Controls.Add(this.lblDestreza);
            this.mrcCrear.Controls.Add(this.txtNombre);
            this.mrcCrear.Controls.Add(this.lblFuerza);
            this.mrcCrear.Controls.Add(this.txtFuerza);
            this.mrcCrear.Controls.Add(this.txtDestreza);
            this.mrcCrear.Location = new System.Drawing.Point(12, 12);
            this.mrcCrear.Name = "mrcCrear";
            this.mrcCrear.Size = new System.Drawing.Size(261, 151);
            this.mrcCrear.TabIndex = 7;
            this.mrcCrear.TabStop = false;
            this.mrcCrear.Text = "creador";
            // 
            // lblAqui
            // 
            this.lblAqui.AutoSize = true;
            this.lblAqui.Location = new System.Drawing.Point(30, 189);
            this.lblAqui.Name = "lblAqui";
            this.lblAqui.Size = new System.Drawing.Size(171, 13);
            this.lblAqui.TabIndex = 8;
            this.lblAqui.Text = "aqui los datos de lo que creamos...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 382);
            this.Controls.Add(this.lblAqui);
            this.Controls.Add(this.mrcCrear);
            this.Name = "frmMain";
            this.Text = "Creacion de Personajes";
            this.mrcCrear.ResumeLayout(false);
            this.mrcCrear.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.TextBox txtDestreza;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.Label lblDestreza;
        private System.Windows.Forms.GroupBox mrcCrear;
        private System.Windows.Forms.Label lblAqui;
    }
}

