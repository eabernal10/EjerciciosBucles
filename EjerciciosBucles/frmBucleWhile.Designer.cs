namespace EjerciciosBucles
{
    partial class frmBucleWhile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTNUMERO = new System.Windows.Forms.TextBox();
            this.TXTRESULTADO = new System.Windows.Forms.TextBox();
            this.BTNCALCULAR = new System.Windows.Forms.Button();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo del factorial de un entero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa un entero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "El factorial es";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TXTNUMERO
            // 
            this.TXTNUMERO.Location = new System.Drawing.Point(632, 74);
            this.TXTNUMERO.Name = "TXTNUMERO";
            this.TXTNUMERO.Size = new System.Drawing.Size(100, 28);
            this.TXTNUMERO.TabIndex = 3;
            this.TXTNUMERO.TabStop = false;
            // 
            // TXTRESULTADO
            // 
            this.TXTRESULTADO.Location = new System.Drawing.Point(632, 135);
            this.TXTRESULTADO.Name = "TXTRESULTADO";
            this.TXTRESULTADO.ReadOnly = true;
            this.TXTRESULTADO.Size = new System.Drawing.Size(100, 28);
            this.TXTRESULTADO.TabIndex = 4;
            // 
            // BTNCALCULAR
            // 
            this.BTNCALCULAR.Location = new System.Drawing.Point(457, 195);
            this.BTNCALCULAR.Name = "BTNCALCULAR";
            this.BTNCALCULAR.Size = new System.Drawing.Size(93, 44);
            this.BTNCALCULAR.TabIndex = 5;
            this.BTNCALCULAR.Text = "CALCULAR";
            this.BTNCALCULAR.UseVisualStyleBackColor = true;
            this.BTNCALCULAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.Location = new System.Drawing.Point(584, 195);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(93, 44);
            this.BTNSALIR.TabIndex = 6;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.UseVisualStyleBackColor = true;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // frmBucleWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 588);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.BTNCALCULAR);
            this.Controls.Add(this.TXTRESULTADO);
            this.Controls.Add(this.TXTNUMERO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBucleWhile";
            this.Text = "Ejercico con Bucles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTNUMERO;
        private System.Windows.Forms.TextBox TXTRESULTADO;
        private System.Windows.Forms.Button BTNCALCULAR;
        private System.Windows.Forms.Button BTNSALIR;
    }
}