using System.Collections.Generic;

namespace Lab_6._1
{
    static partial class Program
    {
        public class Hospital : PublicBuilding
        {

            private int capacity;
            public List<Departments> departments;
            

            public Hospital(string appointment, int floors, int square, int height, string name, int capacity, params Departments[] departments)
            {
                this.Floors = floors;
                this.Square = square;
                this.Height = height;
                this.Appointment = appointment;
                this.Name = name;
                this.capacity = capacity;
                this.departments = new List<Departments>(departments);


            }

            public int GetCapacity()
            {
                return capacity;
            }

            public override void AddAnnexe(int s) //сделать притройку, увеличив площадь здания
            {
                this.Square = Square + s;
            }

            public override void FinishTheFloor(int f) //достроить этаж
            {
                this.Floors = f + Floors;
            }

            public override void ChangeAppointment(string appointment)
            {
                this.Appointment = appointment;
            }

       

            public List<Departments> GetDep()
            {
                List<Departments> dep = new List<Departments>();

                foreach (Departments d in departments)
                {
                    dep.Add(d);
                }

                return dep;
            }


        }

    }
}
