using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace MangaSharpPDF
{
    public partial class MangaSharpPDF : Form
    {
        //Dimensiones de pagina
        static iTextSharp.text.Rectangle d1 = new iTextSharp.text.Rectangle(1290, 1684);
        static iTextSharp.text.Rectangle d2 = new iTextSharp.text.Rectangle(1684, 1290);
        static iTextSharp.text.Rectangle d3 = new iTextSharp.text.Rectangle(1290, 842);

        static iTextSharp.text.Rectangle[] dimensiones = { d1, d2, d3 };

        //Configuracion orientacion pagina
        static int[] configuraciones = { 0, 2 }; //A4 Ancho de pagina uniforme
        //static int[] configuraciones = { 0, 1 }; //A4 horizontal y vertical

        public MangaSharpPDF()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCarpeta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                inputCarpetaOrigen.Text = folderBrowser.SelectedPath;
                inputNombrePDF.Text = inputCarpetaOrigen.Text.Substring(inputCarpetaOrigen.Text.LastIndexOf("\\") + 1);
            }
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            if (inputCarpetaOrigen.Text.Equals("")==false && inputCarpetaDestino.Text.Equals("")==false && inputNombrePDF.Text.Equals("")==false)
            {
                generarPDF(inputCarpetaOrigen.Text, inputCarpetaDestino.Text, inputNombrePDF.Text);
                MessageBox.Show("Generacion de PDF terminada", "Mensaje");
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

        }

        void generarPDF(string origen, string destino, string nombre)
        {
            //Variables
            iTextSharp.text.Image image;
            //Archivos de directorio
            string[] imagenes = Directory.GetFiles(origen);
            //Creacion de doc sin tamaño de pagina definido
            Document doc = new Document();
            //Creacion del archivo pdf
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(destino + "\\" + nombre + ".pdf", FileMode.Create));

            //Establecer margenes
            doc.SetMargins(0, 0, 0, 0);

            //Establecer dimension primera pagina
            image = iTextSharp.text.Image.GetInstance(imagenes[0]);
            EstablecerDimensiones(doc, image);

            // Abrir pdf
            doc.Open();

            //Escribir contenido del pdf
            for (int i = 0; i < imagenes.Length; i++)
            {
                //Formatos permitidos
                if (imagenes[i].IndexOf(".jpg") != -1 || imagenes[i].IndexOf(".JPG") != -1 || imagenes[i].IndexOf(".png") != -1 || imagenes[i].IndexOf(".PNG") != -1 || imagenes[i].IndexOf(".jpeg") != -1 || imagenes[i].IndexOf(".JPEG") != -1)
                {
                    image = iTextSharp.text.Image.GetInstance(imagenes[i]);
                    EstablecerDimensiones(doc, image);
                    doc.NewPage();
                    doc.Add(image);
                    
                }
            }

            //Cerrar pdf
            doc.Close();
            writer.Close();
        }

        void EstablecerDimensiones(Document doc, iTextSharp.text.Image image)
        {
            //0
            if (image.Height > image.Width)
            {
                doc.SetPageSize(dimensiones[configuraciones[0]]);
                image.ScaleAbsoluteWidth(dimensiones[configuraciones[0]].Width);
                image.ScaleAbsoluteHeight(dimensiones[configuraciones[0]].Height);
                Debug.WriteLine("Ancho: " + dimensiones[configuraciones[0]].Width + " Largo: " + dimensiones[configuraciones[0]].Height);
            }
            //1 o 2
            if (image.Width >= image.Height)
            {
                doc.SetPageSize(dimensiones[configuraciones[1]]);
                image.ScaleAbsoluteWidth(dimensiones[configuraciones[1]].Width);
                image.ScaleAbsoluteHeight(dimensiones[configuraciones[1]].Height);
                Debug.WriteLine("Ancho: " + dimensiones[configuraciones[1]].Width + " Largo: " + dimensiones[configuraciones[1]].Height);
            }

        }

        private void inputCarpetaOrigen_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            inputCarpetaOrigen.Text = "";
        }
    }
}
