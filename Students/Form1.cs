using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class Form1 : Form
    {
        static StudentsList studentsManager = new StudentsList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            studentsManager.Add(new Student("3343433", "Dennis", "Greenberg",26, 100,200));
            studentsManager.Add(new Student("44645456", "Cristiano", "Ronaldo",36, 77,30));
            studentsManager.Add(new Student("34354565", "Lionel", "Messi",34,100,40));
            studentsManager.Add(new Student("465466464", "Sergio", "Ramos",35,400,30));
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            FilterBox.Text = string.Empty;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            FilterBox.Text = string.Empty;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            FilterBox.Text = string.Empty;
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            FilterBox.Text = string.Empty;
        }

        private void bSearch_MouseEnter(object sender, EventArgs e)
        {
            bSearch.BackColor = Color.Crimson;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string selectedfillter = SearchComboBox.Text;
            List<Student> list1 = new List<Student>();
            switch (selectedfillter)
            {
                case "Search By Id":
                    list1 = studentsManager.Filter(Fillter.FilterById, FilterBox.Text);
                    break;
                case "Search By FirstName":
                    list1 = studentsManager.Filter(Fillter.FilterByFirstName, FilterBox.Text);
                    break;
                case "Search By LastName":
                    list1 = studentsManager.Filter(Fillter.FilterByLastName, FilterBox.Text);
                    break;
                case "Search By Grade":
                    list1 = studentsManager.Filter(Fillter.FilterByGrade, FilterBox.Text); break;
                default:
                    MessageBox.Show("PLiz select fillter");
                    break;
            }
            SortView.DataSource = list1;
        }

        private void IdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Checkbox_MouseClick(object sender, MouseEventArgs e)
        {
            //Checkbox.Text = string.Empty;
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            CheckDelegate checkgradedelegate;
            CheckDelegate checkfirstchardelegate;
            if (checkGrade.Checked)
            {
                checkgradedelegate = Fillter.GradeBelow50;

                if (studentsManager.Contains(checkgradedelegate))
                {
                    MessageBox.Show("True");
                }
                else
                {
                    MessageBox.Show("False");
                }

            }
            if (checkFirstChar.Checked)
            {
                checkfirstchardelegate = Fillter.SameFirstCharFLNames;

                if (studentsManager.Contains(checkfirstchardelegate))
                {
                    MessageBox.Show("True");
                }
                else
                {
                    MessageBox.Show("False");
                }
            }
        }

        private void Checkbox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void bSum_Click(object sender, EventArgs e)
        {
            SumDelegate SumDelegate;
            if (SumCombo.SelectedIndex == 0)
            {
                SumDelegate = Sums.PaymentSum;
                MessageBox.Show(studentsManager.Sum(SumDelegate, studentsManager.studentsList));

            }
            if (SumCombo.SelectedIndex == 1)
            {
                SumDelegate = Sums.NeedToPaySum;
                MessageBox.Show(studentsManager.Sum(SumDelegate, studentsManager.studentsList));

            }
        }

        private void bAverage_Click(object sender, EventArgs e)
        {
            AverageDelegate average;
            if(AverageBox.SelectedIndex == 0)
            {
                average = Averages.AverageAge;
               MessageBox.Show(Convert.ToString(studentsManager.Avrage(average)));
            }
            if (AverageBox.SelectedIndex == 1)
            {
                average = Averages.AverageGrade;
                MessageBox.Show(Convert.ToString(studentsManager.Avrage(average)));
            }
        }
    }
}
