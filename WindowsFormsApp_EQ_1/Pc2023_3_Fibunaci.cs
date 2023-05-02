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
    public partial class Pc2023_3_Fibunaci : Form
    {
        [DllImport(@"C:\Users\Reyna\source\repos\PM_U5_EQ_1\Debug\PM_U5_EQ_1.dll")]
        static extern int fibunacci(int t0, int t1);
        public Pc2023_3_Fibunaci()
        {
            InitializeComponent();
        }

        private void Pc2023_3_Fibunaci_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de t0 y t1
            int t0 = int.Parse(txtT0.Text);
            int t1 = int.Parse(txtT1.Text);

            // Llamar a la función fibunacci para obtener la serie
            int tn = 0;
            string serie = $"{t0} {t1}";
            for (int i = 0; i < 8; i++)
            {
                tn = fibunacci(t0, t1);
                serie += $" {tn}";
                t0 = t1;
                t1 = tn;
            }

            // Mostrar la serie en un MessageBox
            MessageBox.Show($"Serie de Fibonacci: {serie}", "Serie Fibonacci");
        }
    }
}
