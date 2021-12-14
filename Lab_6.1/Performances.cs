namespace Lab_6._1
{
    static partial class Program
    {
        public class Performances

        {
            private string performanceTitle;
            private int numberOfAction;


            public Performances(string title, int numberOfAction)
            {
                this.performanceTitle = title;
                this.numberOfAction = numberOfAction;
            }

            public string GetTitle()
            {
                return performanceTitle;
            }

            public string SetTitle(string title) => this.performanceTitle = title;

            public int GetNumberOfAction()
            {
                return numberOfAction;
            }

            public int SetNumberOfAction(int action) => this.numberOfAction = action;

        }

    }
}
