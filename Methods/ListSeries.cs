using System;
using memory_app.classes;

namespace memory_app.Methods
{
    public class ListSeries
    {
        public static SerieRepository repository = new SerieRepository();
        public static void ListSeriesMethod(string[] args)
        {
            Console.WriteLine("Listar śeries");

            var list = repository.List();

            if(list.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada");
                return;
            }

            foreach (var serie in list)
            {
                var exclude = serie.ReturnExcludes();

                Console.WriteLine("#ID {0}: - {1}", serie.returnId(), serie.returnTitle(), (exclude ? "Excluido" : ""));
            }
        }
    }
}