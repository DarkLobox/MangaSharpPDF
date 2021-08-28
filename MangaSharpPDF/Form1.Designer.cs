
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.cboxArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menu.SuspendLayout();
            this.panelControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cboxArchivo});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(811, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // cboxArchivo
            // 
            this.cboxArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcion1ToolStripMenuItem,
            this.opcion2ToolStripMenuItem,
            this.opcion3ToolStripMenuItem});
            this.cboxArchivo.Name = "cboxArchivo";
            this.cboxArchivo.Size = new System.Drawing.Size(60, 20);
            this.cboxArchivo.Text = "Archivo";
            this.cboxArchivo.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // opcion1ToolStripMenuItem
            // 
            this.opcion1ToolStripMenuItem.Name = "opcion1ToolStripMenuItem";
            this.opcion1ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.opcion1ToolStripMenuItem.Text = "Opcion 1";
            // 
            // opcion2ToolStripMenuItem
            // 
            this.opcion2ToolStripMenuItem.Name = "opcion2ToolStripMenuItem";
            this.opcion2ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.opcion2ToolStripMenuItem.Text = "Opcion 2";
            // 
            // opcion3ToolStripMenuItem
            // 
            this.opcion3ToolStripMenuItem.Name = "opcion3ToolStripMenuItem";
            this.opcion3ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.opcion3ToolStripMenuItem.Text = "Opcion 3";
            // 
            // panelImagenes
            // 
            this.panelImagenes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelImagenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImagenes.Location = new System.Drawing.Point(0, 24);
            this.panelImagenes.Name = "panelImagenes";
            this.panelImagenes.Size = new System.Drawing.Size(811, 387);
            this.panelImagenes.TabIndex = 1;
            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.panelControles.Location = new System.Drawing.Point(473, 24);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(338, 387);
            this.panelControles.TabIndex = 2;
            // 
            // inputCarpetaOrigen
            // 
            this.inputCarpetaOrigen.AllowDrop = true;
            this.inputCarpetaOrigen.Location = new System.Drawing.Point(17, 27);
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
            this.btnLimpiar.Location = new System.Drawing.Point(98, 127);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // prbGenerarPDF
            // 
            this.prbGenerarPDF.Location = new System.Drawing.Point(17, 296);
            this.prbGenerarPDF.Name = "prbGenerarPDF";
            this.prbGenerarPDF.Size = new System.Drawing.Size(309, 23);
            this.prbGenerarPDF.TabIndex = 10;
            // 
            // btnAgregarCarpetaOrigen
            // 
            this.btnAgregarCarpetaOrigen.Location = new System.Drawing.Point(17, 127);
            this.btnAgregarCarpetaOrigen.Name = "btnAgregarCarpetaOrigen";
            this.btnAgregarCarpetaOrigen.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCarpetaOrigen.TabIndex = 9;
            this.btnAgregarCarpetaOrigen.Text = "Agregar";
            this.btnAgregarCarpetaOrigen.UseVisualStyleBackColor = true;
            this.btnAgregarCarpetaOrigen.Click += new System.EventHandler(this.btnAgregarCarpetaOrigen_Click);
            // 
            // btnBuscarCarpetaDestino
            // 
            this.btnBuscarCarpetaDestino.Location = new System.Drawing.Point(16, 256);
            this.btnBuscarCarpetaDestino.Name = "btnBuscarCarpetaDestino";
            this.btnBuscarCarpetaDestino.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCarpetaDestino.TabIndex = 8;
            this.btnBuscarCarpetaDestino.Text = "Buscar";
            this.btnBuscarCarpetaDestino.UseVisualStyleBackColor = true;
            this.btnBuscarCarpetaDestino.Click += new System.EventHandler(this.btnBuscarCarpetaDestino_Click);
            // 
            // inputCarpetaDestino
            // 
            this.inputCarpetaDestino.AllowDrop = true;
            this.inputCarpetaDestino.Location = new System.Drawing.Point(16, 231);
            this.inputCarpetaDestino.Name = "inputCarpetaDestino";
            this.inputCarpetaDestino.Size = new System.Drawing.Size(310, 20);
            this.inputCarpetaDestino.TabIndex = 7;
            this.inputCarpetaDestino.DragDrop += new System.Windows.Forms.DragEventHandler(this.inputCarpetaDestino_DragDrop);
            this.inputCarpetaDestino.DragEnter += new System.Windows.Forms.DragEventHandler(this.inputCarpetaDestino_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Carpeta Destino";
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.Location = new System.Drawing.Point(124, 325);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(98, 23);
            this.btnGenerarPDF.TabIndex = 4;
            this.btnGenerarPDF.Text = "Generar PDF";
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de PDF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ruta de carpeta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputNombrePDF
            // 
            this.inputNombrePDF.Location = new System.Drawing.Point(16, 181);
            this.inputNombrePDF.Name = "inputNombrePDF";
            this.inputNombrePDF.Size = new System.Drawing.Size(310, 20);
            this.inputNombrePDF.TabIndex = 1;
            // 
            // MangaSharpPDF
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(811, 411);
            this.Controls.Add(this.panelControles);
            this.Controls.Add(this.panelImagenes);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(730, 450);
            this.Name = "MangaSharpPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MangaSharpPDF";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelControles.ResumeLayout(false);
            this.panelControles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Panel panelImagenes;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.TextBox inputNombrePDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarPDF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem cboxArchivo;
        private System.Windows.Forms.ToolStripMenuItem opcion1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion3ToolStripMenuItem;
        private System.Windows.Forms.TextBox inputCarpetaDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarCarpetaDestino;
        private System.Windows.Forms.Button btnAgregarCarpetaOrigen;
        private System.Windows.Forms.ProgressBar prbGenerarPDF;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox inputCarpetaOrigen;
    }
}

