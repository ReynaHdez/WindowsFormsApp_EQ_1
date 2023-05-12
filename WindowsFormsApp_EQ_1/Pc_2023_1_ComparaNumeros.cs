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
        static extern IntPtr comparaNumeros(StringBuilder sb, string nombre, int[] auxVector1);
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
            /*
            sb = new StringBuilder();
            sb.Clear();
            int largo = comparaNumeros(sb, "Picas y Fijas", 56, 59, 2);
            string c = sb.ToString();
            c = c.Substring(0, largo);
            MessageBox.Show(c);
            */

            sb = new StringBuilder(100);
            sb.Clear();

            int[] arregloNums = new int[6];
            arregloNums[0] = 2; 
            arregloNums[1] = 10;
            arregloNums[2] = 2;
            arregloNums[3] = 3;
            arregloNums[4] = 7;
            arregloNums[5] = 8;
            
            /*
            for(int i = 0; i < arregloNums.Length; i++)
            {
                MessageBox.Show(arregloNums[i].ToString());
            }
            */

            IntPtr ptr = comparaNumeros(sb, "Cadena ", arregloNums);
            int arrayLength = Marshal.ReadInt32(ptr);

            IntPtr start = IntPtr.Add(ptr, 4);
            int[] result = new int[arrayLength];
            Marshal.Copy(start, result, 0, arrayLength);

            for(int i = 0; i < result.Length; i++)
            {
                MessageBox.Show(result[i].ToString());
            }
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
