namespace Lab_6._1
{
    static partial class Program
    {
        public class Departments
        {
            private string title;
            private string headOfDepartment;
            public Departments(string title, string headOfDepartment)
            {
                this.title = title;
                this.headOfDepartment = headOfDepartment;
            }

            public string GetTitle()
            {
                return title;
            }
            public string SetTitle(string title) => this.title = title;

            public string GetHeadOfDepartment()
            {
                return headOfDepartment;
            }

            public string SetHeadOfDepartment(string headOfDepartment) => this.headOfDepartment = headOfDepartment;

        }

    }
}
