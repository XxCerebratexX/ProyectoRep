namespace Lista
{
    partial class Nuevo_Video
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listaVideos = new System.Windows.Forms.ListBox();
            this.guardarCerrar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Buscar Video...";
            // 
            // listaVideos
            // 
            this.listaVideos.FormattingEnabled = true;
            this.listaVideos.Location = new System.Drawing.Point(21, 50);
            this.listaVideos.Name = "listaVideos";
            this.listaVideos.Size = new System.Drawing.Size(431, 108);
            this.listaVideos.TabIndex = 1;
            // 
            // guardarCerrar
            // 
            this.guardarCerrar.Location = new System.Drawing.Point(50, 180);
            this.guardarCerrar.Name = "guardarCerrar";
            this.guardarCerrar.Size = new System.Drawing.Size(109, 23);
            this.guardarCerrar.TabIndex = 2;
            this.guardarCerrar.Text = "Guardar y Cerrar";
            this.guardarCerrar.UseVisualStyleBackColor = true;
            this.guardarCerrar.Click += new System.EventHandler(this.guardarCerrar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(245, 180);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(121, 23);
            this.cancelar.TabIndex = 3;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // Nuevo_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 224);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.guardarCerrar);
            this.Controls.Add(this.listaVideos);
            this.Controls.Add(this.textBox1);
            this.Name = "Nuevo_Video";
            this.Text = "Nuevo Video";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listaVideos;
        private System.Windows.Forms.Button guardarCerrar;
        private System.Windows.Forms.Button cancelar;
    }
}