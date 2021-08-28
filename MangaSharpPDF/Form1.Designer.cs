
namespace MangaSharpPDF
{
    partial class MangaSharpPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MangaSharpPDF));
            this.panelImagenes = new System.Windows.Forms.Panel();
            this.panelControles = new System.Windows.Forms.Panel();
            this.inputCarpetaOrigen = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.prbGenerarPDF = new System.Windows.Forms.ProgressBar();
            this.btnAgregarCarpetaOrigen = new System.Windows.Forms.Button();
            this.btnBuscarCarpetaDestino = new System.Windows.Forms.Button();
            this.inputCarpetaDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputNombrePDF = new System.Windows.Forms.TextBox();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelControles.SuspendLayout();
            this.panelBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImagenes
            // 
            this.panelImagenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panelImagenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImagenes.Location = new System.Drawing.Point(0, 31);
            this.panelImagenes.Name = "panelImagenes";
            this.panelImagenes.Size = new System.Drawing.Size(376, 442);
            this.panelImagenes.TabIndex = 1;
            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panelControles.Controls.Add(this.inputCarpetaOrigen);
            this.panelControles.Controls.Add(this.btnLimpiar);
            this.panelControles.Controls.Add(this.prbGenerarPDF);
            this.panelControles.Controls.Add(this.btnAgregarCarpetaOrigen);
            this.panelControles.Controls.Add(this.btnBuscarCarpetaDestino);
            this.panelControles.Controls.Add(this.inputCarpetaDestino);
            this.panelControles.Controls.Add(this.label3);
            this.panelControles.Controls.Add(this.btnGenerarPDF);
            this.panelControles.Controls.Add(this.label2);
            this.panelControles.Controls.Add(this.label1);
            this.panelControles.Controls.Add(this.inputNombrePDF);
            this.panelControles.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelControles.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControles.Location = new System.Drawing.Point(376, 31);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(338, 442);
            this.panelControles.TabIndex = 2;
            // 
            // inputCarpetaOrigen
            // 
            this.inputCarpetaOrigen.AllowDrop = true;
            this.inputCarpetaOrigen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputCarpetaOrigen.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCarpetaOrigen.Location = new System.Drawing.Point(17, 46);
            this.inputCarpetaOrigen.Multiline = true;
            this.inputCarpetaOrigen.Name = "inputCarpetaOrigen";
            this.inputCarpetaOrigen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputCarpetaOrigen.Size = new System.Drawing.Size(309, 94);
            this.inputCarpetaOrigen.TabIndex = 13;
            this.inputCarpetaOrigen.DragDrop += new System.Windows.Forms.DragEventHandler(this.inputCarpetaOrigen_DragDrop);
            this.inputCarpetaOrigen.DragEnter += new System.Windows.Forms.DragEventHandler(this.inputCarpetaOrigen_DragEnter);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.Location = new System.Drawing.Point(102, 149);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // prbGenerarPDF
            // 
            this.prbGenerarPDF.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.prbGenerarPDF.Location = new System.Drawing.Point(17, 351);
            this.prbGenerarPDF.Name = "prbGenerarPDF";
            this.prbGenerarPDF.Size = new System.Drawing.Size(309, 23);
            this.prbGenerarPDF.TabIndex = 10;
            // 
            // btnAgregarCarpetaOrigen
            // 
            this.btnAgregarCarpetaOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.btnAgregarCarpetaOrigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCarpetaOrigen.FlatAppearance.BorderSize = 0;
            this.btnAgregarCarpetaOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCarpetaOrigen.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCarpetaOrigen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarCarpetaOrigen.Location = new System.Drawing.Point(17, 149);
            this.btnAgregarCarpetaOrigen.Name = "btnAgregarCarpetaOrigen";
            this.btnAgregarCarpetaOrigen.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCarpetaOrigen.TabIndex = 9;
            this.btnAgregarCarpetaOrigen.Text = "Agregar";
            this.btnAgregarCarpetaOrigen.UseVisualStyleBackColor = false;
            this.btnAgregarCarpetaOrigen.Click += new System.EventHandler(this.btnAgregarCarpetaOrigen_Click);
            // 
            // btnBuscarCarpetaDestino
            // 
            this.btnBuscarCarpetaDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.btnBuscarCarpetaDestino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCarpetaDestino.FlatAppearance.BorderSize = 0;
            this.btnBuscarCarpetaDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCarpetaDestino.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCarpetaDestino.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarCarpetaDestino.Location = new System.Drawing.Point(16, 300);
            this.btnBuscarCarpetaDestino.Name = "btnBuscarCarpetaDestino";
            this.btnBuscarCarpetaDestino.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCarpetaDestino.TabIndex = 8;
            this.btnBuscarCarpetaDestino.Text = "Buscar";
            this.btnBuscarCarpetaDestino.UseVisualStyleBackColor = false;
            this.btnBuscarCarpetaDestino.Click += new System.EventHandler(this.btnBuscarCarpetaDestino_Click);
            // 
            // inputCarpetaDestino
            // 
            this.inputCarpetaDestino.AllowDrop = true;
            this.inputCarpetaDestino.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputCarpetaDestino.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCarpetaDestino.Location = new System.Drawing.Point(16, 271);
            this.inputCarpetaDestino.Name = "inputCarpetaDestino";
            this.inputCarpetaDestino.Size = new System.Drawing.Size(310, 21);
            this.inputCarpetaDestino.TabIndex = 7;
            this.inputCarpetaDestino.DragDrop += new System.Windows.Forms.DragEventHandler(this.inputCarpetaDestino_DragDrop);
            this.inputCarpetaDestino.DragEnter += new System.Windows.Forms.DragEventHandler(this.inputCarpetaDestino_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(14, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Carpeta Destino";
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.btnGenerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarPDF.FlatAppearance.BorderSize = 0;
            this.btnGenerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPDF.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPDF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerarPDF.Location = new System.Drawing.Point(124, 384);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(98, 23);
            this.btnGenerarPDF.TabIndex = 4;
            this.btnGenerarPDF.Text = "Generar PDF";
            this.btnGenerarPDF.UseVisualStyleBackColor = false;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de PDF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ruta de carpeta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputNombrePDF
            // 
            this.inputNombrePDF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputNombrePDF.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNombrePDF.Location = new System.Drawing.Point(16, 214);
            this.inputNombrePDF.Name = "inputNombrePDF";
            this.inputNombrePDF.Size = new System.Drawing.Size(310, 21);
            this.inputNombrePDF.TabIndex = 1;
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panelBarra.Controls.Add(this.btnRestaurar);
            this.panelBarra.Controls.Add(this.btnMaximizar);
            this.panelBarra.Controls.Add(this.btnMinimizar);
            this.panelBarra.Controls.Add(this.btnCerrar);
            this.panelBarra.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(714, 31);
            this.panelBarra.TabIndex = 3;
            this.panelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(105)))));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRestaurar.Image = global::MangaSharpPDF.Properties.Resources.menos;
            this.btnRestaurar.Location = new System.Drawing.Point(647, 4);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(32, 21);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(105)))));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaximizar.Image = global::MangaSharpPDF.Properties.Resources.maxi;
            this.btnMaximizar.Location = new System.Drawing.Point(647, 4);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 21);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(105)))));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinimizar.Image = global::MangaSharpPDF.Properties.Resources.mini;
            this.btnMinimizar.Location = new System.Drawing.Point(617, 4);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 21);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(679, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 21);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MangaSharpPDF
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(714, 473);
            this.ControlBox = false;
            this.Controls.Add(this.panelImagenes);
            this.Controls.Add(this.panelControles);
            this.Controls.Add(this.panelBarra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(730, 489);
            this.Name = "MangaSharpPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MangaSharpPDF_Load);
            this.panelControles.ResumeLayout(false);
            this.panelControles.PerformLayout();
            this.panelBarra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelImagenes;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.TextBox inputNombrePDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarPDF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputCarpetaDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarCarpetaDestino;
        private System.Windows.Forms.Button btnAgregarCarpetaOrigen;
        private System.Windows.Forms.ProgressBar prbGenerarPDF;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox inputCarpetaOrigen;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
    }
}

