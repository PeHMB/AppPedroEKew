using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRegistroVeiculo.RegrasDeNegocio;
using System.IO;// Leitura e Gravação de Dados

namespace AppRegistroVeiculo.Formularios
{
    public partial class FormCadastroVeiculo : Form
    {
        //1º Passo: Criar uma lista de veículo
        List<Veiculo> listaVeiculo = new List<Veiculo>();
        //2º Passo: Declarar a variavel ID
        private int id = 0;
        public FormCadastroVeiculo()
        {
            InitializeComponent();
            //4° passo => fazer a chamada do método para buscar o Id
            BuscarUltimoId();
            //5º passo=> bloquear os componentes
            edAno.Enabled = false;
            edMarca.Enabled = false;
            edModelo.Enabled = false;
            edPlaca.Enabled = false;
            edValor.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            btAdd.Enabled = true;
        }
        //3ºPasso: Criar o método para buscar o último id registrado
        public void BuscarUltimoId()
        {
            //3.1 Criar a classe para leitura do arquivo
            StreamReader sr = new StreamReader("veiculo.csv");
            //3.2 Laço para ler os registros do arquivo
            while (!sr.EndOfStream)
            {
                //3.2.1 Criar classe para receber os dados do registro e armazenar no vetor
                Veiculo veiculo = new Veiculo();
                //3.2.2 fazer a leitura d registor e armazenar no vetor 
                string[] registro = sr.ReadLine().Split(';');

                //3.2.3 retirar os dados do vetor e inserir o obj veiculo
                veiculo.Id = Convert.ToInt32(registro[0]);
                veiculo.Modelo = registro[1];
                veiculo.Marca = registro[2];
                veiculo.Placa = registro[3];
                veiculo.Ano = Convert.ToInt32(registro[4]);
                veiculo.Valor = Convert.ToDouble(registro[5]); 

                //3.3.4 Adicionar objeto na lista de veiculos
                listaVeiculo.Add(veiculo);
            }
            //3.3 fechar arquivo
            sr.Close();
            //3.4 buscar ultimo ID na lista
            id = listaVeiculo.Last().Id;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //6º Passo : Liberar componentes para edição
            edAno.Enabled = true;
            edMarca.Enabled = true;
            edModelo.Enabled = true;
            edPlaca.Enabled = true;
            edValor.Enabled = true;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
            btAdd.Enabled = false;
            edModelo.Select();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //7ºPasso => Limpar campos e bloquear componentes
            edAno.Enabled = false;
            edMarca.Enabled = false;
            edModelo.Enabled = false;
            edPlaca.Enabled = false;
            edValor.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            btAdd.Enabled = true;
            edMarca.Clear();edMarca.Clear();edAno.Clear();edPlaca.Clear();edValor.Clear();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //8º passo => salvar o registro no arquivo
            //8.1 crair o objeto para realizar o registro
            StreamWriter sw = new StreamWriter("veiculo.csv", true);
            //8.2 criar o objeto "veiculo" para guardar os dados dos campos
            Veiculo veiculo = new Veiculo();
            //8.3 guardar os dados que o usuario inseriu do form
            veiculo.Id = ++id;
            veiculo.Modelo = edModelo.Text;
            veiculo.Marca= edMarca.Text;
            veiculo.Placa= edPlaca.Text;
            veiculo.Ano= Convert.ToInt32(edAno.Text);
            veiculo.Valor= Convert.ToDouble(edValor.Text);
            //8.4 Gravar(salvar) no arquivo
            sw.WriteLine(veiculo.ToString());
            //8.5 Fechar o arquivo
            sw.Close();
            //8.6 chamar o método para atualizar o ID
            listaVeiculo.Clear();//limpar lista
            BuscarUltimoId();
            //8.7 Limpar componentes
            edAno.Enabled = false;
            edMarca.Enabled = false;
            edModelo.Enabled = false;
            edPlaca.Enabled = false;
            edValor.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            btAdd.Enabled = true;
            edMarca.Clear(); edMarca.Clear(); edAno.Clear(); edPlaca.Clear(); edValor.Clear();
        }

        private void FormCadastroVeiculo_Load(object sender, EventArgs e)
        {

        }
    }
}