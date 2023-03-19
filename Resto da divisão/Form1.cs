using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resto_da_divisão
{
    public partial class frmRestoDeDivisao : Form
    {
        public frmRestoDeDivisao()
        {
            InitializeComponent();
        }

        private void lblRealizar_Click(object sender, EventArgs e)
        {
            int dividendo = int.Parse(txtDividendo.Text);
            int divisor = int.Parse(txtDivisor.Text);
            int resto = dividendo % divisor;
            txtResto.Text = resto.ToString();
        }

        private void txtDividendo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
