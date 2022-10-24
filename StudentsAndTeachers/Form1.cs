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

        ListHuman listHuman = new ListHuman();

        public Menu()
        {
            InitializeComponent();
            PersonRegestrationRadioButton.Checked = true;
            Panel_change();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int counthumans = listHuman.Counts();
            Human[] human = new Human[counthumans + 1];
            human[counthumans] = new Human(NameTextBox.Text, SurnameTextBox.Text, SelectedGender(), AgeComboBox.SelectedIndex, Convert.ToDouble(HeightTextBox.Text), Convert.ToDouble(WeightTextBox.Text), HabbitsCheckBox.Checked, EmailTextBox.Text, Nation_Convector(), new Adress(CountryTextBox.Text, CityTextBox.Text, StreetTextBox.Text, int.Parse(HouseTextBox.Text)));
            listHuman.Add(human[counthumans]);
            listHuman.TextsWriter("E:\\Github_rep\\CSharp\\StudentAndTeacher\\TEst\\test1.txt");
            clearAll();
        }
        private void clearAll()
        {
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            AgeComboBox.SelectedIndex = -1;
            HeightTextBox.Clear();
            WeightTextBox.Clear();
            HabbitsCheckBox.Checked = false;
            EmailTextBox.Clear();
            NationComboBox.SelectedIndex = -1;
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            HouseTextBox.Clear();

        }
        private Nation Nation_Convector()
        {
            if (NationComboBox.SelectedIndex == 0) { return Nation.Ukranian; }
            if (NationComboBox.SelectedIndex == 1) { return Nation.French; }
            if (NationComboBox.SelectedIndex == 2) { return Nation.Polish; }
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
            listHuman.Show();
        }

        private void Panel_change()
        {
            RadioButton PersonradioButton = (RadioButton)PersonRegestrationRadioButton;
            RadioButton TeacherradioButton = (RadioButton)TeacherRegestrationRadioButton;
            RadioButton StudentradioButton = (RadioButton)StudentRegestrationRadioButton;

            if (PersonradioButton.Checked)
            {

                PersonRegistrationLabel.Text = "Person Registration";
                Previewlabel.Text = "Preview Person";
                GroupSalaryTextBox.Visible = false;
                SalaryGroupLabel.Visible = false;
                MoneyDepartmentlabel.Visible = false;
                MoneyDepartmenttextBox.Visible = false;
                Numofseatslabel.Visible = false;
                NumofseatstextBox.Visible = false;
                CourseWorkLAble.Visible = false;

            }


        }
    }
}

