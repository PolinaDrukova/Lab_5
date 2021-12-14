namespace Lab_6._1
{
    static partial class Program
    {
        public class Subjects
        {

            private string title;
            private string classes;
            public Subjects(string title, string classes)
            {
                this.title = title;
                this.classes = classes;
            }


            public string GetTitle()
            {
                return title;
            }
            public string SetTitle(string title) => this.title = title;

            public string GetClasses()
            {
                return classes;
            }

            public string SetClasses(string classes) => this.classes = classes;


        }

    }
}
