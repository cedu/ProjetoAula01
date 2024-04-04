using ProjetoAula01.Entities;
using ProjetoAula01.Repositories;

Console.WriteLine("\n*** CADASTRO DE CLIENTES: ***\n");

//criando um objeto 
var cliente = new Cliente();

//gerando o id e a data e hora de cadastro
cliente.Id = Guid.NewGuid();
cliente.DataHoraCadastro = DateTime.Now;

//usuário preenche o nome
Console.Write("INFORME O NOME DO CLIENTE..: ");
cliente.Nome = Console.ReadLine();

//usuário preenche o email
Console.Write("INFORME O EMAIL DO CLIENTE.: ");
cliente.Email = Console.ReadLine();

//usuário preenche o cpf
Console.Write("INFORME O CPF DO CLIENTE...: ");
cliente.Cpf = Console.ReadLine();

//imprimindo os dados do cliente no console
Console.WriteLine("\nDADOS DO CLIENTE:");
Console.WriteLine("\tID...........: " + cliente.Id);
Console.WriteLine("\tNOME.........: " + cliente.Nome);
Console.WriteLine("\tEMAIL........: " + cliente.Email);
Console.WriteLine("\tCPF..........: " + cliente.Cpf);
Console.WriteLine("\tCADASTRADO EM: " + cliente.DataHoraCadastro);

//instanciando a classe ClienteRepositorio
var clienteRepository = new ClienteRepository();
clienteRepository.ExportarDados(cliente);

Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!\n");
