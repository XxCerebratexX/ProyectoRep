namespace Lista
{
    partial class listasVentana
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
            this.Inicio = new System.Windows.Forms.Button();
            this.Listas = new System.Windows.Forms.Button();
            this.Videos = new System.Windows.Forms.Button();
            this.Usuarios = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Quitar = new System.Windows.Forms.Button();
            this.Bajar = new System.Windows.Forms.Button();
            this.Subir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ModificarLista = new System.Windows.Forms.Button();
            this.EliminarLista = new System.Windows.Forms.Button();
            this.videosLista = new System.Windows.Forms.ListBox();
            this.Lista = new System.Windows.Forms.ListBox();
            this.nuevaLista = new System.Windows.Forms.Button();
            this.nuevoVideo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inicio
            // 
            this.Inicio.Location = new System.Drawing.Point(0, 12);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(75, 23);
            this.Inicio.TabIndex = 0;
            this.Inicio.Text = "Inicio";
            this.Inicio.UseVisualStyleBackColor = true;
            this.Inicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // Listas
            // 
            this.Listas.Location = new System.Drawing.Point(0, 41);
            this.Listas.Name = "Listas";
            this.Listas.Size = new System.Drawing.Size(75, 23);
            this.Listas.TabIndex = 1;
            this.Listas.Text = "Listas";
            this.Listas.UseVisualStyleBackColor = true;
            // 
            // Videos
            // 
            this.Videos.Location = new System.Drawing.Point(0, 70);
            this.Videos.Name = "Videos";
            this.Videos.Size = new System.Drawing.Size(75, 23);
            this.Videos.TabIndex = 2;
            this.Videos.Text = "Videos";
            this.Videos.UseVisualStyleBackColor = true;
            // 
            // Usuarios
            // 
            this.Usuarios.Location = new System.Drawing.Point(0, 99);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(75, 23);
            this.Usuarios.TabIndex = 3;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.videosLista);
            this.groupBox1.Controls.Add(this.Lista);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(81, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 446);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nuevoVideo);
            this.panel2.Controls.Add(this.Quitar);
            this.panel2.Controls.Add(this.Bajar);
            this.panel2.Controls.Add(this.Subir);
            this.panel2.Location = new System.Drawing.Point(225, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 143);
            this.panel2.TabIndex = 3;
            // 
            // Quitar
            // 
            this.Quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitar.Location = new System.Drawing.Point(13, 109);
            this.Quitar.Name = "Quitar";
            this.Quitar.Size = new System.Drawing.Size(75, 23);
            this.Quitar.TabIndex = 2;
            this.Quitar.Text = "Quitar";
            this.Quitar.UseVisualStyleBackColor = true;
            // 
            // Bajar
            // 
            this.Bajar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bajar.Location = new System.Drawing.Point(13, 80);
            this.Bajar.Name = "Bajar";
            this.Bajar.Size = new System.Drawing.Size(75, 23);
            this.Bajar.TabIndex = 1;
            this.Bajar.Text = "Bajar";
            this.Bajar.UseVisualStyleBackColor = true;
            // 
            // Subir
            // 
            this.Subir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subir.Location = new System.Drawing.Point(13, 51);
            this.Subir.Name = "Subir";
            this.Subir.Size = new System.Drawing.Size(75, 23);
            this.Subir.TabIndex = 0;
            this.Subir.Text = "Subir";
            this.Subir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nuevaLista);
            this.panel1.Controls.Add(this.ModificarLista);
            this.panel1.Controls.Add(this.EliminarLista);
            this.panel1.Location = new System.Drawing.Point(162, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 143);
            this.panel1.TabIndex = 2;
            // 
            // ModificarLista
            // 
            this.ModificarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarLista.Location = new System.Drawing.Point(12, 72);
            this.ModificarLista.Name = "ModificarLista";
            this.ModificarLista.Size = new System.Drawing.Size(75, 23);
            this.ModificarLista.TabIndex = 1;
            this.ModificarLista.Text = "Modificar";
            this.ModificarLista.UseVisualStyleBackColor = true;
            // 
            // EliminarLista
            // 
            this.EliminarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarLista.Location = new System.Drawing.Point(12, 43);
            this.EliminarLista.Name = "EliminarLista";
            this.EliminarLista.Size = new System.Drawing.Size(75, 23);
            this.EliminarLista.TabIndex = 0;
            this.EliminarLista.Text = "Eliminar";
            this.EliminarLista.UseVisualStyleBackColor = true;
            // 
            // videosLista
            // 
            this.videosLista.FormattingEnabled = true;
            this.videosLista.ItemHeight = 20;
            this.videosLista.Location = new System.Drawing.Point(13, 196);
            this.videosLista.Name = "videosLista";
            this.videosLista.Size = new System.Drawing.Size(206, 144);
            this.videosLista.TabIndex = 1;
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 20;
            this.Lista.Location = new System.Drawing.Point(7, 29);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(146, 144);
            this.Lista.TabIndex = 0;
            // 
            // nuevaLista
            // 
            this.nuevaLista.FlatAppearance.BorderSize = 2;
            this.nuevaLista.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nuevaLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaLista.Location = new System.Drawing.Point(38, 13);
            this.nuevaLista.Name = "nuevaLista";
            this.nuevaLista.Size = new System.Drawing.Size(24, 24);
            this.nuevaLista.TabIndex = 2;
            this.nuevaLista.Text = "+";
            this.nuevaLista.UseVisualStyleBackColor = true;
            this.nuevaLista.Click += new System.EventHandler(this.button1_Click);
            // 
            // nuevoVideo
            // 
            this.nuevoVideo.FlatAppearance.BorderSize = 2;
            this.nuevoVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoVideo.Location = new System.Drawing.Point(34, 22);
            this.nuevoVideo.Name = "nuevoVideo";
            this.nuevoVideo.Size = new System.Drawing.Size(23, 23);
            this.nuevoVideo.TabIndex = 3;
            this.nuevoVideo.Text = "+";
            this.nuevoVideo.UseVisualStyleBackColor = true;
            this.nuevoVideo.Click += new System.EventHandler(this.nuevoVideo_Click);
            // 
            // listasVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Usuarios);
            this.Controls.Add(this.Videos);
            this.Controls.Add(this.Listas);
            this.Controls.Add(this.Inicio);
            this.Name = "listasVentana";
            this.Text = "Listas";
            this.Load += new System.EventHandler(this.listasVentana_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Button Listas;
        private System.Windows.Forms.Button Videos;
        private System.Windows.Forms.Button Usuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Quitar;
        private System.Windows.Forms.Button Bajar;
        private System.Windows.Forms.Button Subir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ModificarLista;
        private System.Windows.Forms.Button EliminarLista;
        private System.Windows.Forms.ListBox videosLista;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button nuevoVideo;
        private System.Windows.Forms.Button nuevaLista;
    }
}

