namespace practica1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btneditortexto = new System.Windows.Forms.Button();
            this.btnpaint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido, elija que deseea hacer.";
            // 
            // btneditortexto
            // 
            this.btneditortexto.Location = new System.Drawing.Point(138, 115);
            this.btneditortexto.Name = "btneditortexto";
            this.btneditortexto.Size = new System.Drawing.Size(102, 23);
            this.btneditortexto.TabIndex = 1;
            this.btneditortexto.Text = "Editor de texto";
            this.btneditortexto.UseVisualStyleBackColor = true;
            this.btneditortexto.Click += new System.EventHandler(this.btneditortexto_Click);
            // 
            // btnpaint
            // 
            this.btnpaint.Location = new System.Drawing.Point(148, 165);
            this.btnpaint.Name = "btnpaint";
            this.btnpaint.Size = new System.Drawing.Size(75, 23);
            this.btnpaint.TabIndex = 2;
            this.btnpaint.Text = "Paint";
            this.btnpaint.UseVisualStyleBackColor = true;
            this.btnpaint.Click += new System.EventHandler(this.btnpaint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 420);
            this.Controls.Add(this.btnpaint);
            this.Controls.Add(this.btneditortexto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneditortexto;
        private System.Windows.Forms.Button btnpaint;
    }
}

