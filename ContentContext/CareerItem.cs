namespace Balta.ContentContext
{
    public class CareerItem
    {
        //public IList<string> Notifications { get; set; }

        public CareerItem(int ordem, string title, string description, Course course)
        {
            if(course==null)
            {
                throw new System.Exception("O curso não pode ser Nulo!");
            }
            Ordem = ordem;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Ordem{ get; set; }
        public string Title {get; set;}
        public string Description {get; set;}
        public Course Course { get; set;}
    }
}