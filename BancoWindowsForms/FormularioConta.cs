using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoWindowsForms
{
    public partial class FormularioConta : Form
    {
        private List<Cliente> ListaCli;

        public FormularioConta()
        {
            InitializeComponent();
        }

        private void FormularioConta_Load(object sender, EventArgs e)
        {
            rbPessoaFisica.Checked = true;
            rbContaPoupanca.Checked = true;
            rbMasculino.Checked = true;
            cbLimite.Visible = false;
            mtbLimite.Visible = false;
            lblLimite.Visible = false;
            ListaCli = new List<Cliente>();
        }

        private void rdPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCPF.Text = "CNPJ:";
            mtbCPF.Mask = "00.000.000/0000-00";
            gbGenero.Visible = false;
            lblDatadeNascimento.Text = "Data de Fundação";
            rbContaPoupanca.Visible = false;
            rbContaCorrente.Checked = true;
        }

        private void rdPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCPF.Text = "CPF:";
            mtbCPF.Mask = "000.000.000-00";
            gbGenero.Visible = true;
            lblDatadeNascimento.Text = "Data de Nascimento";
            rbContaPoupanca.Visible = true;
        }

        private void rbContaCorrente_CheckedChanged(object sender, EventArgs e)
        {
            cbLimite.Visible = true;

        }

        private void rbContaPoupanca_CheckedChanged(object sender, EventArgs e)
        {
            cbLimite.Visible = false;
            mtbLimite.Visible = false;
            lblLimite.Visible = false;
        }

        private void cbLimite_CheckedChanged(object sender, EventArgs e)
        {

            if (cbLimite.Checked)
            {
                mtbLimite.Visible = true;
                lblLimite.Visible = true;
            }
            else
            {
                mtbLimite.Visible = false;
                lblLimite.Visible = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var endereco = new Endereco
            {
                Logradouro = txtLogradouro.Text,
                Numero = txtNumero.Text,
                Bairro = txtBairro.Text,
                Estado = cbEstado.SelectedText,
                Cidade = cbCidade.SelectedText,
                CEP = mtbCEP.Text,
                Complemento = txtComplemento.Text,
                TipoEndereco = TipoEndereco.Residencial
            };

            var cliente = new Cliente()
            {
                Nome = txtNomedoCliente.Text,
                Celular = mtbCelular.Text,
                Telefone = mtbTelefone.Text,
            };

            ListaCli.Add(cliente);

            Apagar();
        }       

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            Apagar();
        }

        public void Apagar()
        {
            txtLogradouro.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtBairro.Text = string.Empty;
            cbEstado.SelectedText = string.Empty;
            cbCidade.SelectedText = string.Empty;
            mtbCEP.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtNomedoCliente.Text = string.Empty;
            mtbCelular.Text = string.Empty;
            mtbTelefone.Text = string.Empty;
            mtbCPF.Text = string.Empty;
            mtbDatadeNascimento.Text = string.Empty;
            cbCidade.Text = string.Empty;
            cbEstado.Text = string.Empty;
        }

        private void mtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}