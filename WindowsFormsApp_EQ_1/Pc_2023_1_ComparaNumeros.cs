using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_EQ_1
{
    public partial class Pc_2023_1_ComparaNumeros : Form
    {
        [DllImport(@"C:\Users\Reyna\source\repos\PM_U5_EQ_1\Debug\PM_U5_EQ_1.dll")]
        static extern int comparaNumeros(StringBuilder sb, string nombre, int numero1, int numero2, int totdigitos);
        public Pc_2023_1_ComparaNumeros()
        {
            InitializeComponent();
        }

        private int GenerarNumeroAleatorio()
        {
            Random rnd = new Random();
            return rnd.Next(1000, 10000);
        }


        private void Pc_2023_1_ComparaNumeros_Load(object sender, EventArgs e)
        {

        }
        StringBuilder sb;

        private void button1_Click(object sender, EventArgs e)
        {
            sb = new StringBuilder();
            sb.Clear();
            int largo = comparaNumeros(sb, "Picas y Fijas", 56, 59, 2);
            string c = sb.ToString();
            c = c.Substring(0, largo);
            MessageBox.Show(c);
        }

        private void txtDatos_TextChanged(object sender, EventArgs e)
        {
            if (txtDatos.Text.Length == 4 && txtDatos.Text.All(char.IsDigit))
            {
                // El valor ingresado es válido
            }
            else
            {
                // Mostrar un mensaje de error o realizar alguna acción
            }
        }

    }
}
