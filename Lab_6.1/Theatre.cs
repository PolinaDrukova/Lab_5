using System.Collections.Generic;

namespace Lab_6._1
{
    static partial class Program
    {
        public class Theatre : PublicBuilding
        {


            public int capacity;
            public List<Performances> performances;

            public Theatre(string appointment, int floors, int square, int height, string name, int capacity, params Performances[] performances)
            {
                this.Floors = floors;
                this.Square = square;
                this.Height = height;
                this.Appointment = appointment;
                this.Name = name;
                this.capacity = capacity;
                this.performances = new List<Performances>(performances);

            }


            public override void ChangeAppointment(string appointment) //изменить назначение здания
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



            public int GetCapacity()
            {
                return capacity;
            }


            public List<Performances> GetPerf()
            {
                List<Performances> perf = new List<Performances>();

                foreach (Performances p in performances)
                {
                    perf.Add(p);
                }

                return perf;
            }



        }

    }
}
