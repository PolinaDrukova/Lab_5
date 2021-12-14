using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab_6._1.Program;

namespace Lab_6._1
{
    public partial class Form1 : Form
    {
        
        private Theatre th1 = new Theatre("Театр", 2, 2000, 100, "Юного зрителя", 200);
       
        private School sch1 = new School("Учебное заведение", 4, 2000, 100, "Имени Бунина", 2000);

        private Hospital hsp1 = new Hospital("Лечебное учреждение", 4, 2000, 300, "Гастроэнтерологическая больница", 1000);
       

        private TextBox tb;
        private int indexBuild = 0;
        private int indexVoid = 0;

        public Form1()
        {
            
            InitializeComponent();
            tb = new TextBox();
            tb.SetBounds(5, 5, 300, 300);
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.AppendText("C:/Users/Полина/source/repos/Lab_6.1/Lab_6.1");
            this.Controls.Add(tb);
            Button b = new Button();

            b.Text = "Найти";
            b.Left = tb.Left;
            b.Top = tb.Bottom + 10;
            b.Width = 200;
            b.Height = 25;
            b.Click += OnButton;
            this.Controls.Add(b);

        }

        public void OnButton(object obj, EventArgs ea)
        {
            Controls.Clear();
            string path = tb.Text;
            var classes = getClasses(path);
            string[] cl = new String[3];
            for (int i = 0; i < classes.Count; i++)
            {
                cl[i] = classes[i];
            }

            comboBox1 = new ComboBox();
            comboBox1.Items.AddRange(cl);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = indexBuild;
            comboBox1.SetBounds(5, 5, 250, 200);
            comboBox1.SelectedIndexChanged += OnItemChangedBuild;
            this.Controls.Add(comboBox1);
            Button b = new Button();
            b.Text = "Выбрать";
            b.Left = comboBox1.Left;
            b.Top = comboBox1.Bottom + 10;
            b.Width = 200;
            b.Height = 30;
            b.Click += OnButton2;
           this.Controls.Add(b);
        }

        public void OnButton2(object obj, EventArgs ea)
        {
            String[] voids = getVoids();
            Controls.Clear();
            comboBox1 = new ComboBox();
            comboBox1.Items.AddRange(voids);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = indexVoid;
            comboBox1.SetBounds(5, 5, 250, 200);
            comboBox1.SelectedIndexChanged += OnItemChangedVoid;
            this.Controls.Add(comboBox1);
            Button b = new Button();
            Button b2 = new Button();
            Button b3 = new Button();
            b.Text = "Выбрать";
            b2.Text = "Назад";
            b3.Text = "Выйти";

            b3.Left = comboBox1.Left;
            b3.Top = comboBox1.Bottom + 70;
            b3.Width = 200;
            b3.Height = 30;
            b3.Click += OnButtonOk;

            b2.Left = comboBox1.Left;
            b2.Top = comboBox1.Bottom + 40;
            b2.Width = 200;
            b2.Height = 30;
            b2.Click += OnButton;

            b.Left = comboBox1.Left;
            b.Top = comboBox1.Bottom + 10;
            b.Width = 200;
            b.Height = 30;
            b.Click += OnButton3;

            this.Controls.Add(b);
            this.Controls.Add(b2);
            this.Controls.Add(b3);
        }
        public void OnButtonOk(object obj, EventArgs ea)
        {
            Application.Exit();
        }

