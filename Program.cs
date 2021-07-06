using System;
using System.Collections.Generic;
using Persistence;
using SeriesCatalog.Models;

namespace SeriesCatalog
{
    class Program
    {
        static SeriesRepositorio repository = new SeriesRepositorio();
        static void Main(string[] args)
        {
            
            string userOption = GetUserOption();

            switch(userOption) {
                
                    
            }
            
        }

        private static string GetUserOption() 
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar Séries");            
            Console.WriteLine("2 - Inserir nova série");            
            Console.WriteLine("3 - Atualizar série");            
            Console.WriteLine("4 - Excluir Série");            
            Console.WriteLine("5 - Visualizar série");            
            Console.WriteLine("C - Limpar Tela");            
            Console.WriteLine("X - Sair");            
            Console.WriteLine();            
            
            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;

        }

        private static void GetAllSeries()
        {
            List<Serie> series = repository.GetAll();

            if (series.Count == 0) {
                Console.WriteLine("Não existe nenhuma série cadastrada");
            }

            foreach (var serie in series) {
                Console.WriteLine($"#ID {serie.Id} - {serie.Titulo}");
            }
        }

        private static void CreateNewSerie() {
            
        }
    }
}
