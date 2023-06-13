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
    public partial class Correcao : Form
    {
        public Correcao()
        {
            InitializeComponent();
            label2.Text = "";
        }

        private void Correcao_Load(object sender, EventArgs e)
        {

        }

        private void bt_avaliar_Click(object sender, EventArgs e)
        {
            string[] gabarito = { "A", "B", "D", "E", "C", "A", "A", "D", "E", "C" };

            string[]resposta = {Convert.ToString(tx_1), Convert.ToString(tx_2), Convert.ToString(tx_3), Convert.ToString(tx_4), Convert.ToString(tx_5), Convert.ToString(tx_6), Convert.ToString(tx_7), Convert.ToString(tx_8), Convert.ToString(tx_9), Convert.ToString(tx_10) };

            int qtdacertos = 0;
            for(int i = 0; i < gabarito.Length; i++)
            {
                if(resposta == gabarito )
                {
                    qtdacertos += 1;
                }
                
            }

            MessageBox.Show(Convert.ToString(qtdacertos));

            

            



        }

        private void tx_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