        public void OnButtonEnter(object obj, EventArgs ea)
        {
            Controls.Clear();
            tb.Clear();
            tb.AppendText("Значение установлено");
            Controls.Add(tb);
            Button b = new Button();
            b.Left = comboBox1.Left;
            b.Top = comboBox1.Bottom + 10;
            b.Width = 200;
            b.Height = 25;
            b.Text = "OK";
            b.Click += OnButton2;
            Controls.Add(b);
        }

       
        public void OnButton3(object obj, EventArgs ea)
        {
            Button b = new Button();
            switch (indexVoid)
            {

                case 0:
                    switch (indexBuild)
                    {
                        case 0:
                            Controls.Clear();
                            tb.Clear();
                            tb.AppendText("Количество этажей: " + th1.GetFloors().ToString());
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                        case 1:
                            Controls.Clear();
                            tb.Clear();
                            tb.AppendText("Количество этажей: " + sch1.GetFloors().ToString());
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                        default:
                            Controls.Clear();
                            tb.Clear();
                            tb.AppendText("Количество этажей: " + hsp1.GetFloors().ToString());
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;

                    }
                    break;
                case 1:
                    switch (indexBuild)
                    {
                        case 0:
                            Controls.Clear();
                            tb.Clear();
                            tb.AppendText("Площадь здания: " + th1.GetSquare().ToString());

                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                        case 1:
                            Controls.Clear();
                            tb.Clear();
                            tb.AppendText("Площадь здания: " + sch1.GetSquare().ToString());

                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                        default:
                            Controls.Clear();
                            tb.Clear();
                            tb.AppendText("Площадь здания: " + hsp1.GetSquare().ToString());
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                    }

                    break;
                case 2:
                    switch (indexBuild)
                    {
                        case 0:
                            Controls.Clear();
                            tb.Clear();
                            tb.AppendText("Высота здания: " + th1.GetHeight().ToString());
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                        case 1:
                            Controls.Clear();
                            tb.Clear();
                            tb.AppendText("Высота здания: " + sch1.GetHeight().ToString());
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                        default:
                            Controls.Clear();
                            tb.Clear();
                            tb.AppendText("Высота здания: " + hsp1.GetHeight().ToString());
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                    }
                    break;
                case 3:
                    switch (indexBuild)
                    {
                        case 0:
                            Controls.Clear();
                            tb.Clear();
                            tb.AppendText("Название: " + th1.GetName().ToString());
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                        case 1:
                            Controls.Clear();
                            tb.Clear();
                            tb.AppendText("Название: " + sch1.GetName().ToString());
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                        default:
                            Controls.Clear();
                            tb.Clear();
                            tb.AppendText("Название: " + hsp1.GetName().ToString());
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                    }
                    break;
                case 4:
                    switch (indexBuild)
                    {
                        case 0:
                            Controls.Clear();
                            tb.Clear();
                            tb.AppendText("Назначение: " + th1.GetAppointment());
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                        case 1:
                            Controls.Clear();
                            tb.Clear();
                            tb.AppendText("Назначение: " + sch1.GetAppointment());
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                        default:
                            Controls.Clear();
                            tb.Clear();
                            tb.AppendText("Назначение: " + hsp1.GetAppointment());
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                    }
                    break;
                case 5:
                    switch (indexBuild)
                    {
                        case 0:
                            Controls.Clear();
                            tb.Clear();
                            int i;
                            var n = int.TryParse(tb.Text, out i);
                            th1.FinishTheFloor(i);
                            Controls.Add(tb);

                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "Ok";
                            b.Click += OnButtonEnter;
                            Controls.Add(b);
                            break;
                        case 1:
                            Controls.Clear();
                            tb.Clear();
                            int j = Convert.ToInt32(tb.Text);
                            sch1.FinishTheFloor(j);
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                        default:
                            Controls.Clear();
                            tb.Clear();
                            int k = Convert.ToInt32(tb.Text);
                            hsp1.FinishTheFloor(k);
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                    }
                    break;
                case 7:
                    switch (indexBuild)
                    {
                        case 0:
                            Controls.Clear();
                            tb.Clear();
                            th1.ChangeAppointment(tb.Text.ToString());

                            Controls.Add(tb);

                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "Ok";
                            b.Click += OnButtonEnter;
                            Controls.Add(b);
                            break;
                        case 1:
                            Controls.Clear();
                            tb.Clear();

                            sch1.ChangeAppointment(tb.Text.ToString());
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                        default:
                            Controls.Clear();
                            tb.Clear();

                            hsp1.ChangeAppointment(tb.Text.ToString());
                            Controls.Add(tb);
                            b = new Button();
                            b.Left = comboBox1.Left;
                            b.Top = comboBox1.Bottom + 10;
                            b.Width = 200;
                            b.Height = 25;
                            b.Text = "OK";
                            b.Click += OnButton2;
                            Controls.Add(b);
                            break;
                    }
                    break;
                default:
                    Controls.Clear();
                    tb.Clear();
                    Controls.Add(tb);
                    b = new Button();
                    b.Left = comboBox1.Left;
                    b.Top = comboBox1.Bottom + 10;
                    b.Width = 200;
                    b.Height = 25;
                    b.Text = "Ok";
                    b.Click += OnButtonEnter;
                    Controls.Add(b);
                    break;
            }
        }

        private void OnItemChangedBuild(object obj, EventArgs ea)
        {
            indexBuild = comboBox1.SelectedIndex;
        }

        private void OnItemChangedVoid(object obj, EventArgs ea)
        {
            indexVoid = comboBox1.SelectedIndex;
        }

       

        public string[] getVoids()

        {
            //Type myType = typeof(IBuilding);
            //myType.GetMethods();
            //Console.WriteLine(myType.GetMethods()[0]/);

            string[] s =
            {
                "getFloors", "getSquare", "getHeight", "getName", "getAppointment", "FinishTheFloor", "AddAnnexe", "ChangeAppointment"
               
            };
            return s;
        }

        public List<String> getClasses(string path)
        {

            List<String> list = new List<String>();
           
           list.Add("Theatre");
           list.Add("School");
           list.Add("Hospital");

            return list;
        }

       

       
    }
}
