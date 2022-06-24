using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tomatinis_Pizzas
{
    public partial class Cadastro_de_Pizzas : Form
    {
        public Cadastro_de_Pizzas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSim.Checked == true)
            {
                grpTipoBorda.Enabled = true;
            }
        }

        private void rdNao_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNao.Checked == true)
            {
                grpTipoBorda.Enabled = false;
            }
        }

        private void chkPequena_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPequena.Checked == true)
            {
                lblValorPizzaPequena.Enabled = true;
                txtValorPizzaPequena.Enabled = true;
            }
            else
            {
                lblValorPizzaPequena.Enabled = false;
                txtValorPizzaPequena.Enabled = false;
            }
        }

        private void chkFamilia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFamilia.Checked == true)
            {
                lblValorPizzaFamilia.Enabled = true;
                txtValorPizzaFamilia.Enabled = true;
            }
            else
            {
                lblValorPizzaFamilia.Enabled = false;
                txtValorPizzaFamilia.Enabled = false;
            }
        }
        private Boolean ChecandoTipoBorda()
        {
            if(rdSim.Checked == true)
            {

                if (chkCheddar.Checked == true || chkCatupiry.Checked == true
                    || chkMista.Checked == true || chkVulcao.Checked == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
            
        }

        private Boolean ChecandoTamanhoPizza()
        {
            if (chkPequena.Checked == true && txtValorPizzaPequena.Text != "")
            {
                return true;
            }
            if (chkFamilia.Checked == true && txtValorPizzaFamilia.Text != "")
            {
                return true;
            }
            return false;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSabor.Text != "" && cmbTipoPizza.Text != "" 
                && txtComposicao.Text != "" && ChecandoTamanhoPizza() && ChecandoTipoBorda())
            {
                MessageBox.Show("Salvou");
            }
            else
            {
                MessageBox.Show("Não salvou");
            }

        }
    }
}
