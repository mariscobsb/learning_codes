using System;
using System.Collections.Generic;


	class Program
	{
		static void Main(string[] args)
		{
			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						Console.WriteLine("Em implementacao, volte mais tarde");
						break;
					case "2":
						Console.WriteLine("Em implementacao, volte mais tarde");
						break;
					case "3":
						Console.WriteLine("Em implementacao, volte mais tarde");
						break;
					case "4":
						Console.WriteLine("Em implementacao, volte mais tarde");
						break;
					case "5":
						Console.WriteLine("Em implementacao, volte mais tarde");
						break;
                    case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}
			
			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
		}


		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Criando um catálogo de jogos usando boas práticas de arquitetura com .NET");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1 - Listar jogos");
			Console.WriteLine("2 - Inserir novo jogo");
			Console.WriteLine("3 - Consultar jogo");
			Console.WriteLine("4 - Editar");
			Console.WriteLine("5 - Apagar registro");
            Console.WriteLine("C - Limpar Tela");
			Console.WriteLine("X - Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
	}
