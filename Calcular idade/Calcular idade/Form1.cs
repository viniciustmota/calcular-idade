using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Deseja finalizar a aplicação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (mensagem == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int idadeAnos = int.Parse(textBox1.Text);
            int idadeDias = idadeAnos * 365;

            lblResultado.Text = "Idade em dias: " + idadeDias;

            if (idadeAnos >= 18)
            {
                lblMaiorIdade.Text = "Atingiu a maioridade";
                lblErro.Text = "";
            }
            else
            {
                lblMaiorIdade.Text = "Não atingiu a maioridade";
                lblErro.Text = "";
            }

            if (idadeAnos > 100 || idadeAnos < 0)
            {
                lblResultado.Text = "";
                lblMaiorIdade.Text = "";
                lblErro.Text = "Erro";
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lblMaiorIdade.Text = "";
            lblResultado.Text = "";
        }
    }
}
