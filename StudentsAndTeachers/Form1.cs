using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsAndTeachers
{
    public partial class Menu : Form
    {

        private ListHuman listHuman = new ListHuman();
        private ListStudent listStudent = new ListStudent();
        private ListTeacher listTeacher = new ListTeacher();
        private Human[] human = new Human[1];
        private Student[] students = new Student[1];
        private Teacher[] teacher = new Teacher[1];

        public Menu()
        {
            
            InitializeComponent();
            Startsetings();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            RadioButton PersonradioButton = (RadioButton)PersonRegestrationRadioButton;
            RadioButton TeacherradioButton = (RadioButton)TeacherRegestrationRadioButton;
            RadioButton StudentradioButton = (RadioButton)StudentRegestrationRadioButton;

            if (PersonradioButton.Checked) { 
            int counthumans = listHuman.Counts();
            this.human = new Human[counthumans+1];
            human[counthumans] = new Human(NameTextBox.Text, SurnameTextBox.Text, SelectedGender(), AgeComboBox.SelectedIndex, Convert.ToDouble(HeightTextBox.Text), Convert.ToDouble(WeightTextBox.Text), HabbitsCheckBox.Checked, EmailTextBox.Text, Nation_Convector(), new Adress(CountryTextBox.Text, CityTextBox.Text, StreetTextBox.Text, int.Parse(HouseTextBox.Text)));
            listHuman.Add(human[counthumans]);
            listHuman.TextsWriter("Humantest.txt");
            }
            if (TeacherradioButton.Checked)
            {
                int countteachet = listTeacher.Counts();
                this.teacher = new Teacher[countteachet + 1];
                teacher[countteachet] = new Teacher(NameTextBox.Text, SurnameTextBox.Text, SelectedGender(), AgeComboBox.SelectedIndex, Convert.ToDouble(HeightTextBox.Text), Convert.ToDouble(WeightTextBox.Text), HabbitsCheckBox.Checked, EmailTextBox.Text, Nation_Convector(), new Adress(CountryTextBox.Text, CityTextBox.Text, StreetTextBox.Text, int.Parse(HouseTextBox.Text)), int.Parse(GroupSalaryTextBox.Text),MoneyDepartmenttextBox.Text, int.Parse(NumofseatstextBox.Text),(KeyWords)CourseWorkSelect());
                listTeacher.Add(teacher[countteachet]);
                listTeacher.TextsWriter("Teachertest.txt");
            }
            if (StudentradioButton.Checked)
            {
                int countstudent = listStudent.Counts();
                this.students = new Student[countstudent + 1];
                students[countstudent] = new Student(NameTextBox.Text, SurnameTextBox.Text, SelectedGender(), AgeComboBox.SelectedIndex, Convert.ToDouble(HeightTextBox.Text), Convert.ToDouble(WeightTextBox.Text), HabbitsCheckBox.Checked, EmailTextBox.Text, Nation_Convector(), new Adress(CountryTextBox.Text, CityTextBox.Text, StreetTextBox.Text, int.Parse(HouseTextBox.Text)), int.Parse(GroupSalaryTextBox.Text), int.Parse(MoneyDepartmenttextBox.Text),(Key)CourseWorkSelect());
                listStudent.Add(students[countstudent]);
                listStudent.TextsWriter("Studenttest.txt");
            }
            clearAll();
            PreviewButton.Visible = true;
        }
        private void clearAll()
        {
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            AgeComboBox.SelectedIndex = -1;
            HeightTextBox.Clear();
            WeightTextBox.Clear();
            GenderMaleRadioButton.Checked = false;
            GenderFemaleRadioButton.Checked = false;
            HabbitsCheckBox.Checked = false;
            EmailTextBox.Clear();
            NationComboBox.SelectedIndex = -1;
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            HouseTextBox.Clear();
            GroupSalaryTextBox.Clear();
            MoneyDepartmenttextBox.Clear();
            NumofseatstextBox.Clear();
            CourseWorkcomboBox.SelectedIndex = -1;


        }
       private void Startsetings()
        {
            for (int i = 100; i > 0; i--)
            {
                AgeComboBox.Items.AddRange(new object[] {
                    i
                });
            }
            PreviewButton.Visible = false;
            Panel_change();
            PersonRegestrationRadioButton.Checked = true;
        }
        private Nation Nation_Convector()
        {
            if (NationComboBox.SelectedIndex == 0) { return Nation.Ukranian; }
            if (NationComboBox.SelectedIndex == 1) { return Nation.French; }
            if (NationComboBox.SelectedIndex == 2) { return Nation.Polish; }
            return 0;
        }
        private object CourseWorkSelect()
        {
            RadioButton TeacherradioButton = (RadioButton)TeacherRegestrationRadioButton;
            RadioButton StudentradioButton = (RadioButton)StudentRegestrationRadioButton;
            if (TeacherradioButton.Checked)
            {
                if (NationComboBox.SelectedIndex == 0) { return KeyWords.csharp; }
                if (NationComboBox.SelectedIndex == 1) { return KeyWords.python; }
                if (NationComboBox.SelectedIndex == 2) { return KeyWords.java; }
                if (NationComboBox.SelectedIndex == 3) { return KeyWords.JS; }

            }
            if (StudentradioButton.Checked)
            {
                if (NationComboBox.SelectedIndex == 0) { return Key.csharp; }
                if (NationComboBox.SelectedIndex == 1) { return Key.python; }
                if (NationComboBox.SelectedIndex == 2) { return Key.java; }
                if (NationComboBox.SelectedIndex == 3) { return Key.JS; }

            }

            return 0;
        }

        private Gender SelectedGender()
        {
            RadioButton maleradioButton = (RadioButton)GenderMaleRadioButton;
            RadioButton femaleradioButton = (RadioButton)GenderFemaleRadioButton;
            if (maleradioButton.Checked)
            {
                return Gender.Male;
            }
            if (femaleradioButton.Checked)
            {
                return Gender.Female;
            }
            return 0;

        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            int counthumans = listHuman.Counts();
            int countstudent = listStudent.Counts();
            int countteachet = listTeacher.Counts();
            RadioButton PersonradioButton = (RadioButton)PersonRegestrationRadioButton;
            RadioButton TeacherradioButton = (RadioButton)TeacherRegestrationRadioButton;
            RadioButton StudentradioButton = (RadioButton)StudentRegestrationRadioButton;
            HSTSelectorComboBox1.Text = "";
            HSTSelectorComboBox1.Items.Clear();
            HSTSelectorComboBox1.SelectedIndex = -1;
            InfoLabel.Text = " ";
            if (PersonradioButton.Checked)
            {

                for (int i = 0; i < counthumans; i++)
                {
                    HSTSelectorComboBox1.Items.AddRange(new object[]{
                         human[i].Name + " " + human[i].Surname
                }); 
                }
                listHuman.Show();
            }
            if (TeacherradioButton.Checked)
            {
                
                for (int j = 0; j < countteachet; j++)
                {
                    HSTSelectorComboBox1.Items.AddRange(new object[]{
                        teacher[j].Name +" " + teacher[j].Surname
                });
                }
                listTeacher.Show();
            }
            if (StudentradioButton.Checked)
            {
                
                for (int k = 0; k < countstudent; k++)
                {
                    HSTSelectorComboBox1.Items.AddRange(new object[]{
                        students[k].Name +" " + students[k].Surname
                });
                }
                listStudent.Show();
            }

        }

        private void Panel_change()
        {
            RadioButton PersonradioButton = (RadioButton)PersonRegestrationRadioButton;
            RadioButton TeacherradioButton = (RadioButton)TeacherRegestrationRadioButton;
            RadioButton StudentradioButton = (RadioButton)StudentRegestrationRadioButton;

            if (PersonradioButton.Checked)
            {

                PersonRegistrationLabel.Text = "Person Registration";
                Human_student_teacher_Lable.Text = "Selected Person";
                Previewlabel.Text = "Preview Person";
                GroupSalaryTextBox.Visible = false;
                SalaryGroupLabel.Visible = false;
                MoneyDepartmentlabel.Visible = false;
                MoneyDepartmenttextBox.Visible = false;
                Numofseatslabel.Visible = false;
                NumofseatstextBox.Visible = false;
                CourseWorkLAble.Visible = false;
                CourseWorkcomboBox.Visible = false;

            }
            if (StudentradioButton.Checked)
            {
                PersonRegistrationLabel.Text = "Studen Registration";
                Human_student_teacher_Lable.Text = "Selected Studen";
                Previewlabel.Text = "Preview Studen";
                GroupSalaryTextBox.Visible = true;
                SalaryGroupLabel.Visible = true;
                SalaryGroupLabel.Text = "Group";
                MoneyDepartmentlabel.Visible = true;
                MoneyDepartmentlabel.Text = "Money";
                MoneyDepartmenttextBox.Visible = true;
                Numofseatslabel.Visible = false;
                NumofseatstextBox.Visible = false;
                CourseWorkLAble.Visible = true;
                CourseWorkcomboBox.Visible = true;
                CourseWorkcomboBox.Items.Clear();
                CourseWorkcomboBox.Items.AddRange(new object[]{
                    "csharp",
                    "python",
                    "java",
                    "JS"
                });
            }
            if (TeacherradioButton.Checked)
            {
                PersonRegistrationLabel.Text = "Teacher Registration";
                Human_student_teacher_Lable.Text = "Selected Teacher";
                Previewlabel.Text = "Preview Teacher";
                GroupSalaryTextBox.Visible = true;
                SalaryGroupLabel.Visible = true;
                SalaryGroupLabel.Text = "Salary";
                MoneyDepartmentlabel.Text = "Department";
                MoneyDepartmentlabel.Visible = true;
                MoneyDepartmenttextBox.Visible = true;
                Numofseatslabel.Visible = true;
                NumofseatstextBox.Visible = true;
                CourseWorkLAble.Visible = true;
                CourseWorkcomboBox.Visible = true;
                CourseWorkcomboBox.Items.Clear();
                CourseWorkcomboBox.Items.AddRange(new object[]{
                    "csharp",
                    "python",
                    "java",
                    "JS"
                });
            }
            clearAll();
            HSTSelectorComboBox1.Items.Clear();
            HSTSelectorComboBox1.SelectedIndex = -1;
            InfoLabel.Text = " ";
            HSTSelectorComboBox1.Text = "";
        }

        private void PersonRegestrationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Panel_change();
        }

        private void StudentRegestrationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Panel_change();
        }

        private void TeacherRegestrationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Panel_change();
        }

        private void HSTSelectorComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioButton PersonradioButton = (RadioButton)PersonRegestrationRadioButton;
            RadioButton TeacherradioButton = (RadioButton)TeacherRegestrationRadioButton;
            RadioButton StudentradioButton = (RadioButton)StudentRegestrationRadioButton;
            if (PersonradioButton.Checked)
            {
                if (HSTSelectorComboBox1.SelectedIndex == -1)
                {
                    InfoLabel.Text = " ";
                }
                else
                {
                    InfoLabel.Text =
                    "Name " + human[HSTSelectorComboBox1.SelectedIndex].Name + "\n" +
                    "Surname " + human[HSTSelectorComboBox1.SelectedIndex].Surname + "\n" +
                    "Gender " + human[HSTSelectorComboBox1.SelectedIndex].Gender + "\n" +
                    "Age " + human[HSTSelectorComboBox1.SelectedIndex].Age + "\n" +
                    "Height " + human[HSTSelectorComboBox1.SelectedIndex].Height + "\n" +
                    "Weight " + human[HSTSelectorComboBox1.SelectedIndex].Weight + "\n" +
                    "Habbits " + human[HSTSelectorComboBox1.SelectedIndex].Habbits + "\n" +
                    "Email " + human[HSTSelectorComboBox1.SelectedIndex].Email + "\n" +
                    "Nation " + human[HSTSelectorComboBox1.SelectedIndex].Nation + "\n" +
                    "Country " + human[HSTSelectorComboBox1.SelectedIndex].Adress.Country + "\n" +
                    "City " + human[HSTSelectorComboBox1.SelectedIndex].Adress.City + "\n" +
                    "Street " + human[HSTSelectorComboBox1.SelectedIndex].Adress.Street + "\n" +
                    "House " + human[HSTSelectorComboBox1.SelectedIndex].Adress.House;
                }
            }
            if (TeacherradioButton.Checked)
            {
                if (HSTSelectorComboBox1.SelectedIndex == -1)
                {
                    InfoLabel.Text = " ";
                }
                else
                {
                    InfoLabel.Text =
                "Name " + teacher[HSTSelectorComboBox1.SelectedIndex].Name + "\n" +
                "Surname " + teacher[HSTSelectorComboBox1.SelectedIndex].Surname + "\n" +
                "Gender " + teacher[HSTSelectorComboBox1.SelectedIndex].Gender + "\n" +
                "Age " + teacher[HSTSelectorComboBox1.SelectedIndex].Age + "\n" +
                "Height " + teacher[HSTSelectorComboBox1.SelectedIndex].Height + "\n" +
                "Weight " + teacher[HSTSelectorComboBox1.SelectedIndex].Weight + "\n" +
                "Habbits " + teacher[HSTSelectorComboBox1.SelectedIndex].Habbits + "\n" +
                "Email " + teacher[HSTSelectorComboBox1.SelectedIndex].Email + "\n" +
                "Nation " + teacher[HSTSelectorComboBox1.SelectedIndex].Nation + "\n" +
                "Country " + teacher[HSTSelectorComboBox1.SelectedIndex].Adress.Country + "\n" +
                "City " + teacher[HSTSelectorComboBox1.SelectedIndex].Adress.City + "\n" +
                "Street " + teacher[HSTSelectorComboBox1.SelectedIndex].Adress.Street + "\n" +
                "House " + teacher[HSTSelectorComboBox1.SelectedIndex].Adress.House + "\n" +
                "Salary " + teacher[HSTSelectorComboBox1.SelectedIndex].Salary + "\n" +
                "Department " + teacher[HSTSelectorComboBox1.SelectedIndex].Department + "\n" +
                "Num of seats " + teacher[HSTSelectorComboBox1.SelectedIndex].NumOfSeats + "\n" +
                "Cours Work Theme " + teacher[HSTSelectorComboBox1.SelectedIndex].KeyWords + "\n";
                }
            }
            if (StudentradioButton.Checked)
            {
                if (HSTSelectorComboBox1.SelectedIndex == -1)
                {
                    InfoLabel.Text = " ";
                }
                else
                {
                    InfoLabel.Text =
                "Name " + students[HSTSelectorComboBox1.SelectedIndex].Name + "\n" +
                "Surname " + students[HSTSelectorComboBox1.SelectedIndex].Surname + "\n" +
                "Gender " + students[HSTSelectorComboBox1.SelectedIndex].Gender + "\n" +
                "Age " + students[HSTSelectorComboBox1.SelectedIndex].Age + "\n" +
                "Height " + students[HSTSelectorComboBox1.SelectedIndex].Height + "\n" +
                "Weight " + students[HSTSelectorComboBox1.SelectedIndex].Weight + "\n" +
                "Habbits " + students[HSTSelectorComboBox1.SelectedIndex].Habbits + "\n" +
                "Email " + students[HSTSelectorComboBox1.SelectedIndex].Email + "\n" +
                "Nation " + students[HSTSelectorComboBox1.SelectedIndex].Nation + "\n" +
                "Country " + students[HSTSelectorComboBox1.SelectedIndex].Adress.Country + "\n" +
                "City " + students[HSTSelectorComboBox1.SelectedIndex].Adress.City + "\n" +
                "Street " + students[HSTSelectorComboBox1.SelectedIndex].Adress.Street + "\n" +
                "House " + students[HSTSelectorComboBox1.SelectedIndex].Adress.House +
                 "Group  " + students[HSTSelectorComboBox1.SelectedIndex].Group + "\n" +
                "Money  " + students[HSTSelectorComboBox1.SelectedIndex].Money + "\n" +
                "Cours Work " + students[HSTSelectorComboBox1.SelectedIndex].Key + "\n";
                }
            }
            
        }
    }
}

