namespace ActividadEval2
{
    partial class Form1
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
            this.lblOper1 = new System.Windows.Forms.Label();
            this.lblOper2 = new System.Windows.Forms.Label();
            this.txtOper1 = new System.Windows.Forms.TextBox();
            this.txtOper2 = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOper1
            // 
            this.lblOper1.AutoSize = true;
            this.lblOper1.Location = new System.Drawing.Point(34, 39);
            this.lblOper1.Name = "lblOper1";
            this.lblOper1.Size = new System.Drawing.Size(61, 13);
            this.lblOper1.TabIndex = 0;
            this.lblOper1.Text = "Primer Num";
            // 
            // lblOper2
            // 
            this.lblOper2.AutoSize = true;
            this.lblOper2.Location = new System.Drawing.Point(34, 83);
            this.lblOper2.Name = "lblOper2";
            this.lblOper2.Size = new System.Drawing.Size(75, 13);
            this.lblOper2.TabIndex = 1;
            this.lblOper2.Text = "Segundo Num";
            // 
            // txtOper1
            // 
            this.txtOper1.Location = new System.Drawing.Point(137, 36);
            this.txtOper1.Name = "txtOper1";
            this.txtOper1.Size = new System.Drawing.Size(100, 20);
            this.txtOper1.TabIndex = 2;
            this.txtOper1.Text = "0";
            // 
            // txtOper2
            // 
            this.txtOper2.Location = new System.Drawing.Point(137, 76);
            this.txtOper2.Name = "txtOper2";
            this.txtOper2.Size = new System.Drawing.Size(100, 20);
            this.txtOper2.TabIndex = 3;
            this.txtOper2.Text = "0";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(301, 12);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(105, 23);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "SUMAR";
            this.btnSuma.UseVisualStyleBackColor = true;
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(301, 47);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(105, 23);
            this.btnResta.TabIndex = 5;
            this.btnResta.Text = "RESTAR";
            this.btnResta.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(301, 83);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(105, 23);
            this.btnMultiplicacion.TabIndex = 6;
            this.btnMultiplicacion.Text = "MULTIPLICACION";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(301, 115);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(105, 23);
            this.btnDivision.TabIndex = 7;
            this.btnDivision.Text = "DIVISION";
            this.btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(301, 184);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(34, 152);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(137, 145);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 10;
            this.txtResultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 229);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtOper2);
            this.Controls.Add(this.txtOper1);
            this.Controls.Add(this.lblOper2);
            this.Controls.Add(this.lblOper1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOper1;
        private System.Windows.Forms.Label lblOper2;
        private System.Windows.Forms.TextBox txtOper1;
        private System.Windows.Forms.TextBox txtOper2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
    }
}