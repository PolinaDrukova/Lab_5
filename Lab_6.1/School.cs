using System.Collections.Generic;

namespace Lab_6._1
{
    static partial class Program
    {
        public class School : PublicBuilding
        {

            public int numberOfStudents;
            public List<Subjects> subjects;

            public School(string appointment, int floors, int square, int height, string name, int numberOfStudents, params Subjects[] subjects)
            {
                this.Floors = floors;
                this.Square = square;
                this.Height = height;
                this.Appointment = appointment;
                this.Name = name;
                this.numberOfStudents = numberOfStudents;
                this.subjects = new List<Subjects>(subjects);

            }

            

            public override void ChangeAppointment(string appointment)
            {
                this.Appointment = appointment;
            }

            public override void AddAnnexe(int s) //сделать притройку, увеличив площадь здания
            {
                this.Square = Square + s;
            }

            public override void FinishTheFloor(int f) //достроить этаж
            {
                this.Floors = f + Floors;
            }


            public int GetNumberOfStudents()
            {
                return numberOfStudents;
            }

            public List<Subjects> GetSubj()
            {
                List<Subjects> subj = new List<Subjects>();

                foreach (Subjects s in subjects)
                {
                    subj.Add(s);
                }

                return subj;
            }


        }

    }
}
