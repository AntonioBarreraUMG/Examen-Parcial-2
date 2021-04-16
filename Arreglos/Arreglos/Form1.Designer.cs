
namespace Arreglos
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
            this.buttonArreglo = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonPromedio = new System.Windows.Forms.Button();
            this.textBoxPrimero = new System.Windows.Forms.TextBox();
            this.textBoxSegundo = new System.Windows.Forms.TextBox();
            this.textBoxTercero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNotaMayor = new System.Windows.Forms.Button();
            this.buttonNotaMenor = new System.Windows.Forms.Button();
            this.buttonOrdenarNombres = new System.Windows.Forms.Button();
            this.labelAviso = new System.Windows.Forms.Label();
            this.buttonPromedioParcial = new System.Windows.Forms.Button();
            this.buttonPromedioSeccion = new System.Windows.Forms.Button();
            this.buttonPromedioGeneral = new System.Windows.Forms.Button();
            this.buttonClasificarAlumnos = new System.Windows.Forms.Button();
            this.buttonSumatoriaAlumno = new System.Windows.Forms.Button();
            this.listBoxResultado2 = new System.Windows.Forms.ListBox();
            this.textBoxParcial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxParcial2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSeccion2 = new System.Windows.Forms.TextBox();
            this.textBoxSeccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSeccion3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonArreglo
            // 
            this.buttonArreglo.Location = new System.Drawing.Point(3, 246);
            this.buttonArreglo.Name = "buttonArreglo";
            this.buttonArreglo.Size = new System.Drawing.Size(99, 23);
            this.buttonArreglo.TabIndex = 0;
            this.buttonArreglo.Text = "Arreglo";
            this.buttonArreglo.UseVisualStyleBackColor = true;
            this.buttonArreglo.Click += new System.EventHandler(this.buttonArreglo_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(108, 246);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(321, 173);
            this.listBoxResultado.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(3, 96);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(99, 23);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "Cargar Archivo";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(108, 12);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContenido.Size = new System.Drawing.Size(321, 188);
            this.textBoxContenido.TabIndex = 3;
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(3, 275);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(99, 23);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(3, 334);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(99, 23);
            this.buttonOrdenar.TabIndex = 5;
            this.buttonOrdenar.Text = "Ordenar Notas";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // buttonPromedio
            // 
            this.buttonPromedio.Enabled = false;
            this.buttonPromedio.Location = new System.Drawing.Point(16, 446);
            this.buttonPromedio.Name = "buttonPromedio";
            this.buttonPromedio.Size = new System.Drawing.Size(86, 23);
            this.buttonPromedio.TabIndex = 6;
            this.buttonPromedio.Text = "Promedio";
            this.buttonPromedio.UseVisualStyleBackColor = true;
            this.buttonPromedio.Click += new System.EventHandler(this.buttonPromedio_Click);
            // 
            // textBoxPrimero
            // 
            this.textBoxPrimero.Location = new System.Drawing.Point(128, 448);
            this.textBoxPrimero.Name = "textBoxPrimero";
            this.textBoxPrimero.Size = new System.Drawing.Size(58, 20);
            this.textBoxPrimero.TabIndex = 7;
            this.textBoxPrimero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSegundo
            // 
            this.textBoxSegundo.Location = new System.Drawing.Point(240, 448);
            this.textBoxSegundo.Name = "textBoxSegundo";
            this.textBoxSegundo.Size = new System.Drawing.Size(58, 20);
            this.textBoxSegundo.TabIndex = 8;
            this.textBoxSegundo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTercero
            // 
            this.textBoxTercero.Location = new System.Drawing.Point(351, 448);
            this.textBoxTercero.Name = "textBoxTercero";
            this.textBoxTercero.Size = new System.Drawing.Size(58, 20);
            this.textBoxTercero.TabIndex = 9;
            this.textBoxTercero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Primero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Segundo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tercero";
            // 
            // buttonNotaMayor
            // 
            this.buttonNotaMayor.Location = new System.Drawing.Point(3, 363);
            this.buttonNotaMayor.Name = "buttonNotaMayor";
            this.buttonNotaMayor.Size = new System.Drawing.Size(99, 23);
            this.buttonNotaMayor.TabIndex = 14;
            this.buttonNotaMayor.Text = "Nota Mayor";
            this.buttonNotaMayor.UseVisualStyleBackColor = true;
            this.buttonNotaMayor.Click += new System.EventHandler(this.buttonNotaMayor_Click);
            // 
            // buttonNotaMenor
            // 
            this.buttonNotaMenor.Location = new System.Drawing.Point(3, 392);
            this.buttonNotaMenor.Name = "buttonNotaMenor";
            this.buttonNotaMenor.Size = new System.Drawing.Size(99, 23);
            this.buttonNotaMenor.TabIndex = 15;
            this.buttonNotaMenor.Text = "Nota Menor";
            this.buttonNotaMenor.UseVisualStyleBackColor = true;
            this.buttonNotaMenor.Click += new System.EventHandler(this.buttonNotaMenor_Click);
            // 
            // buttonOrdenarNombres
            // 
            this.buttonOrdenarNombres.Location = new System.Drawing.Point(3, 304);
            this.buttonOrdenarNombres.Name = "buttonOrdenarNombres";
            this.buttonOrdenarNombres.Size = new System.Drawing.Size(99, 23);
            this.buttonOrdenarNombres.TabIndex = 16;
            this.buttonOrdenarNombres.Text = "Ordenar Nombres";
            this.buttonOrdenarNombres.UseVisualStyleBackColor = true;
            this.buttonOrdenarNombres.Click += new System.EventHandler(this.buttonOrdenarNombres_Click);
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Location = new System.Drawing.Point(13, 477);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(204, 13);
            this.labelAviso.TabIndex = 17;
            this.labelAviso.Text = "*Es necesario ordenar notas previamente.";
            // 
            // buttonPromedioParcial
            // 
            this.buttonPromedioParcial.Location = new System.Drawing.Point(629, 138);
            this.buttonPromedioParcial.Name = "buttonPromedioParcial";
            this.buttonPromedioParcial.Size = new System.Drawing.Size(101, 23);
            this.buttonPromedioParcial.TabIndex = 18;
            this.buttonPromedioParcial.Text = "Calcular";
            this.buttonPromedioParcial.UseVisualStyleBackColor = true;
            this.buttonPromedioParcial.Click += new System.EventHandler(this.buttonPromedioParcial_Click);
            // 
            // buttonPromedioSeccion
            // 
            this.buttonPromedioSeccion.Location = new System.Drawing.Point(629, 280);
            this.buttonPromedioSeccion.Name = "buttonPromedioSeccion";
            this.buttonPromedioSeccion.Size = new System.Drawing.Size(101, 23);
            this.buttonPromedioSeccion.TabIndex = 19;
            this.buttonPromedioSeccion.Text = "Calcular";
            this.buttonPromedioSeccion.UseVisualStyleBackColor = true;
            this.buttonPromedioSeccion.Click += new System.EventHandler(this.buttonPromedioSeccion_Click);
            // 
            // buttonPromedioGeneral
            // 
            this.buttonPromedioGeneral.Location = new System.Drawing.Point(628, 426);
            this.buttonPromedioGeneral.Name = "buttonPromedioGeneral";
            this.buttonPromedioGeneral.Size = new System.Drawing.Size(101, 23);
            this.buttonPromedioGeneral.TabIndex = 20;
            this.buttonPromedioGeneral.Text = "Calcular";
            this.buttonPromedioGeneral.UseVisualStyleBackColor = true;
            this.buttonPromedioGeneral.Click += new System.EventHandler(this.buttonPromedioGeneral_Click);
            // 
            // buttonClasificarAlumnos
            // 
            this.buttonClasificarAlumnos.Location = new System.Drawing.Point(866, 91);
            this.buttonClasificarAlumnos.Name = "buttonClasificarAlumnos";
            this.buttonClasificarAlumnos.Size = new System.Drawing.Size(101, 23);
            this.buttonClasificarAlumnos.TabIndex = 21;
            this.buttonClasificarAlumnos.Text = "Clasificar alumnos";
            this.buttonClasificarAlumnos.UseVisualStyleBackColor = true;
            this.buttonClasificarAlumnos.Click += new System.EventHandler(this.buttonClasificarAlumnos_Click);
            // 
            // buttonSumatoriaAlumno
            // 
            this.buttonSumatoriaAlumno.Location = new System.Drawing.Point(1109, 115);
            this.buttonSumatoriaAlumno.Name = "buttonSumatoriaAlumno";
            this.buttonSumatoriaAlumno.Size = new System.Drawing.Size(101, 23);
            this.buttonSumatoriaAlumno.TabIndex = 22;
            this.buttonSumatoriaAlumno.Text = "Sumatoria general por alumno";
            this.buttonSumatoriaAlumno.UseVisualStyleBackColor = true;
            this.buttonSumatoriaAlumno.Click += new System.EventHandler(this.buttonSumatoriaAlumno_Click);
            // 
            // listBoxResultado2
            // 
            this.listBoxResultado2.FormattingEnabled = true;
            this.listBoxResultado2.Location = new System.Drawing.Point(892, 155);
            this.listBoxResultado2.Name = "listBoxResultado2";
            this.listBoxResultado2.Size = new System.Drawing.Size(288, 264);
            this.listBoxResultado2.TabIndex = 23;
            // 
            // textBoxParcial
            // 
            this.textBoxParcial.Location = new System.Drawing.Point(628, 103);
            this.textBoxParcial.Name = "textBoxParcial";
            this.textBoxParcial.Size = new System.Drawing.Size(100, 20);
            this.textBoxParcial.TabIndex = 24;
            this.textBoxParcial.Text = "Número de parcial";
            this.textBoxParcial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Promedio por parcial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(554, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ingrese:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ingrese:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(606, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Promedio por sección";
            // 
            // textBoxParcial2
            // 
            this.textBoxParcial2.Location = new System.Drawing.Point(577, 249);
            this.textBoxParcial2.Name = "textBoxParcial2";
            this.textBoxParcial2.Size = new System.Drawing.Size(100, 20);
            this.textBoxParcial2.TabIndex = 27;
            this.textBoxParcial2.Text = "Número de parcial";
            this.textBoxParcial2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(554, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Ingrese:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(583, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "Promedio general por sección";
            // 
            // textBoxSeccion2
            // 
            this.textBoxSeccion2.Location = new System.Drawing.Point(628, 395);
            this.textBoxSeccion2.Name = "textBoxSeccion2";
            this.textBoxSeccion2.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeccion2.TabIndex = 30;
            this.textBoxSeccion2.Text = "Sección";
            this.textBoxSeccion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSeccion
            // 
            this.textBoxSeccion.Location = new System.Drawing.Point(683, 249);
            this.textBoxSeccion.Name = "textBoxSeccion";
            this.textBoxSeccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeccion.TabIndex = 33;
            this.textBoxSeccion.Text = "Sección";
            this.textBoxSeccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(802, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 34;
            this.label10.Text = "Ingrese:";
            // 
            // textBoxSeccion3
            // 
            this.textBoxSeccion3.Location = new System.Drawing.Point(867, 120);
            this.textBoxSeccion3.Name = "textBoxSeccion3";
            this.textBoxSeccion3.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeccion3.TabIndex = 35;
            this.textBoxSeccion3.Text = "Sección";
            this.textBoxSeccion3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(498, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(719, 423);
            this.label11.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(800, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 26);
            this.label12.TabIndex = 37;
            this.label12.Text = "Promedios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 497);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxSeccion3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxSeccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSeccion2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxParcial2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxParcial);
            this.Controls.Add(this.listBoxResultado2);
            this.Controls.Add(this.buttonSumatoriaAlumno);
            this.Controls.Add(this.buttonClasificarAlumnos);
            this.Controls.Add(this.buttonPromedioGeneral);
            this.Controls.Add(this.buttonPromedioSeccion);
            this.Controls.Add(this.buttonPromedioParcial);
            this.Controls.Add(this.labelAviso);
            this.Controls.Add(this.buttonOrdenarNombres);
            this.Controls.Add(this.buttonNotaMenor);
            this.Controls.Add(this.buttonNotaMayor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTercero);
            this.Controls.Add(this.textBoxSegundo);
            this.Controls.Add(this.textBoxPrimero);
            this.Controls.Add(this.buttonPromedio);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonArreglo);
            this.Controls.Add(this.label11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArreglo;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Button buttonPromedio;
        private System.Windows.Forms.TextBox textBoxPrimero;
        private System.Windows.Forms.TextBox textBoxSegundo;
        private System.Windows.Forms.TextBox textBoxTercero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNotaMayor;
        private System.Windows.Forms.Button buttonNotaMenor;
        private System.Windows.Forms.Button buttonOrdenarNombres;
        private System.Windows.Forms.Label labelAviso;
        private System.Windows.Forms.Button buttonPromedioParcial;
        private System.Windows.Forms.Button buttonPromedioSeccion;
        private System.Windows.Forms.Button buttonPromedioGeneral;
        private System.Windows.Forms.Button buttonClasificarAlumnos;
        private System.Windows.Forms.Button buttonSumatoriaAlumno;
        private System.Windows.Forms.ListBox listBoxResultado2;
        private System.Windows.Forms.TextBox textBoxParcial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxParcial2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSeccion2;
        private System.Windows.Forms.TextBox textBoxSeccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSeccion3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

