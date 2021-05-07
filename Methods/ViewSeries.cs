using System;
using memory_app.classes;

namespace memory_app.Methods
{
    public class ViewSeries
    {
       public static SerieRepository repository = new SerieRepository(); 
       static void ViewSeriesMethod(string[] args)
       {
           Console.Write("Digite o id da série");
           int indiceSerie = int.Parse(Console.ReadLine()); 

           var serie = repository.ReturnForId(indiceSerie);  

           Console.WriteLine(serie);
       }  
    }
}