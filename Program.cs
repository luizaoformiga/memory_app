using System;
using memory_app.Methods;

namespace memory_app
{
    class Program
    {
        public static ListSeries listSeriesMethod = new ListSeries();
        public static InsertSeries insertSeriesMethod = new InsertSeries();
        public static UpdateSeries updateSeriesMethod = new UpdateSeries();
        public static ExcludeSeries excludeSeriesMethod = new ExcludeSeries();
        public static ViewSeries viewSeriesMethod = new ViewSeries();
        
        public static void Main(string[] args)
        {
           string optionUser = GetOptionsUsers();

           while (optionUser.ToUpper() != "x")
           {
               switch (optionUser)
               {
                   case "1":
                   // listSeriesMethod();
                   break;
                   
                   case "2": 
                   // insertSeriesMethod(); 
                   break;

                   case "3":
                    // updateSeriesMethod();
                   break;

                   case "4":
                    //ExcludedSeries();
                   break;

                   case "5":
                    //viewSerieMethod(); 
                   break;

                   case "6":
                    Console.Clear();
                   break;

                   default:
                    throw new ArgumentOutOfRangeException();
               }
           }
        }
        private static string GetOptionsUsers()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!");
            Console.WriteLine("Informe a opção desejada: ");
            
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir a opção desejada");
            Console.WriteLine("3 - Atualizar nova série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("6 - Limpar tudo");
            Console.WriteLine("7 - Sair");

            string optionUser = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return optionUser;
        }
    }
}
