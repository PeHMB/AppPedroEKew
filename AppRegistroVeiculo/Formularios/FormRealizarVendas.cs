using AppRegistroVeiculo.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRegistroVeiculo.Formularios
{
    public partial class FormRealizarVendas : Form
    {
        //1º Passo: Criar uma lista de Cliente
        List<Cliente> listaCliente = new List<Cliente>();
        List<Veiculo> listaVeiculo = new List<Veiculo>();
        List<Venda> listavenda = new List<Venda>();
        //2º Passo: Declarar a variavel ID
        private int id_cli = 0;
        private int id_ven = 0;
        private int id_vei = 0;
        public FormRealizarVendas()
        {
            InitializeComponent();
            cbPessoa.Enabled = false;
            cbVeiculo.Enabled = false;
            dtpVendas.Enabled = false;
            edModelo.Enabled = false;
            edNome.Enabled = false;
            edValorVenda.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled=false;
        }

        private void cbPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void CarregarLista()
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            cbPessoa.Enabled = true;
            cbVeiculo.Enabled = true;
            dtpVendas.Enabled = true;
            edModelo.Enabled = true;
            edNome.Enabled = true;
            edValorVenda.Enabled = true;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
            btAdd.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            cbPessoa.Enabled = false;
            cbVeiculo.Enabled = false;
            dtpVendas.Enabled = false;
            edModelo.Enabled = false;
            edNome.Enabled = false;
            edValorVenda.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            btAdd.Enabled = true;
            edNome.Clear();edModelo.Clear();edValorVenda.Clear();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

        }
        public void BuscarUltimoId_Ven()
        {
            //3.1 Criar a classe para leitura do arquivo
            StreamReader sr = new StreamReader("veiculo.csv");
            //3.2 Laço para ler os registros do arquivo
            while (!sr.EndOfStream)
            {
                //3.2.1 Criar classe para receber os dados do registro e armazenar no vetor
                Venda venda= new Venda();
                //3.2.2 fazer a leitura d registor e armazenar no vetor 
                string[] registro = sr.ReadLine().Split(';');

                //3.2.3 retirar os dados do vetor e inserir o obj veiculo
                venda.Id = Convert.ToInt32(registro[0]);
                venda.DataVenda = Convert.ToDateTime(registro[1]);
                venda.ValorDaVenda = Convert.ToDouble(registro[2]);
                venda.VeiculoId = Convert.ToInt32(registro[3]);
                venda.ClienteId = Convert.ToInt32(registro[4]);
                

                //3.3.4 Adicionar objeto na lista de veiculos
                listavenda.Add(venda);
            }
            //3.3 fechar arquivo
            sr.Close();
            //3.4 buscar ultimo ID na lista
            id_ven = listavenda.Last().Id;
        }

        private void FormRealizarVendas_Load(object sender, EventArgs e)
        {

        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
