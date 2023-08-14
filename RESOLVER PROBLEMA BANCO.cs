Claro, você pode fazer isso usando eventos e manipulação de dados no C# para Forms .NET. Vou guiá-lo através dos passos para realizar essa tarefa:

 

1. **Conectando-se ao Banco de Dados:** Suponha que você já tenha uma maneira de buscar os IDs e nomes dos clientes do banco de dados. Use um componente de acesso a dados, como o `SqlConnection`, para recuperar esses dados. Certifique-se de incluir os assemblies corretos no seu projeto.

 

```csharp
using System.Data.SqlClient;

 

// ...

 

private void CarregarClientes()
{
    string connectionString = "sua_string_de_conexao";
    string query = "SELECT ID, Nome FROM Clientes";

 

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        SqlCommand command = new SqlCommand(query, connection);
        connection.Open();

 

        SqlDataReader reader = command.ExecuteReader();

 

        while (reader.Read())
        {
            int clienteID = (int)reader["ID"];
            string nomeCliente = (string)reader["Nome"];
            comboBoxClientes.Items.Add(new ClienteItem(clienteID, nomeCliente));
        }

 

        reader.Close();
    }
}
```

 

2. **Criando uma classe para representar o Cliente:**

 

```csharp
public class ClienteItem
{
    public int ID { get; set; }
    public string Nome { get; set; }

 

    public ClienteItem(int id, string nome)
    {
        ID = id;
        Nome = nome;
    }

 

    public override string ToString()
    {
        return Nome;
    }
}
```

 

3. **Preenchendo o ComboBox:**

 

No evento de carregamento do formulário, você pode chamar o método `CarregarClientes` para preencher o `ComboBox` com os IDs e nomes dos clientes.

 

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    CarregarClientes();
}
```

 

4. **Manipulando a Seleção:**

 

Agora, quando o usuário selecionar um cliente no `ComboBox`, você pode atualizar a `TextBox` correspondente com o nome do cliente selecionado. Você pode fazer isso no evento `SelectedIndexChanged` do `ComboBox`.

 

```csharp
private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
{
    if (comboBoxClientes.SelectedItem is ClienteItem selectedCliente)
    {
        textBoxNomeCliente.Text = selectedCliente.Nome;
    }
}
```

 

Certifique-se de que os eventos e métodos mencionados sejam conectados corretamente aos elementos do seu formulário. Isso deve permitir que você carregue o nome do cliente na `TextBox` quando selecionar um ID no `ComboBox`.

tem menu de contexto
Redigir