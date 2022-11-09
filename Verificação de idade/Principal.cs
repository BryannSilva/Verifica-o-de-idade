using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificação_de_idade
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Verificando se há problemas enquanto o programa é executado:           
            try
            {
                // Declaração de variáveis:            
                string nome = txbNome.Text;
                string sobrenome = txbSobrenome.Text;
                int idade = int.Parse(txbIdade.Text);
                int ano = int.Parse(DateTime.Now.ToString("yyyy"));
                int r = ano - idade;

                if (idade > 1980)
                {

                    // Verificando se a idade do usuário é maior que 18:
                    if (r > 18)
                    {
                        pibTrancado.Image = Properties.Resources.ok;
                        MessageBox.Show("Bem vindo " + nome + " " + sobrenome + "\n Você tem " + r + " anos!");
                    }
                    else
                    {
                        pibTrancado.Image = Properties.Resources.erro;
                        MessageBox.Show("Acesso Negado!");
                    }
                } 
                else
                {
                    MessageBox.Show("Informe sua idade corretamente!");
                }
            
            }
            catch
            {
                MessageBox.Show("Preencha os campos corretamente!");
            }
            
            

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar campos:
            txbNome.Clear();

            txbSobrenome.Clear();

            txbIdade.Clear();

            pibTrancado.Image = Properties.Resources.trancar;
            
        }

        private void lblFechar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fechar programa:
            this.Close();
        }
    }
}
