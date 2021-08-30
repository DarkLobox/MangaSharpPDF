using System;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MangaSharpPDF
{
    public partial class FormConfiguraciones : Form
    {
        //Variables de configuracion
        static AppSettingsReader lector = new AppSettingsReader();
        static int vw = (int)lector.GetValue("verticalWidth", typeof(int));
        static int vh = (int)lector.GetValue("verticalHeight", typeof(int));
        static int hw = (int)lector.GetValue("horizontalWidth", typeof(int));
        static int hh = (int)lector.GetValue("horizontalHeight", typeof(int));
        static int formato = (int)lector.GetValue("formatoPagina", typeof(int));
        static string ruta = (string)lector.GetValue("rutaDestinoDefecto", typeof(string));
        static bool miniaturas = (bool)lector.GetValue("mostrarMiniaturas", typeof(bool));

        //Movimiento de ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        

        public FormConfiguraciones()
        {
            InitializeComponent();
            cargarConfiguraciones();
        }

        private void cargarConfiguraciones()
        {
            if (formato == 1)
            {
                rbtnTamañoEstablecer.Checked = true;
                inputVerticalW.Text = vw.ToString();
                inputVerticalH.Text = vh.ToString();
                inputHorizontalW.Text = hw.ToString();
                inputHorizontalH.Text = hh.ToString();
                activarCampos();
            }
            else if(formato == 2)
            {
                rbtnTamañoEstrecho.Checked = true;
            }
            else if (formato == 3)
            {
                rbtnTamañoNormal.Checked = true;
            }
            else if (formato == 4)
            {
                rbtnTamañoImagenes.Checked = true;
                
            }
            inputRutaDestinoDefecto.Text = ruta;
            cboxMostrarMiniaturas.Checked = miniaturas;
        }

        private void guardarConfiguraciones()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (formato == 1)
            {
                config.AppSettings.Settings["formatoPagina"].Value = "1";
                config.AppSettings.Settings["verticalWidth"].Value = inputVerticalW.Text;
                config.AppSettings.Settings["verticalHeight"].Value = inputVerticalH.Text;
                config.AppSettings.Settings["horizontalWidth"].Value = inputHorizontalW.Text;
                config.AppSettings.Settings["horizontalHeight"].Value = inputHorizontalH.Text;
                vw = Int32.Parse(inputVerticalW.Text);
                vh = Int32.Parse(inputVerticalH.Text);
                hw = Int32.Parse(inputHorizontalW.Text);
                hh = Int32.Parse(inputHorizontalH.Text);
            }
            else if (formato == 2)
            {
                config.AppSettings.Settings["formatoPagina"].Value = "2";
                config.AppSettings.Settings["verticalWidth"].Value = vw.ToString();
                config.AppSettings.Settings["verticalHeight"].Value = vh.ToString();
                config.AppSettings.Settings["horizontalWidth"].Value = hw.ToString();
                config.AppSettings.Settings["horizontalHeight"].Value = hh.ToString();
            }
            else if (formato == 3)
            {
                config.AppSettings.Settings["formatoPagina"].Value = "3";
                config.AppSettings.Settings["verticalWidth"].Value = vw.ToString();
                config.AppSettings.Settings["verticalHeight"].Value = vh.ToString();
                config.AppSettings.Settings["horizontalWidth"].Value = hw.ToString();
                config.AppSettings.Settings["horizontalHeight"].Value = hh.ToString();
            }
            else if (formato == 4)
            {
                config.AppSettings.Settings["formatoPagina"].Value = "4";
            }

            config.AppSettings.Settings["rutaDestinoDefecto"].Value = inputRutaDestinoDefecto.Text.ToString();
            config.AppSettings.Settings["mostrarMiniaturas"].Value = cboxMostrarMiniaturas.Checked.ToString();
            config.Save(ConfigurationSaveMode.Modified);

            ruta = inputRutaDestinoDefecto.Text;
            miniaturas = cboxMostrarMiniaturas.Checked;
            this.Close();
        }

        private void configuracionesDefecto()
        {
            vw = 1290;
            vh = 1684;
            hw = 1290;
            hh = 842;
            formato = 2;
            rbtnTamañoEstrecho.Checked = true;
            ruta = "";
            inputRutaDestinoDefecto.Text = "";
            miniaturas = true;
            cboxMostrarMiniaturas.Checked = true;
        }

        private void btnAplicarCambios_Click(object sender, EventArgs e)
        {
            guardarConfiguraciones();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            configuracionesDefecto();
            guardarConfiguraciones();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void labelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void inputRutaDestinoDefecto_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void inputRutaDestinoDefecto_DragDrop(object sender, DragEventArgs e)
        {
            string[] carpetas = (String[])e.Data.GetData(DataFormats.FileDrop, false);
            inputRutaDestinoDefecto.Text = carpetas[0];
            ruta = carpetas[0];
        }

        private void rbtnTamañoEstablecer_CheckedChanged(object sender, EventArgs e)
        {
            formato = 1;
            activarCampos();
        }

        private void rbtnTamañoEstrecho_CheckedChanged(object sender, EventArgs e)
        {
            desactivarCampos();
            formato = 2;
            vw = 1290;
            vh = 1684;
            hw = 1290;
            hh = 842;
        }

        private void rbtnTamañoNormal_CheckedChanged(object sender, EventArgs e)
        {
            desactivarCampos();
            formato = 3;
            vw = 1290;
            vh = 1684;
            hw = 1684;
            hh = 1290;
        }

        private void rbtnTamañoImagenes_CheckedChanged(object sender, EventArgs e)
        {
            desactivarCampos();
            formato = 4;
        }

        private void cboxMostrarMiniaturas_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxMostrarMiniaturas.Checked == true)
            {
                miniaturas = true;
            }
            else
            {
                miniaturas = false;
            }
        }

        private void inputRutaDestinoDefecto_DoubleClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                inputRutaDestinoDefecto.Text = folderBrowser.SelectedPath;
            }
        }

        private void activarCampos()
        {
            inputVerticalW.Enabled = true;
            inputVerticalH.Enabled = true;
            inputHorizontalW.Enabled = true;
            inputHorizontalH.Enabled = true;
        }
        private void desactivarCampos()
        {
            inputVerticalW.Enabled = false;
            inputVerticalH.Enabled = false;
            inputHorizontalW.Enabled = false;
            inputHorizontalH.Enabled = false;
        }

        private void inputNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
