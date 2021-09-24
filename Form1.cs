using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaA_Lectura
{
    public partial class Form1 : Form
    {
        string fileName = @"C:\Users\Josue\Documents\Detalles.txt";
        string fileName2 = @"C:\Users\Josue\Documents\Detalles2.txt";
        public Form1()
        {
            InitializeComponent();
        }

       /* private void Btn_Leer2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Filtro.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            //openFileDialog1.Multiselect = true;

            // Mostrar el dialog box.
            openFileDialog1.ShowDialog();

            string archivo = openFileDialog1.FileName;

            if (archivo.Trim().Length > 0) //Validar si se selecciono o no un archivo
                // Abrir el archivo seleccionado.

                using (StreamReader sr = new StreamReader(archivo))
                {
                    String line = sr.ReadToEnd();
                    Txt_Archivo.Text = line;
                }
        }*/



        private void writeFileLine(string pLine)
        {
            /*using (StreamWriter w = File.AppendText(fileName))*/
            using (StreamWriter w = File.AppendText(fileName2))
            {
                w.WriteLine(pLine);
            }
        }

        private void Btn_Generar_Click(object sender, EventArgs e)
        {
            writeFileLine("E,NV,402-1896086-3,02-2021");
            writeFileLine("D,002,IN,24-09-2021,24-10-2021,C,402-1223124-4,Jose,Mendoza,M,11-06-1992,12000.00,150.0,12000.00,N/A");
            writeFileLine("D,002,IN,24-09-2021,24-10-2021,C,402-1291636-4,Maria,Soza,F,04-10-1991,69000.00,250.0,69000.00,N/A");
            writeFileLine("S,4");
            MessageBox.Show("Archivo generado con exito");
        }

        private void Btn_Leer_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fileName2))
                {
                    String line = sr.ReadToEnd();
                    Txt_Archivo.Text = line;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
