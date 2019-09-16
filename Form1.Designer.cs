namespace Geometrica
{
    partial class FrmFiguras
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
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(35, 103);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 20);
            this.txtLado1.TabIndex = 0;
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado1.Location = new System.Drawing.Point(31, 52);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(72, 24);
            this.lblLado1.TabIndex = 5;
            this.lblLado1.Text = "Lado 1:";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnIngresar.Location = new System.Drawing.Point(52, 345);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(168, 44);
            this.BtnIngresar.TabIndex = 3;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.Location = new System.Drawing.Point(355, 345);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(168, 44);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado2.Location = new System.Drawing.Point(188, 52);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(72, 24);
            this.lblLado2.TabIndex = 6;
            this.lblLado2.Text = "Lado 2:";
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(192, 103);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 1;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(329, 99);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(50, 24);
            this.lblArea.TabIndex = 7;
            this.lblArea.Text = "Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "*";
            // 
            // FrmFiguras
            // 
            this.AcceptButton = this.BtnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSalir;
            this.ClientSize = new System.Drawing.Size(567, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.txtLado1);
            this.Name = "FrmFiguras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geometrica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label1;
    }
}

