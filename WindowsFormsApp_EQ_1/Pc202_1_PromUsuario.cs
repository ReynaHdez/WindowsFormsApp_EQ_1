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
    public partial class Pc202_1_PromUsuario : Form
    {
        [DllImport(@"C:\Users\Reyna\source\repos\PM_U5_EQ_1\Debug\PM_U5_EQ_1.dll")]
        static extern int promedioDeUsuario(string str, int cal1, int cal2, int cal3);
        public Pc202_1_PromUsuario()
        {
            InitializeComponent();
        }

        private void Pc202_1_PromUsuario_Load(object sender, EventArgs e)
        {
            string nombre;
            int cal1;
            int cal2;
            int cal3;

            nombre = "Secuestrador";
            cal1 = 8;
            cal2 = 9;
            cal3 = 7;

            int resultado = promedioDeUsuario(nombre, cal1, cal2, cal3);

            MessageBox.Show(nombre + " Tiene un Promedio de: " + resultado.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
