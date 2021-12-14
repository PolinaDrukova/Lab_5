namespace Lab_6._1
{
    static partial class Program
    {
        public interface IBuilding
        {
            string Appointment { get; set; }

            int GetFloors();

            int GetSquare();

            string GetName();

            string GetAppointment();


        }

    }
}
