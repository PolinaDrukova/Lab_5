using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6._1
{
    static partial class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           


                Performances a = new Performances("Золушка", 2);
                Performances b = new Performances("Снегурочка", 3);
                Performances c = new Performances("Спящая красавица", 2);
                Performances d = new Performances("Кот в сапогах", 1);
                Performances e = new Performances("Капитанская дочка", 3);
                Performances f = new Performances("Метель", 3);

                Theatre th1 = new Theatre("Театр", 2, 2000, 100, "Юного зрителя", 200, a, b);
                Theatre th2 = new Theatre("Театр", 3, 1000, 100, "Камерный", 100, c, d);
                Theatre th3 = new Theatre("Театр", 2, 2000, 100, "Кот", 200, e, f);

                List<Theatre> theaters = new List<Theatre>();
                theaters.Add(th1);
                theaters.Add(th2);
                theaters.Add(th3);

                Console.WriteLine("Театры города Воронежа: ");
                foreach (Theatre th in theaters)
                {
                    Console.WriteLine(th.GetName());
                }


                Console.WriteLine(theaters[1].GetAppointment() + " " + theaters[1].GetName());
                Console.WriteLine("Здание площадью " + theaters[1].GetSquare() + " метров");
                Console.WriteLine("Вместимость театра составляет " + theaters[1].GetCapacity() + " человек");
                Console.WriteLine("Афиша:");

                foreach (Performances pf in theaters[1].GetPerf())
                {
                    Console.WriteLine("Спектакль: " + pf.GetTitle() + "(количество актов: " + pf.GetNumberOfAction() + ")");
                }

                Console.WriteLine("<.....................................>");

                Subjects s1 = new Subjects("Биология", "Средняя школа");
                Subjects s2 = new Subjects("Физика", "Средняя школа");
                Subjects s3 = new Subjects("История", "Средняя школа");
                Subjects s4 = new Subjects("Чтение", "Начальная школа");

                School sch1 = new School("Учебное заведение", 4, 2000, 100, "Имени Бунина", 2000, s1, s2, s3, s4);
                School sch2 = new School("Учебное заведение", 3, 1000, 80, "Имени Маршака", 1000, s1, s2, s3, s4);
                School sch3 = new School("Учебное заведение", 4, 3000, 200, "Лицей №1", 3000, s1, s2, s3, s4);

                List<School> school = new List<School>();
                school.Add(sch1);
                school.Add(sch2);
                school.Add(sch3);


                Console.WriteLine("Школы города Воронежа: ");
                foreach (School sch in school)
                {
                    Console.WriteLine(sch.GetName());
                }

                foreach (Subjects sb in school[1].GetSubj())
                {
                    Console.WriteLine("Дисциплина: " + sb.GetTitle() + "(уровень школьника: " + sb.GetClasses() + ")");
                }

                Console.WriteLine("<.....................................>");

                Departments d1 = new Departments("Отделение гастроэнтерологии", "И.В.Пирожков");
                Departments d2 = new Departments("Отделение офтальмологии", "И.Г.Миронова");
                Departments d3 = new Departments("Отделение хирургии", "К.В.Костяков");

                Hospital hsp1 = new Hospital("Лечебное учреждение", 4, 2000, 300, "Гастроэнтерологическая больница", 1000, d1);
                Hospital hsp2 = new Hospital("Лечебное учреждение", 3, 1000, 200, "Офтольмологическая больница", 500, d2);
                Hospital hsp3 = new Hospital("Лечебное учреждение", 2, 500, 100, "Больница №1", 500, d3);

                List<Hospital> hospital = new List<Hospital>();
                hospital.Add(hsp1);
                hospital.Add(hsp2);
                hospital.Add(hsp3);

                Console.WriteLine("Больницы города Воронежа: ");
                foreach (Hospital hsp in hospital)
                {
                    Console.WriteLine(hsp.GetName());
                }

                foreach (Departments dep in hospital[1].GetDep())
                {
                    Console.WriteLine("Отделение: " + dep.GetTitle() + "(Заведующий Отделения: " + dep.GetHeadOfDepartment() + ")");
                }


        }

    }
}
