using System;
using memory_app.classes;

namespace memory_app.Methods
{
    public class UpdateSeries
    {
        public static SerieRepository repository = new SerieRepository();
        public static void UpdateSeriesMethod(string[] args)
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genrer)))
            {
                Console.WriteLine("{0} - {1}", Enum.GetName(typeof (Genrer), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entryGenrer = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o título da série: ");
            string entryTitle = Console.ReadLine();

            Console.Write("Digite o ano da série: ");
            int entryYear = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string entryDescription = Console.ReadLine();

            Series newSerie = new Series(id: indiceSerie,
              genrer: (Genrer)entryGenrer,
              title: entryTitle,
              year: entryYear,
              description: entryDescription
            );
            
            repository.Update(indiceSerie, newSerie);
        }
    }
}