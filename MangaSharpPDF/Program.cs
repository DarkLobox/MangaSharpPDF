using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaSharpPDF
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MangaSharpPDF());
        }
    }
}
//OpenFileDialog dlAbrir = new OpenFileDialog();
//dlAbrir.CheckFileExists = true;
//    dlAbrir.CheckPathExists = true;
//    dlAbrir.Multiselect = true;
//    dlAbrir.Filter = "Imagenes (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"; ;
//    dlAbrir.Title = "Seleccionar imagenes";
//    if (dlAbrir.ShowDialog() == DialogResult.OK)
//    {

//    }