namespace Tortuga
{
    partial class Form1
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
            this.btnLlenar = new System.Windows.Forms.Button();
            this.btnLevantarPluma = new System.Windows.Forms.Button();
            this.btnBajarPluma = new System.Windows.Forms.Button();
            this.btnGirarDerecha = new System.Windows.Forms.Button();
            this.btnGirarIzquierda = new System.Windows.Forms.Button();
            this.btnAvanza = new System.Windows.Forms.Button();
            this.txtAvanza = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnImprime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(243, 28);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(91, 23);
            this.btnLlenar.TabIndex = 0;
            this.btnLlenar.Text = "Llenar";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // btnLevantarPluma
            // 
            this.btnLevantarPluma.Location = new System.Drawing.Point(243, 57);
            this.btnLevantarPluma.Name = "btnLevantarPluma";
            this.btnLevantarPluma.Size = new System.Drawing.Size(91, 23);
            this.btnLevantarPluma.TabIndex = 1;
            this.btnLevantarPluma.Text = "Levantar pluma";
            this.btnLevantarPluma.UseVisualStyleBackColor = true;
            this.btnLevantarPluma.Click += new System.EventHandler(this.btnLevantarPluma_Click);
            // 
            // btnBajarPluma
            // 
            this.btnBajarPluma.Location = new System.Drawing.Point(349, 57);
            this.btnBajarPluma.Name = "btnBajarPluma";
            this.btnBajarPluma.Size = new System.Drawing.Size(91, 23);
            this.btnBajarPluma.TabIndex = 2;
            this.btnBajarPluma.Text = "Bajar pluma";
            this.btnBajarPluma.UseVisualStyleBackColor = true;
            this.btnBajarPluma.Click += new System.EventHandler(this.btnBajarPluma_Click);
            // 
            // btnGirarDerecha
            // 
            this.btnGirarDerecha.Location = new System.Drawing.Point(243, 86);
            this.btnGirarDerecha.Name = "btnGirarDerecha";
            this.btnGirarDerecha.Size = new System.Drawing.Size(91, 23);
            this.btnGirarDerecha.TabIndex = 3;
            this.btnGirarDerecha.Text = "Girarar derecha";
            this.btnGirarDerecha.UseVisualStyleBackColor = true;
            this.btnGirarDerecha.Click += new System.EventHandler(this.btnGirarDerecha_Click);
            // 
            // btnGirarIzquierda
            // 
            this.btnGirarIzquierda.Location = new System.Drawing.Point(349, 86);
            this.btnGirarIzquierda.Name = "btnGirarIzquierda";
            this.btnGirarIzquierda.Size = new System.Drawing.Size(91, 23);
            this.btnGirarIzquierda.TabIndex = 4;
            this.btnGirarIzquierda.Text = "Girar izquierda";
            this.btnGirarIzquierda.UseVisualStyleBackColor = true;
            this.btnGirarIzquierda.Click += new System.EventHandler(this.btnGirarIzquierda_Click);
            // 
            // btnAvanza
            // 
            this.btnAvanza.Location = new System.Drawing.Point(243, 115);
            this.btnAvanza.Name = "btnAvanza";
            this.btnAvanza.Size = new System.Drawing.Size(91, 23);
            this.btnAvanza.TabIndex = 5;
            this.btnAvanza.Text = "Avanza";
            this.btnAvanza.UseVisualStyleBackColor = true;
            this.btnAvanza.Click += new System.EventHandler(this.btnAvanza_Click);
            // 
            // txtAvanza
            // 
            this.txtAvanza.Location = new System.Drawing.Point(349, 147);
            this.txtAvanza.Name = "txtAvanza";
            this.txtAvanza.Size = new System.Drawing.Size(91, 20);
            this.txtAvanza.TabIndex = 6;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 12);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(204, 241);
            this.txtResultado.TabIndex = 7;
            // 
            // btnImprime
            // 
            this.btnImprime.Location = new System.Drawing.Point(243, 144);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(91, 23);
            this.btnImprime.TabIndex = 8;
            this.btnImprime.Text = "Imprime";
            this.btnImprime.UseVisualStyleBackColor = true;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 269);
            this.Controls.Add(this.btnImprime);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtAvanza);
            this.Controls.Add(this.btnAvanza);
            this.Controls.Add(this.btnGirarIzquierda);
            this.Controls.Add(this.btnGirarDerecha);
            this.Controls.Add(this.btnBajarPluma);
            this.Controls.Add(this.btnLevantarPluma);
            this.Controls.Add(this.btnLlenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.Button btnLevantarPluma;
        private System.Windows.Forms.Button btnBajarPluma;
        private System.Windows.Forms.Button btnGirarDerecha;
        private System.Windows.Forms.Button btnGirarIzquierda;
        private System.Windows.Forms.Button btnAvanza;
        private System.Windows.Forms.TextBox txtAvanza;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnImprime;
    }
}

