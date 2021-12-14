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
           


                Performances a = new Performances("�������", 2);
                Performances b = new Performances("����������", 3);
                Performances c = new Performances("������ ���������", 2);
                Performances d = new Performances("��� � �������", 1);
                Performances e = new Performances("����������� �����", 3);
                Performances f = new Performances("������", 3);

                Theatre th1 = new Theatre("�����", 2, 2000, 100, "����� �������", 200, a, b);
                Theatre th2 = new Theatre("�����", 3, 1000, 100, "��������", 100, c, d);
                Theatre th3 = new Theatre("�����", 2, 2000, 100, "���", 200, e, f);

                List<Theatre> theaters = new List<Theatre>();
                theaters.Add(th1);
                theaters.Add(th2);
                theaters.Add(th3);

                Console.WriteLine("������ ������ ��������: ");
                foreach (Theatre th in theaters)
                {
                    Console.WriteLine(th.GetName());
                }


                Console.WriteLine(theaters[1].GetAppointment() + " " + theaters[1].GetName());
                Console.WriteLine("������ �������� " + theaters[1].GetSquare() + " ������");
                Console.WriteLine("����������� ������ ���������� " + theaters[1].GetCapacity() + " �������");
                Console.WriteLine("�����:");

                foreach (Performances pf in theaters[1].GetPerf())
                {
                    Console.WriteLine("���������: " + pf.GetTitle() + "(���������� �����: " + pf.GetNumberOfAction() + ")");
                }

                Console.WriteLine("<.....................................>");

                Subjects s1 = new Subjects("��������", "������� �����");
                Subjects s2 = new Subjects("������", "������� �����");
                Subjects s3 = new Subjects("�������", "������� �����");
                Subjects s4 = new Subjects("������", "��������� �����");

                School sch1 = new School("������� ���������", 4, 2000, 100, "����� ������", 2000, s1, s2, s3, s4);
                School sch2 = new School("������� ���������", 3, 1000, 80, "����� �������", 1000, s1, s2, s3, s4);
                School sch3 = new School("������� ���������", 4, 3000, 200, "����� �1", 3000, s1, s2, s3, s4);

                List<School> school = new List<School>();
                school.Add(sch1);
                school.Add(sch2);
                school.Add(sch3);


                Console.WriteLine("����� ������ ��������: ");
                foreach (School sch in school)
                {
                    Console.WriteLine(sch.GetName());
                }

                foreach (Subjects sb in school[1].GetSubj())
                {
                    Console.WriteLine("����������: " + sb.GetTitle() + "(������� ���������: " + sb.GetClasses() + ")");
                }

                Console.WriteLine("<.....................................>");

                Departments d1 = new Departments("��������� �����������������", "�.�.��������");
                Departments d2 = new Departments("��������� �������������", "�.�.��������");
                Departments d3 = new Departments("��������� ��������", "�.�.��������");

                Hospital hsp1 = new Hospital("�������� ����������", 4, 2000, 300, "���������������������� ��������", 1000, d1);
                Hospital hsp2 = new Hospital("�������� ����������", 3, 1000, 200, "������������������ ��������", 500, d2);
                Hospital hsp3 = new Hospital("�������� ����������", 2, 500, 100, "�������� �1", 500, d3);

                List<Hospital> hospital = new List<Hospital>();
                hospital.Add(hsp1);
                hospital.Add(hsp2);
                hospital.Add(hsp3);

                Console.WriteLine("�������� ������ ��������: ");
                foreach (Hospital hsp in hospital)
                {
                    Console.WriteLine(hsp.GetName());
                }

                foreach (Departments dep in hospital[1].GetDep())
                {
                    Console.WriteLine("���������: " + dep.GetTitle() + "(���������� ���������: " + dep.GetHeadOfDepartment() + ")");
                }


        }

    }
}
