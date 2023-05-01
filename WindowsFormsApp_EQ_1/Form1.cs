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
    public partial class Form1 : Form
    {
        [DllImport(@"C:\Users\Reyna\source\repos\PM_U5_EQ_1\Debug\PM_U5_EQ_1.dll")]
        static extern int largo_cadena(string str);
        [DllImport(@"C:\Users\Reyna\source\repos\PM_U5_EQ_1\Debug\PM_U5_EQ_1.dll")]
        static extern int escribir_cadena(StringBuilder str, int len_buffer);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder(20);
                int largo = escribir_cadena(sb, sb.Capacity);
                string c = sb.ToString();
                c = c.Substring(0, largo);
                MessageBox.Show(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.Close();
        }
    }
}
