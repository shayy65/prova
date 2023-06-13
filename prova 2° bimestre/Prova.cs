using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova_2__bimestre
{
    public partial class Prova : Form
    {
        public Prova()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Correcao a = new Correcao();
            a.ShowDialog();
        }
    }
}
