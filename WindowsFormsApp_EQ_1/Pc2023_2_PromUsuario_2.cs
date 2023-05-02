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
    public partial class Pc2023_2_PromUsuario_2 : Form
    {
        
        static extern int promUsuario(StringBuilder strRes,string srt, int cal1, int cal2, int cal3);
        public Pc2023_2_PromUsuario_2()
        {
            InitializeComponent();
        }

        private void Pc2023_2_PromCadena_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(100);
            int largo = promUsuario(sb,"Luisito", 8, 9,7);
            string c = sb.ToString();
            c = c.Substring(0, largo);
            MessageBox.Show(c);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
