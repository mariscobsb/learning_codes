/*
 * Criando um gerenciador de espaçonaves do star wars com SQL Server + .NET
 *
 * Requisitos: sistema c# vai acessar o SGBD, tirando(DELETE), consultando(SELECT) e acrescentando(INSERT) tuplas
 * LInk: https://web.digitalinnovation.one/lab/criando-um-gerenciador-de-espaconaves-do-star-wars-com-sql-server-net/learning/fe0d2131-0446-4bf0-b158-0e7be8136a6c
 
 Comandos SQL:
 
 CREATE TABLES Planetas (
 IdPlaneta int NOT NULL as PRIMARY KEY,
 Nome varchar(50) NOT NULL,
 Rotacao float NOT NULL,
 Diametro float NOT NULL,
 Clima varchar(50) NOT NULL,
 Populacao int NOT NULL,
 )
 
 CREATE TABLE Pilotos
 (
 IdPiloto int NOT NULL as PRIMARY KEY,
 Nome varchar(500) NOT NULL,
 Birthday varchar(20) NOT NULL,
 idPlaneta as FOREING KEY,
 )
 
 */
 
 
 using System;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo");

        }
    }
