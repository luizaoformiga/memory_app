using System;
using memory_app.classes;

namespace memory_app.Methods
{
    public class ExcludeSeries
    {
        public static SerieRepository repository = new SerieRepository();
        public static void ExcludeSeriesMethod(string[] args)
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repository.Delete(indiceSerie);

        }
    }
}