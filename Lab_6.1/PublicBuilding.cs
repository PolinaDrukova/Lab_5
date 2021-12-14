namespace Lab_6._1
{
    static partial class Program
    {
        public abstract class PublicBuilding : IBuilding
        {

            protected int Floors { get; set; }
            protected int Square { get; set; }
            protected int Height { get; set; }


            public string Name { get; set; }

            public string Appointment { get; set; }

            public int GetFloors()
            {
                return Floors;
            }

            public int GetSquare()
            {
                return Square;
            }
            public int GetHeight()
            {
                return Height;
            }

            public string GetAppointment()
            {
                return Appointment;
            }


            public string GetName()
            {
                return Name;
            }

            public abstract void FinishTheFloor(int floors);

            public abstract void AddAnnexe(int square);

            public abstract void ChangeAppointment(string appointment);


        }

    }
}
