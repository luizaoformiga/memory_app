using memory_app.classes;

namespace memory_app
{
    public class Series : EntityBase
    {
        // atributes
        private Genrer Genrer { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool Excludes { get; set; }

        // methods 
        public Series(int id, Genrer genrer, string title, string description, int year)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Excludes = false;
        }

        public override string ToString()
        {
            // enviroment
            string returnsMethod = "";
            returnsMethod += "Genrer: " + this.Genrer; //+ Enviroment.NewLine;
            returnsMethod += "Title: " + this.Title; //+ Environment.NewLine;
            returnsMethod += "Description: " + this.Description; //+ Environment.NewLine;
            returnsMethod += "Years: " + this.Year;

            return returnsMethod;
        }
       
        public string returnTitle()
        {
            return this.Title;
        }

        public int returnId() 
        {
            return this.Id;
        }

        public bool ReturnExcludes()
        {
            return this.Excludes;
        } 
        public void ExcludesId()
        {
            this.Excludes = true;
        }
    }
}