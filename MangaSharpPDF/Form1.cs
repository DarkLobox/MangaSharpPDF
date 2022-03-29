using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Runtime.InteropServices;
using System.Configuration;

namespace MangaSharpPDF
{
    public partial class MangaSharpPDF : Form
    {
        //Configuraciones
        static AppSettingsReader lector = new AppSettingsReader();
        static int vw = (int)lector.GetValue("verticalWidth", typeof(int));
        static int vh = (int)lector.GetValue("verticalHeight", typeof(int));
        static int hw = (int)lector.GetValue("horizontalWidth", typeof(int));
        static int hh = (int)lector.GetValue("horizontalHeight", typeof(int));
        static int formato = (int)lector.GetValue("formatoPagina", typeof(int));
        static string ruta = (string)lector.GetValue("rutaDestinoDefecto", typeof(string));
        static bool miniaturas = (bool)lector.GetValue("mostrarMiniaturas", typeof(bool));
        static bool compresion = (bool)lector.GetValue("compresionImagenes", typeof(bool));

        static Rectangle vertical = new Rectangle(vw, vh);
        static Rectangle horizontal = new Rectangle(hw, hh);

        //Procesamiento de minuaturas
        PictureBox[] boxImagenes = new PictureBox[0];
        string[] imagenes = new string[0];
        static System.Drawing.Bitmap[] mapas = new System.Drawing.Bitmap[0];
        static System.Drawing.Graphics g;

        //Formato de imagenes permitidos
        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };

        //Movimiento de ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public MangaSharpPDF()
        {
            InitializeComponent();
            inputCarpetaDestino.Text = ruta;
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            if (inputCarpetaOrigen.Text.Equals("") == false && inputCarpetaDestino.Text.Equals("") == false && inputNombrePDF.Text.Equals("") == false)
            {
                generarPDF(inputCarpetaOrigen.Text, inputCarpetaDestino.Text, inputNombrePDF.Text);
            }
        }

        private void btnBuscarCarpetaDestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                inputCarpetaDestino.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnAgregarCarpetaOrigen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath) && inputCarpetaOrigen.Text.IndexOf(folderBrowser.SelectedPath) == -1)
            {
                inputCarpetaOrigen.Text += folderBrowser.SelectedPath + "\r\n";
                if (inputNombrePDF.Text.CompareTo("")==0)
                {
                    inputNombrePDF.Text = folderBrowser.SelectedPath.Substring(folderBrowser.SelectedPath.LastIndexOf("\\") + 1);
                }
            }
            procesarRutas();
            mostrarMiniaturas();
        }

        void generarPDF(string origen, string destino, string nombre)
        {
            //Variables
            Image image;
            System.Drawing.Image imageOriginal;
            prbGenerarPDF.Value = 0; //reset barra de progreso

            //Creacion de doc sin tamaño de pagina definido
            Document doc = new Document();
            //Creacion del archivo pdf
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(destino + "\\" + nombre + ".pdf", FileMode.Create));

            //Establecer margenes
            doc.SetMargins(0, 0, 0, 0);

            //Establecer dimension primera pagina
            image = Image.GetInstance(imagenes[0]);
            //EstablecerDimensiones(doc, image);

            // Abrir pdf
            doc.Open();

            //Escribir contenido del pdf
            for (int i = 0; i < imagenes.Length; i++)
            {
                //Formatos permitidos
                if (ImageExtensions.Contains(Path.GetExtension(imagenes[i]).ToUpperInvariant()))
                {
                    image = Image.GetInstance(imagenes[i]);
                    imageOriginal = System.Drawing.Image.FromFile(imagenes[i]);
                    EstablecerDimensionesPre(doc, image, imageOriginal, i);
                    image = Image.GetInstance(imagenes[i]);
                    EstablecerDimensionesPost(image);
                    doc.NewPage();
                    doc.Add(image);
                    prbGenerarPDF.Value = ((i + 1) * 100) / imagenes.Length;
                }
            }

            //Borrado de residuos
            for (int i = 0; i < imagenes.Length; i++)
            {
                //Formatos permitidos
                if (imagenes[i].IndexOf("resize")!=-1)
                {
                    File.Delete(imagenes[i]);
                    
                }
            }

            //Cerrar pdf
            doc.Close();
            writer.Close();

            inputCarpetaOrigen.Text = "";
            inputNombrePDF.Text = "";
            limpiarMiniaturas();
        }

        void EstablecerDimensionesPre(Document doc, Image image, System.Drawing.Image imagenOriginal, int ruta)
        {
            if (formato == 4)
            {
                vertical = new Rectangle(image.Width, image.Height);
                doc.SetPageSize(vertical);
            }
            else
            {
                if (image.Height > image.Width)
                {
                    doc.SetPageSize(vertical);
                    if (compresion)
                    {
                        FileInfo pesoInicial, pesoFinal;
                        pesoInicial = new FileInfo(imagenes[ruta]);

                        imagenOriginal = Resize(imagenOriginal, (int)vertical.Width, (int)vertical.Height);
                        String rutaTemporal = imagenes[ruta].Substring(0, imagenes[ruta].LastIndexOf("\\")) + "\\resize.jpg";
                        imagenOriginal.Save(rutaTemporal);
                        pesoFinal = new FileInfo(rutaTemporal);
                        if (pesoFinal.Length < pesoInicial.Length)
                        {
                            imagenes[ruta] = rutaTemporal;
                        }
                        
                    }
                }
                if (image.Width >= image.Height)
                {
                    doc.SetPageSize(horizontal);
                    if (compresion)
                    {
                        FileInfo pesoInicial, pesoFinal;
                        pesoInicial = new FileInfo(imagenes[ruta]);

                        imagenOriginal = Resize(imagenOriginal,(int)horizontal.Width,(int)horizontal.Height);
                        String rutaTemporal = imagenes[ruta].Substring(0, imagenes[ruta].LastIndexOf("\\")) + "\\resize.jpg";
                        imagenOriginal.Save(rutaTemporal);
                        pesoFinal = new FileInfo(rutaTemporal);
                        if (pesoFinal.Length < pesoInicial.Length)
                        {
                            imagenes[ruta] = rutaTemporal;
                        }
                    }
                }
            }
        }

        void EstablecerDimensionesPost(Image image)
        {
            if (formato == 4)
            {
                
            }
            else
            {
                if (image.Height > image.Width)
                {
                    image.ScaleAbsoluteWidth(vertical.Width);
                    image.ScaleAbsoluteHeight(vertical.Height);
                }
                if (image.Width >= image.Height)
                {
                    image.ScaleAbsoluteWidth(horizontal.Width);
                    image.ScaleAbsoluteHeight(horizontal.Height);
                }
            }
        }

        System.Drawing.Image Resize(System.Drawing.Image image, int w, int h)
        {
            double factorCompresion = 1.7;
            double nw = w/factorCompresion;
            double nh = h/factorCompresion;

            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap((int)nw, (int)nh);
            System.Drawing.Graphics graphic = System.Drawing.Graphics.FromImage(bmp);
            graphic.DrawImage(image, 0, 0, (int)nw, (int)nh);
            graphic.Dispose();

            return bmp;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            inputCarpetaOrigen.Text = "";
            inputNombrePDF.Text = "";
            limpiarMiniaturas();
            
        }

        private void inputCarpetaOrigen_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void inputCarpetaOrigen_DragDrop(object sender, DragEventArgs e)
        {
            string[] carpetas = (String[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i=0;i<carpetas.Length;i++)
            {
                FileAttributes dir = File.GetAttributes(carpetas[i]);
                if (dir.HasFlag(FileAttributes.Directory) && inputCarpetaOrigen.Text.IndexOf(carpetas[i])==-1) //Es un directorio y filtra duplicados
                {
                    inputCarpetaOrigen.Text += carpetas[i] + "\r\n";
                    if (inputNombrePDF.Text.CompareTo("") == 0)
                    {
                        inputNombrePDF.Text = carpetas[i].Substring(carpetas[i].LastIndexOf("\\") + 1);
                    }
                }
            }
            procesarRutas();
            mostrarMiniaturas();
        }

        private void inputCarpetaDestino_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void inputCarpetaDestino_DragDrop(object sender, DragEventArgs e)
        {
            string[] carpetas = (String[])e.Data.GetData(DataFormats.FileDrop, false);
            inputCarpetaDestino.Text = carpetas[0];
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void procesarRutas()
        {
            //Reinicio de rutas de imagenes
            imagenes = new string[0];
            //Copia de las rutas
            string origenTemp = inputCarpetaOrigen.Text; 

            while (origenTemp.IndexOf("\r\n") != -1)
            {
                string rutaTemp = origenTemp.Substring(0, origenTemp.IndexOf("\r\n"));
                origenTemp = origenTemp.Substring(origenTemp.IndexOf("\r\n") + 2);
                imagenes = imagenes.Concat(Directory.GetFiles(rutaTemp)).ToArray(); //combinar string[] de imagenes
            }
        }

        private void mostrarMiniaturas()
        {
            if (miniaturas)
            {
                limpiarMiniaturas();
                boxImagenes = new PictureBox[imagenes.Length];
                mapas = new System.Drawing.Bitmap[imagenes.Length];

                for (int i = 0; i < imagenes.Length; i++)
                {
                    if (ImageExtensions.Contains(Path.GetExtension(imagenes[i]).ToUpperInvariant()))
                    {
                        boxImagenes[i] = new PictureBox();
                        boxImagenes[i].Width = 240;
                        boxImagenes[i].Height = 240;
                        boxImagenes[i].SizeMode = PictureBoxSizeMode.Zoom;
                        System.Drawing.Image image = System.Drawing.Image.FromFile(imagenes[i]);
                        //Image prueba = Image.GetInstance(image,System.Drawing.Imaging.ImageFormat.Jpeg);
                        ScaleImage(i, image, 240, 240);
                        image.Dispose();
                        boxImagenes[i].Image = mapas[i];
                        flpImagenes.Controls.Add(boxImagenes[i]);
                    }
                }
            }
        }

        static void ScaleImage(int i, System.Drawing.Image image, int maxWidth, int maxHeight) { 
            var ratioX = (double)maxWidth / image.Width; 
            var ratioY = (double)maxHeight / image.Height; 
            var ratio = Math.Min(ratioX, ratioY); 
            var newWidth = (int)(image.Width * ratio); 
            var newHeight = (int)(image.Height * ratio);
            mapas[i] = new System.Drawing.Bitmap(newWidth, newHeight);
            g = System.Drawing.Graphics.FromImage(mapas[i]);
            g.DrawImage(image, 0, 0, newWidth, newHeight);
            g.Dispose();
        }

        private void limpiarMiniaturas()
        {
            flpImagenes.Controls.Clear();
            for (int i = 0; i < mapas.Length; i++)
            {
                mapas[i].Dispose();
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Form formulario = new FormConfiguraciones();
            formulario.ShowDialog();
            //Codigo al cerrar el formulario
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            vw = Int32.Parse(config.AppSettings.Settings["verticalWidth"].Value);
            vh = Int32.Parse(config.AppSettings.Settings["verticalHeight"].Value);
            hw = Int32.Parse(config.AppSettings.Settings["horizontalWidth"].Value);
            hh = Int32.Parse(config.AppSettings.Settings["horizontalHeight"].Value);
            
            formato = Int32.Parse(config.AppSettings.Settings["formatoPagina"].Value);
            miniaturas = Boolean.Parse(config.AppSettings.Settings["mostrarMiniaturas"].Value);
            compresion = Boolean.Parse(config.AppSettings.Settings["compresionImagenes"].Value);
            ruta = config.AppSettings.Settings["rutaDestinoDefecto"].Value;
            inputCarpetaDestino.Text = ruta;

            vertical = new Rectangle(vw, vh);
            horizontal = new Rectangle(hw, hh);
        }

        private void labelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
