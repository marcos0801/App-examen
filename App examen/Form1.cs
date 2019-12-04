using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int limite = 0 , suma=0;

            limite = int.Parse(this.txtlimite.Text);
            suma = clases.examen.sumatoria(limite);
            this.txtsumatoria.Text = suma.ToString();

        }
    }
}
