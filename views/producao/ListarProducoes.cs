using projeto2023.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projeto2023.views.producao
{
    public partial class ListarProducoes : Form
    {
        public ListarProducoes()
        {
            InitializeComponent();
            LoadDataAndCreateButtons();
        }
        private void LoadDataAndCreateButtons()
        {
            // Substitua "suaConnectionString" pela conexão com o seu banco de dados
            string connectionString = @"Data Source=SUP-04;Initial Catalog=Estampariadb;Integrated Security=True;";
            string query = "SELECT ID_Linha, Status FROM PRODUCOES";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int idLinha = (int)reader["ID_Linha"];
                    string status = reader["Status"].ToString();

                    // Crie um novo botão
                    
                    Button button = new Button();
                    button.Text = $"ID_Linha: {idLinha} \nStatus: {status}";
                    button.Size = new Size (182, 94);
                    button.Font = new Font("Arial", 12, FontStyle.Bold);
                    button.BackColor = Color.LightGreen;
                    if (status == "1")
                    {
                        button.Text = $"ID Linha: {idLinha}, Status: Em Andamento";
                        button.BackColor = Color.LightGreen; // Define a cor de fundo como LightGreen
                    }
                    else if (status == "0")
                    {
                        button.Text = $"ID Linha: {idLinha}, Status: Linha Finalizada";
                        button.BackColor = Color.Tomato;
                    }
                    else if (status == "2")
                    {
                        button.Text = $"ID Linha: {idLinha}, Status: Aguandando 1º lançamento";
                        button.BackColor = Color.Gold;
                    }
                    button.Click += (sender, e) =>
                    {
                        // Este código será executado quando o botão for clicado
                        // Você pode realizar qualquer ação desejada aqui com base no ID_Linha e Status
                        // Por exemplo, abrir o formulário Producao_Andamento com os dados da produção
                        int clickedIdLinha = idLinha;
                        string clickedStatus = status;
                        AbrirFormularioProducaoAndamento(clickedIdLinha, clickedStatus);
                    };
                    //Panel panel1 = new Panel();
                    //panel1.AutoScroll = true; // Habilita a rolagem automática vertical
                    //panel1.Dock = DockStyle.Fill;


                    // Adicione o botão ao FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(button);
                }

                reader.Close();
            }
        }
      
        private void AbrirFormularioProducaoAndamento(int idLinha, string status)
        {
            // Código para abrir o formulário Producao_Andamento e passar os parâmetros
            // Você precisa implementar a lógica para abrir o formulário e passar os parâmetros
            // Pode ser semelhante ao que mencionamos em respostas anteriores.
            Producao_Andamento fmr = new Producao_Andamento(idLinha);
            fmr.ShowDialog();

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Extrair o ID_Linha do texto do botão
            int idLinha = ExtractIdLinhaFromButtonText(clickedButton.Text);

            // Criar uma instância do formulário Producao_Andamento, passando o ID_Linha como parâmetro
            Producao_Andamento formularioProducaoAndamento = new Producao_Andamento(idLinha);

            // Exibir o formulário Producao_Andamento
            formularioProducaoAndamento.Show();
        }
        private int ExtractIdLinhaFromButtonText(string buttonText)
        {
            int idLinha = -1; // Valor padrão caso não seja encontrado

            // Dividir o texto em partes usando a vírgula como delimitador
            string[] parts = buttonText.Split(',');

            foreach (string part in parts)
            {
                // Procurar a parte que contém "ID_Linha:"
                if (part.Contains("ID_Linha:"))
                {
                    // Extrair o ID_Linha como uma string
                    string idPart = part.Trim().Replace("ID_Linha:", "");

                    // Converter a string para um valor inteiro
                    if (int.TryParse(idPart, out idLinha))
                    {
                        break; // Sai do loop quando encontrar o ID_Linha
                    }
                }
            }

            return idLinha;
        }



        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
