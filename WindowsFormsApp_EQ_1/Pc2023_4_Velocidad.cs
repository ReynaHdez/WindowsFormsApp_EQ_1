﻿using System;
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
    public partial class Pc2023_4_Velocidad : Form
    {
        [DllImport(@"C:\Users\Reyna\source\repos\PM_U5_EQ_1\Debug\PM_U5_EQ_1.dll")]
        static extern int velocidad(StringBuilder strRes, string str, int distancia, int tiempo);
        
        public Pc2023_4_Velocidad()
        {
            InitializeComponent();
        }

        StringBuilder sb;

        private void Pc2023_4_Velocidad_Load(object sender, EventArgs e)
        {
            sb = new StringBuilder(100);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            sb.Clear();
            int largo = velocidad(sb, "Coche Azul", 120, 2);
            string c = sb.ToString();
            c = c.Substring(0, largo);
            MessageBox.Show(c);
        }
    }
}
