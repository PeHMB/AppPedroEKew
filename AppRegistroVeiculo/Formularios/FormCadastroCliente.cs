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
using MeusComponentes.Interacoes;
using FerramentasBiblioteca.Validacoes;
using FerramentasBiblioteca.Formatacoes;

namespace AppRegistroVeiculo.Formularios
{
    public partial class FormCadastroCliente : Form
    {
        //1º Passo: Criar uma lista de Cliente
        List<Cliente> listaCliente = new List<Cliente>();
        //2º Passo: Declarar a variavel ID
        private int id = 0;

        public FormCadastroCliente()
        {
            InitializeComponent();
            //4° passo => fazer a chamada do método para buscar o Id
            BuscarUltimoId();

            edCPF.Enabled = false;
            edNome.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void edModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            edCPF.Enabled = true;
            edNome.Enabled = true;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
            edNome.Select();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            //8º passo => salvar o registro no arquivo
            //8.1 crair o objeto para realizar o registro
            if (ValidacoesSociais.ValidarCpf(edCPF.Text))
            {
                StreamWriter sw = new StreamWriter("cliente.csv", true);
                //8.2 criar o objeto "veiculo" para guardar os dados dos campos
                Cliente cliente = new Cliente();
                //8.3 guardar os dados que o usuario inseriu do form
                cliente.Id = ++id;
                cliente.Nome = edNome.Text;
                cliente.Cpf = Mascaras.LimparCPF(edCPF.Text);
                //8.4 Gravar(salvar) no arquivo
                sw.WriteLine(cliente.ToString());
                //8.5 Fechar o arquivo
                sw.Close();
                //8.6 chamar o método para atualizar o ID
                listaCliente.Clear();//limpar lista
                BuscarUltimoId();
                //8.7 Limpar componentes
                edNome.Enabled = false;
                edCPF.Enabled = false;
                btCancelar.Enabled = false;
                btSalvar.Enabled = false;
                btAdd.Enabled = true;
                Mensagem.Informacao("Salvo com Sucesso", "Cliente");
                edCPF.Clear(); edNome.Clear(); btCancelar.Enabled = false; btSalvar.Enabled = false;
            }
            else
            {
                Mensagem.Erro("CPF inválido", "Cleinte");
                edCPF.Clear();
                edCPF.Select();
            }

        }
        public void BuscarUltimoId()
        {
            //3.1 Criar a classe para leitura do arquivo
            StreamReader sr = new StreamReader("cliente.csv");
            //3.2 Laço para ler os registros do arquivo
            while (!sr.EndOfStream)
            {
                //3.2.1 Criar classe para receber os dados do registro e armazenar no vetor
                Cliente cliente= new Cliente();
                //3.2.2 fazer a leitura d registor e armazenar no vetor 
                string[] registro = sr.ReadLine().Split(';');

                //3.2.3 retirar os dados do vetor e inserir o obj veiculo
                cliente.Id = Convert.ToInt32(registro[0]);
                cliente.Cpf = registro[1];
                cliente.Nome = registro[2];
                
                //3.3.4 Adicionar objeto na lista de veiculos
                listaCliente.Add(cliente);
            }
            //3.3 fechar arquivo
            sr.Close();
            //3.4 buscar ultimo ID na lista
            id = listaCliente.Last().Id;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            edCPF.Enabled = false;
            edNome.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            edCPF.Clear(); edNome.Clear(); btCancelar.Enabled = false; btSalvar.Enabled = false;

        }
    }
}
