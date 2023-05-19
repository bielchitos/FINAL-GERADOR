using Gerarconsulta.Controllers;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using Gerarconsulta.NovaPasta;

namespace FINAL_GERADOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gerar();

        }
        private void gerar()
        {
            List<Personagem> lista = new List<Personagem>();

            ConsultaPersonagem consultaPersonagem = new ConsultaPersonagem();

            string Personagem = consultaPersonagem.ConsultaNome(0, 1, 2000);
            List<Personagem> myPessoas = JsonConvert.DeserializeObject<List<Personagem>>(Personagem);

            String nomeList = "de 0 a 1 anos de idade";
            int Contador = 0;


            List<Lista> ListaPersonagem = new List<Lista>();


            for (int i = 0; i < myPessoas.Count; i++)
            {


                Lista IPessoa = new Lista();

                IPessoa.codigo = Contador++;
                IPessoa.nomeList = nomeList;
                IPessoa.nome = myPessoas[i].nome;
                IPessoa.sobrenome = myPessoas[i].sobrenome;
                IPessoa.estadocivil = myPessoas[i].estadocivil;
                IPessoa.cpf = myPessoas[i].cpf;
                IPessoa.datanascimento = myPessoas[i].datanascimento;
                IPessoa.email = myPessoas[i].email;
                IPessoa.fone = myPessoas[i].fone;
                IPessoa.sexo = myPessoas[i].sexo;
                IPessoa.Hobbie = myPessoas[i].Hobbie;
                IPessoa.idade = myPessoas[i].idade;

                ListaPersonagem.Add(IPessoa);
            }

            Personagem = consultaPersonagem.ConsultaNome(5, 17, 2000);
            myPessoas = JsonConvert.DeserializeObject<List<Personagem>>(Personagem);
            nomeList = "de 5 a 17 anos de idade";
            Contador = 0;



            for (int i = 0; i < myPessoas.Count; i++)
            {



                Lista IPessoa = new Lista();

                IPessoa.codigo = Contador++;
                IPessoa.nomeList = nomeList;
                IPessoa.nome = myPessoas[i].nome;
                IPessoa.sobrenome = myPessoas[i].sobrenome;
                IPessoa.estadocivil = myPessoas[i].estadocivil;
                IPessoa.cpf = myPessoas[i].cpf;
                IPessoa.datanascimento = myPessoas[i].datanascimento;
                IPessoa.email = myPessoas[i].email;
                IPessoa.fone = myPessoas[i].fone;
                IPessoa.sexo = myPessoas[i].sexo;
                IPessoa.Hobbie = myPessoas[i].Hobbie;
                IPessoa.idade = myPessoas[i].idade;
                ListaPessoas.Add(IPessoa);
            }


            Personagem = consultaPersonagem.ConsultaNome(18, 29, 2000);
            myPessoas = JsonConvert.DeserializeObject<List<Personagem>>(Personagem);
            nomeList = "de 18 a 29 anos de idade";
            Contador = 0;



            for (int i = 0; i < myPessoas.Count; i++)
            {



                Lista IPessoa = new Lista();

                IPessoa.codigo = Contador++;
                IPessoa.nomeList = nomeList;
                IPessoa.nome = myPessoas[i].nome;
                IPessoa.sobrenome = myPessoas[i].sobrenome;
                IPessoa.estadocivil = myPessoas[i].estadocivil;
                IPessoa.cpf = myPessoas[i].cpf;
                IPessoa.datanascimento = myPessoas[i].datanascimento;
                IPessoa.email = myPessoas[i].email;
                IPessoa.fone = myPessoas[i].fone;
                IPessoa.sexo = myPessoas[i].sexo;
                IPessoa.Hobbie = myPessoas[i].Hobbie;
                IPessoa.idade = myPessoas[i].idade;
                ListaPersonagem.Add(IPessoa);
            }

            Personagem = consultaPersonagem.ConsultaNome(30, 50, 2000);
            myPessoas = JsonConvert.DeserializeObject<List<Personagem>>(Personagem);
            nomeList = "de 30 a 50 anos de idade";
            Contador = 0;



            for (int i = 0; i < myPessoas.Count; i++)
            {



                Lista IPessoa = new Lista();

                IPessoa.codigo = Contador++;
                IPessoa.nomeList = nomeList;
                IPessoa.nome = myPessoas[i].nome;
                IPessoa.sobrenome = myPessoas[i].sobrenome;
                IPessoa.estadocivil = myPessoas[i].estadocivil;
                IPessoa.cpf = myPessoas[i].cpf;
                IPessoa.datanascimento = myPessoas[i].datanascimento;
                IPessoa.email = myPessoas[i].email;
                IPessoa.fone = myPessoas[i].fone;
                IPessoa.sexo = myPessoas[i].sexo;
                IPessoa.Hobbie = myPessoas[i].Hobbie;
                IPessoa.idade = myPessoas[i].idade;
                ListaPersonagem.Add(IPessoa);
            }

            Personagem = consultaPersonagem.ConsultaNome(51, 90, 2000);
            myPessoas = JsonConvert.DeserializeObject<List<Personagem>>(Personagem);
            nomeList = "de 51 a 90 anos de idade";
            Contador = 0;



            for (int i = 0; i < myPessoas.Count; i++)
            {



                Lista IPessoa = new Lista();

                IPessoa.codigo = Contador++;
                IPessoa.nomeList = nomeList;
                IPessoa.nome = myPessoas[i].nome;
                IPessoa.sobrenome = myPessoas[i].sobrenome;
                IPessoa.estadocivil = myPessoas[i].estadocivil;
                IPessoa.cpf = myPessoas[i].cpf;
                IPessoa.datanascimento = myPessoas[i].datanascimento;
                IPessoa.email = myPessoas[i].email;
                IPessoa.fone = myPessoas[i].fone;
                IPessoa.sexo = myPessoas[i].sexo;
                IPessoa.Hobbie = myPessoas[i].Hobbie;
                IPessoa.idade = myPessoas[i].idade;
                ListaPersonagem.Add(IPessoa);
            }


            dataGridView1.DataSource = ListaPersonagem;
            dataGridView1.Refresh();


        }
    }



}