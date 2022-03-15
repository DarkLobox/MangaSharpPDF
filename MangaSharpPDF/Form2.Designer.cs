
namespace MangaSharpPDF
{
    partial class FormConfiguraciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxCompresion = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inputHorizontalH = new System.Windows.Forms.TextBox();
            this.inputHorizontalW = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAplicarCambios = new System.Windows.Forms.Button();
            this.inputVerticalH = new System.Windows.Forms.TextBox();
            this.inputVerticalW = new System.Windows.Forms.TextBox();
            this.inputRutaDestinoDefecto = new System.Windows.Forms.TextBox();
            this.cboxMostrarMiniaturas = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnTamañoEstablecer = new System.Windows.Forms.RadioButton();
            this.rbtnTamañoImagenes = new System.Windows.Forms.RadioButton();
            this.rbtnTamañoNormal = new System.Windows.Forms.RadioButton();
            this.rbtnTamañoEstrecho = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.cboxCompresion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.inputHorizontalH);
            this.panel1.Controls.Add(this.inputHorizontalW);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAplicarCambios);
            this.panel1.Controls.Add(this.inputVerticalH);
            this.panel1.Controls.Add(this.inputVerticalW);
            this.panel1.Controls.Add(this.inputRutaDestinoDefecto);
            this.panel1.Controls.Add(this.cboxMostrarMiniaturas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbtnTamañoEstablecer);
            this.panel1.Controls.Add(this.rbtnTamañoImagenes);
            this.panel1.Controls.Add(this.rbtnTamañoNormal);
            this.panel1.Controls.Add(this.rbtnTamañoEstrecho);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnRestablecer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 463);
            this.panel1.TabIndex = 0;
            // 
            // cboxCompresion
            // 
            this.cboxCompresion.AutoSize = true;
            this.cboxCompresion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCompresion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cboxCompresion.Location = new System.Drawing.Point(185, 381);
            this.cboxCompresion.Name = "cboxCompresion";
            this.cboxCompresion.Size = new System.Drawing.Size(161, 19);
            this.cboxCompresion.TabIndex = 33;
            this.cboxCompresion.Text = "Compresion de Imagenes";
            this.cboxCompresion.UseVisualStyleBackColor = true;
            this.cboxCompresion.CheckedChanged += new System.EventHandler(this.cboxCompresion_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(208, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Largo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(208, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Ancho:";
            // 
            // inputHorizontalH
            // 
            this.inputHorizontalH.Enabled = false;
            this.inputHorizontalH.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputHorizontalH.Location = new System.Drawing.Point(272, 218);
            this.inputHorizontalH.Name = "inputHorizontalH";
            this.inputHorizontalH.Size = new System.Drawing.Size(51, 21);
            this.inputHorizontalH.TabIndex = 30;
            this.inputHorizontalH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumber_KeyPress);
            // 
            // inputHorizontalW
            // 
            this.inputHorizontalW.Enabled = false;
            this.inputHorizontalW.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputHorizontalW.Location = new System.Drawing.Point(272, 193);
            this.inputHorizontalW.Name = "inputHorizontalW";
            this.inputHorizontalW.Size = new System.Drawing.Size(51, 21);
            this.inputHorizontalW.TabIndex = 29;
            this.inputHorizontalW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumber_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(41, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Largo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(41, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ancho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ruta Destino:";
            // 
            // btnAplicarCambios
            // 
            this.btnAplicarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.btnAplicarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicarCambios.FlatAppearance.BorderSize = 0;
            this.btnAplicarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarCambios.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarCambios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAplicarCambios.Location = new System.Drawing.Point(49, 416);
            this.btnAplicarCambios.Name = "btnAplicarCambios";
            this.btnAplicarCambios.Size = new System.Drawing.Size(127, 23);
            this.btnAplicarCambios.TabIndex = 25;
            this.btnAplicarCambios.Text = "Aplicar Cambios";
            this.btnAplicarCambios.UseVisualStyleBackColor = false;
            this.btnAplicarCambios.Click += new System.EventHandler(this.btnAplicarCambios_Click);
            // 
            // inputVerticalH
            // 
            this.inputVerticalH.Enabled = false;
            this.inputVerticalH.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputVerticalH.Location = new System.Drawing.Point(105, 218);
            this.inputVerticalH.Name = "inputVerticalH";
            this.inputVerticalH.Size = new System.Drawing.Size(51, 21);
            this.inputVerticalH.TabIndex = 23;
            this.inputVerticalH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumber_KeyPress);
            // 
            // inputVerticalW
            // 
            this.inputVerticalW.Enabled = false;
            this.inputVerticalW.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputVerticalW.Location = new System.Drawing.Point(105, 193);
            this.inputVerticalW.Name = "inputVerticalW";
            this.inputVerticalW.Size = new System.Drawing.Size(51, 21);
            this.inputVerticalW.TabIndex = 21;
            this.inputVerticalW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumber_KeyPress);
            // 
            // inputRutaDestinoDefecto
            // 
            this.inputRutaDestinoDefecto.AllowDrop = true;
            this.inputRutaDestinoDefecto.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRutaDestinoDefecto.Location = new System.Drawing.Point(95, 350);
            this.inputRutaDestinoDefecto.Name = "inputRutaDestinoDefecto";
            this.inputRutaDestinoDefecto.ReadOnly = true;
            this.inputRutaDestinoDefecto.Size = new System.Drawing.Size(262, 21);
            this.inputRutaDestinoDefecto.TabIndex = 20;
            this.inputRutaDestinoDefecto.DragDrop += new System.Windows.Forms.DragEventHandler(this.inputRutaDestinoDefecto_DragDrop);
            this.inputRutaDestinoDefecto.DragEnter += new System.Windows.Forms.DragEventHandler(this.inputRutaDestinoDefecto_DragEnter);
            this.inputRutaDestinoDefecto.DoubleClick += new System.EventHandler(this.inputRutaDestinoDefecto_DoubleClick);
            // 
            // cboxMostrarMiniaturas
            // 
            this.cboxMostrarMiniaturas.AutoSize = true;
            this.cboxMostrarMiniaturas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMostrarMiniaturas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cboxMostrarMiniaturas.Location = new System.Drawing.Point(15, 381);
            this.cboxMostrarMiniaturas.Name = "cboxMostrarMiniaturas";
            this.cboxMostrarMiniaturas.Size = new System.Drawing.Size(124, 19);
            this.cboxMostrarMiniaturas.TabIndex = 19;
            this.cboxMostrarMiniaturas.Text = "Mostrar miniaturas";
            this.cboxMostrarMiniaturas.UseVisualStyleBackColor = true;
            this.cboxMostrarMiniaturas.CheckedChanged += new System.EventHandler(this.cboxMostrarMiniaturas_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Preferencias";
            // 
            // rbtnTamañoEstablecer
            // 
            this.rbtnTamañoEstablecer.AutoSize = true;
            this.rbtnTamañoEstablecer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTamañoEstablecer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnTamañoEstablecer.Location = new System.Drawing.Point(15, 173);
            this.rbtnTamañoEstablecer.Name = "rbtnTamañoEstablecer";
            this.rbtnTamañoEstablecer.Size = new System.Drawing.Size(126, 19);
            this.rbtnTamañoEstablecer.TabIndex = 17;
            this.rbtnTamañoEstablecer.TabStop = true;
            this.rbtnTamañoEstablecer.Text = "Establecer Tamaño";
            this.rbtnTamañoEstablecer.UseVisualStyleBackColor = true;
            this.rbtnTamañoEstablecer.CheckedChanged += new System.EventHandler(this.rbtnTamañoEstablecer_CheckedChanged);
            // 
            // rbtnTamañoImagenes
            // 
            this.rbtnTamañoImagenes.AutoSize = true;
            this.rbtnTamañoImagenes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTamañoImagenes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnTamañoImagenes.Location = new System.Drawing.Point(15, 297);
            this.rbtnTamañoImagenes.Name = "rbtnTamañoImagenes";
            this.rbtnTamañoImagenes.Size = new System.Drawing.Size(138, 19);
            this.rbtnTamañoImagenes.TabIndex = 16;
            this.rbtnTamañoImagenes.TabStop = true;
            this.rbtnTamañoImagenes.Text = "Tamaño de Imagenes";
            this.rbtnTamañoImagenes.UseVisualStyleBackColor = true;
            this.rbtnTamañoImagenes.CheckedChanged += new System.EventHandler(this.rbtnTamañoImagenes_CheckedChanged);
            // 
            // rbtnTamañoNormal
            // 
            this.rbtnTamañoNormal.AutoSize = true;
            this.rbtnTamañoNormal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTamañoNormal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnTamañoNormal.Location = new System.Drawing.Point(15, 273);
            this.rbtnTamañoNormal.Name = "rbtnTamañoNormal";
            this.rbtnTamañoNormal.Size = new System.Drawing.Size(244, 19);
            this.rbtnTamañoNormal.TabIndex = 15;
            this.rbtnTamañoNormal.TabStop = true;
            this.rbtnTamañoNormal.Text = "Vertical: 1290x1684 Horizontal: 1684x1290";
            this.rbtnTamañoNormal.UseVisualStyleBackColor = true;
            this.rbtnTamañoNormal.CheckedChanged += new System.EventHandler(this.rbtnTamañoNormal_CheckedChanged);
            // 
            // rbtnTamañoEstrecho
            // 
            this.rbtnTamañoEstrecho.AutoSize = true;
            this.rbtnTamañoEstrecho.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTamañoEstrecho.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnTamañoEstrecho.Location = new System.Drawing.Point(15, 249);
            this.rbtnTamañoEstrecho.Name = "rbtnTamañoEstrecho";
            this.rbtnTamañoEstrecho.Size = new System.Drawing.Size(238, 19);
            this.rbtnTamañoEstrecho.TabIndex = 14;
            this.rbtnTamañoEstrecho.TabStop = true;
            this.rbtnTamañoEstrecho.Text = "Vertical: 1290x1684 Horizontal: 1290x842";
            this.rbtnTamañoEstrecho.UseVisualStyleBackColor = true;
            this.rbtnTamañoEstrecho.CheckedChanged += new System.EventHandler(this.rbtnTamañoEstrecho_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tamaños de Pagina";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MangaSharpPDF.Properties.Resources.a4_h;
            this.pictureBox2.Location = new System.Drawing.Point(199, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MangaSharpPDF.Properties.Resources.a4_v;
            this.pictureBox1.Location = new System.Drawing.Point(35, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.Maroon;
            this.btnRestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestablecer.FlatAppearance.BorderSize = 0;
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRestablecer.Location = new System.Drawing.Point(199, 416);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(124, 23);
            this.btnRestablecer.TabIndex = 10;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panelBarra.Controls.Add(this.labelTitulo);
            this.panelBarra.Controls.Add(this.btnCerrar);
            this.panelBarra.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(369, 31);
            this.panelBarra.TabIndex = 4;
            this.panelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseDown);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(115, 16);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Configuraciones";
            this.labelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitulo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(105)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.Image = global::MangaSharpPDF.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(334, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 21);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 494);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormConfiguraciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox cboxMostrarMiniaturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnTamañoEstablecer;
        private System.Windows.Forms.RadioButton rbtnTamañoImagenes;
        private System.Windows.Forms.RadioButton rbtnTamañoNormal;
        private System.Windows.Forms.RadioButton rbtnTamañoEstrecho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAplicarCambios;
        private System.Windows.Forms.TextBox inputVerticalH;
        private System.Windows.Forms.TextBox inputVerticalW;
        private System.Windows.Forms.TextBox inputRutaDestinoDefecto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputHorizontalH;
        private System.Windows.Forms.TextBox inputHorizontalW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cboxCompresion;
    }
}