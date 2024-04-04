using ProjetoAula01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula01.Repositories
{
    public class ClienteRepository
    {
        /*  Método para exportar os dados do cliente para um arquivo de extensão txt */
        public void ExportarDados(Cliente cliente)
        {
            try
            {
                //variavel para armazenar o caminho do arquivo
                var path = "C:\\Users\\Carlos Eduardo\\source\\repos\\Turma-SQS-2024\\Arquivo\\";

                //verificar se a pasta não existe
                if (!Directory.Exists(path))
                {
                    //criando a pasta
                    Directory.CreateDirectory(path);
                }

                //abrindo um arquivo em modo de escrita
                var streamWriter = new StreamWriter(path + "\\clientes.txt", true);

                //escrevendo conteudo do arquivo
                streamWriter.WriteLine("ID DO CLIENTE......" + cliente.Id);
                streamWriter.WriteLine("NOME..............." + cliente.Nome);
                streamWriter.WriteLine("EMAIL.............." + cliente.Email);
                streamWriter.WriteLine("CPF................" + cliente.Cpf);
                streamWriter.WriteLine("CADASTRADO EM......" + cliente.DataHoraCadastro);
                streamWriter.WriteLine("...");

                //fechando o arquivo
                streamWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao escrever no arquivo: " + ex.Message);
            }
        }
    }
}
