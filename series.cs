//app simples de cadastro de series c# para práticas da dio em implementação

using System;

class Program
{
    static void Main() {

        Console.Write("Bem  vindo ao cadastro de Séries!\n");
        Console.Write("Escoha sua opção desejada: \n");
        Console.Write("1 - Listar séries\n");
        Console.Write("2 - Inserir nova série\n");
        Console.Write("3 - Atualizar série\n");
        Console.Write("4 - Excluir série\n");
        Console.Write("5 - Visualizar série\n");
        Console.Write("C - Limpar tela \n");
        Console.Write("S - Sair\n");
        switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Reuso da classe em implementação 1 \n");
                    break;
                case "2":
                    Console.WriteLine("Reuso da classe em implementação 2\n");                    
                    break;
                case "3":
                    Console.WriteLine("Reuso da classe em implementação 3\n");
                    break;
                case "4":
                    Console.WriteLine("Reuso da classe em implementação 4\n");
                    break;
                case "5":
                    Console.WriteLine("Reuso da classe em implementação 5\n");
                    break;
                case "C":
                    Console.Clear();
	                Console.WriteLine("Limpei o Ecra");
                    break;
                case "S":
                    Console.WriteLine("Tchau\n");
                    break;
                    
                    
                    
            }
        
    }
}


   
