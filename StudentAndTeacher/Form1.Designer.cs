
namespace StudentAndTeacher
{
    partial class PersonRegistration
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label GenderLabel;
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.SurnameLable = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.AgeComboBox = new System.Windows.Forms.ComboBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel2 = new System.Windows.Forms.Label();
            this.GenderMaleRadioButton = new System.Windows.Forms.RadioButton();
            this.GenderFemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.HabbitsLabel = new System.Windows.Forms.Label();
            this.HabbitsCheckBox = new System.Windows.Forms.CheckBox();
            this.NationComboBox = new System.Windows.Forms.ComboBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.HouseTextBox = new System.Windows.Forms.TextBox();
            this.HouseLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.NationLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.PreviewButton = new System.Windows.Forms.Button();
            this.BackToMenuButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            GenderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new System.Drawing.Point(109, 203);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new System.Drawing.Size(42, 13);
            GenderLabel.TabIndex = 18;
            GenderLabel.Text = "Gender";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(94, 92);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(144, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(266, 92);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(144, 20);
            this.SurnameTextBox.TabIndex = 2;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(266, 227);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(179, 20);
            this.EmailTextBox.TabIndex = 3;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(153, 66);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(35, 13);
            this.Namelabel.TabIndex = 4;
            this.Namelabel.Text = "Name";
            // 
            // SurnameLable
            // 
            this.SurnameLable.AutoSize = true;
            this.SurnameLable.Location = new System.Drawing.Point(312, 66);
            this.SurnameLable.Name = "SurnameLable";
            this.SurnameLable.Size = new System.Drawing.Size(49, 13);
            this.SurnameLable.TabIndex = 5;
            this.SurnameLable.Text = "Surname";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(339, 203);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "Email";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(150, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(245, 33);
            this.label.TabIndex = 7;
            this.label.Text = "Person Registration";
            // 
            // AgeComboBox
            // 
            this.AgeComboBox.FormattingEnabled = true;
            this.AgeComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.AgeComboBox.Location = new System.Drawing.Point(112, 166);
            this.AgeComboBox.Name = "AgeComboBox";
            this.AgeComboBox.Size = new System.Drawing.Size(52, 21);
            this.AgeComboBox.TabIndex = 8;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(122, 141);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(26, 13);
            this.AgeLabel.TabIndex = 9;
            this.AgeLabel.Text = "Age";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(205, 166);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(75, 20);
            this.HeightTextBox.TabIndex = 10;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(315, 166);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(63, 20);
            this.WeightTextBox.TabIndex = 11;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(224, 141);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(38, 13);
            this.HeightLabel.TabIndex = 12;
            this.HeightLabel.Text = "Height";
            // 
            // WeightLabel2
            // 
            this.WeightLabel2.AutoSize = true;
            this.WeightLabel2.Location = new System.Drawing.Point(329, 141);
            this.WeightLabel2.Name = "WeightLabel2";
            this.WeightLabel2.Size = new System.Drawing.Size(41, 13);
            this.WeightLabel2.TabIndex = 13;
            this.WeightLabel2.Text = "Weight";
            // 
            // GenderMaleRadioButton
            // 
            this.GenderMaleRadioButton.AutoSize = true;
            this.GenderMaleRadioButton.Location = new System.Drawing.Point(76, 230);
            this.GenderMaleRadioButton.Name = "GenderMaleRadioButton";
            this.GenderMaleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.GenderMaleRadioButton.TabIndex = 14;
            this.GenderMaleRadioButton.TabStop = true;
            this.GenderMaleRadioButton.Text = "Male";
            this.GenderMaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // GenderFemaleRadioButton
            // 
            this.GenderFemaleRadioButton.AutoSize = true;
            this.GenderFemaleRadioButton.Location = new System.Drawing.Point(130, 230);
            this.GenderFemaleRadioButton.Name = "GenderFemaleRadioButton";
            this.GenderFemaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.GenderFemaleRadioButton.TabIndex = 15;
            this.GenderFemaleRadioButton.TabStop = true;
            this.GenderFemaleRadioButton.Text = "Female";
            this.GenderFemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // HabbitsLabel
            // 
            this.HabbitsLabel.AutoSize = true;
            this.HabbitsLabel.Location = new System.Drawing.Point(202, 203);
            this.HabbitsLabel.Name = "HabbitsLabel";
            this.HabbitsLabel.Size = new System.Drawing.Size(43, 13);
            this.HabbitsLabel.TabIndex = 17;
            this.HabbitsLabel.Text = "Habbits";
            // 
            // HabbitsCheckBox
            // 
            this.HabbitsCheckBox.AutoSize = true;
            this.HabbitsCheckBox.Location = new System.Drawing.Point(214, 230);
            this.HabbitsCheckBox.Name = "HabbitsCheckBox";
            this.HabbitsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.HabbitsCheckBox.TabIndex = 19;
            this.HabbitsCheckBox.UseVisualStyleBackColor = true;
            // 
            // NationComboBox
            // 
            this.NationComboBox.FormattingEnabled = true;
            this.NationComboBox.Items.AddRange(new object[] {
            "Ukranian",
            "French",
            "Polish"});
            this.NationComboBox.Location = new System.Drawing.Point(26, 281);
            this.NationComboBox.Name = "NationComboBox";
            this.NationComboBox.Size = new System.Drawing.Size(150, 21);
            this.NationComboBox.TabIndex = 20;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(191, 281);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(105, 20);
            this.CountryTextBox.TabIndex = 21;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(305, 281);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(105, 20);
            this.CityTextBox.TabIndex = 22;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(112, 341);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(105, 20);
            this.StreetTextBox.TabIndex = 23;
            // 
            // HouseTextBox
            // 
            this.HouseTextBox.Location = new System.Drawing.Point(273, 341);
            this.HouseTextBox.Name = "HouseTextBox";
            this.HouseTextBox.Size = new System.Drawing.Size(88, 20);
            this.HouseTextBox.TabIndex = 24;
            // 
            // HouseLabel
            // 
            this.HouseLabel.AutoSize = true;
            this.HouseLabel.Location = new System.Drawing.Point(302, 325);
            this.HouseLabel.Name = "HouseLabel";
            this.HouseLabel.Size = new System.Drawing.Size(38, 13);
            this.HouseLabel.TabIndex = 25;
            this.HouseLabel.Text = "House";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(153, 325);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(35, 13);
            this.StreetLabel.TabIndex = 26;
            this.StreetLabel.Text = "Street";
            // 
            // NationLabel
            // 
            this.NationLabel.AutoSize = true;
            this.NationLabel.Location = new System.Drawing.Point(91, 265);
            this.NationLabel.Name = "NationLabel";
            this.NationLabel.Size = new System.Drawing.Size(38, 13);
            this.NationLabel.TabIndex = 27;
            this.NationLabel.Text = "Nation";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(230, 265);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(43, 13);
            this.CountryLabel.TabIndex = 28;
            this.CountryLabel.Text = "Country";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(338, 265);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 29;
            this.CityLabel.Text = "City";
            // 
            // PreviewButton
            // 
            this.PreviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviewButton.Location = new System.Drawing.Point(26, 400);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(122, 38);
            this.PreviewButton.TabIndex = 30;
            this.PreviewButton.Text = "Preview";
            this.PreviewButton.UseVisualStyleBackColor = true;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMenuButton.Location = new System.Drawing.Point(177, 400);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(144, 38);
            this.BackToMenuButton.TabIndex = 31;
            this.BackToMenuButton.Text = "Back to menu";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(341, 400);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(117, 38);
            this.SaveButton.TabIndex = 32;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PersonRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.PreviewButton);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.NationLabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.HouseLabel);
            this.Controls.Add(this.HouseTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.NationComboBox);
            this.Controls.Add(this.HabbitsCheckBox);
            this.Controls.Add(GenderLabel);
            this.Controls.Add(this.HabbitsLabel);
            this.Controls.Add(this.GenderFemaleRadioButton);
            this.Controls.Add(this.GenderMaleRadioButton);
            this.Controls.Add(this.WeightLabel2);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.AgeComboBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.SurnameLable);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "PersonRegistration";
            this.Text = "Person Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label SurnameLable;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox AgeComboBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel2;
        private System.Windows.Forms.RadioButton GenderMaleRadioButton;
        private System.Windows.Forms.RadioButton GenderFemaleRadioButton;
        private System.Windows.Forms.Label HabbitsLabel;
        private System.Windows.Forms.CheckBox HabbitsCheckBox;
        private System.Windows.Forms.ComboBox NationComboBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox HouseTextBox;
        private System.Windows.Forms.Label HouseLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label NationLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Button PreviewButton;
        private System.Windows.Forms.Button BackToMenuButton;
        private System.Windows.Forms.Button SaveButton;
    }
}

