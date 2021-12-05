using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFirstHomework
{
    public partial class FormMain : Form
    {
        private PhoneNumbersManager phoneNumbersManager;

        private void UpdatedataGridViewPhoneNumbers(List<PhoneNumber> phoneNumbers)
        {
            dataGridViewPhoneNumbers.Rows.Clear();

            for (int i = 0; i < phoneNumbers.Count; i++)
            {
                dataGridViewPhoneNumbers.Rows.Add(
                    i + 1,
                    phoneNumbers[i].Number,
                    phoneNumbers[i].Name,
                    phoneNumbers[i].Info,
                    phoneNumbers[i].Grade
                    );
            }
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            phoneNumbersManager = new PhoneNumbersManager();

            comboBoxGrade.SelectedIndex = 0;
        }

        private void buttonPhoneNumbersFromTxtFile_Click(object sender, EventArgs e)
        {
            phoneNumbersManager.LoadPhoneNumbersFromTxtFile();
            UpdatedataGridViewPhoneNumbers(phoneNumbersManager.GetAllPhoneNumbers());
        }

        private void buttonAddPhoneNumber_Click(object sender, EventArgs e)
        {
            string number = textBoxNumber.Text;

            string name = textBoxName.Text;

            string info = textBoxInfo.Text;

            PhoneNumber.GradeList grade = (PhoneNumber.GradeList)comboBoxGrade.SelectedIndex;

            PhoneNumber pnum = new PhoneNumber(number, name, info, grade);

            phoneNumbersManager.AddPhoneNumber(pnum);
            UpdatedataGridViewPhoneNumbers(phoneNumbersManager.GetAllPhoneNumbers());

            textBoxNumber.Clear();
            textBoxName.Clear();
            textBoxInfo.Clear();
            comboBoxGrade.SelectedIndex = 0;
        }

        private void buttonLoadPhoneNumbersFromBinFile_Click(object sender, EventArgs e)
        {
            phoneNumbersManager.LoadPhoneNumbersFromBinFile();
            UpdatedataGridViewPhoneNumbers(phoneNumbersManager.GetAllPhoneNumbers());
        }

        private void buttonSavePhoneNumbersBinToFile_Click(object sender, EventArgs e)
        {
            phoneNumbersManager.SavePhoneNumbersBinToFile();
        }

        private void buttonSavePhoneNumbersTxtToFile_Click(object sender, EventArgs e)
        {
            phoneNumbersManager.SavePhoneNumbersTxtToFile();
        }
        private void buttonDeletePhoneNumber_Click(object sender, EventArgs e)
        {
            int index = int.Parse(textBoxIndexForDelete.Text);
            phoneNumbersManager.DeletePhoneNumber(index - 1);
            UpdatedataGridViewPhoneNumbers(phoneNumbersManager.GetAllPhoneNumbers());
            textBoxIndexForDelete.Clear();
        }

        private void butbuttonReplacePhoneNumber_Click(object sender, EventArgs e)
        {
            int index = int.Parse(textBoxReplaceIndex.Text);

            string number = textBoxReplaceNumber.Text;

            string name = textBoxReplaceName.Text;

            string info = textBoxReplaceInfo.Text;

            PhoneNumber.GradeList grade = (PhoneNumber.GradeList)comboBoxReplaceGrade.SelectedIndex;

            PhoneNumber pnum = new PhoneNumber(number, name, info, grade);

            phoneNumbersManager.ReplacePhoneNumber(index - 1, pnum);
            UpdatedataGridViewPhoneNumbers(phoneNumbersManager.GetAllPhoneNumbers());

            textBoxReplaceIndex.Clear();
            textBoxReplaceNumber.Clear();
            textBoxReplaceName.Clear();
            textBoxReplaceInfo.Clear();
            comboBoxReplaceGrade.SelectedIndex = 0;
        }

        private void buttonPrintByGrade_Click(object sender, EventArgs e)
        {
            PhoneNumber.GradeList grade = (PhoneNumber.GradeList)comboBoxByGrade.SelectedIndex;

            List<PhoneNumber> temp = phoneNumbersManager.GetPhoneNumbersByGrade(grade);

            if (temp.Count == 0)
            {
                MessageBox.Show("Элементы не найдены");
            }
            else
            {
                UpdatedataGridViewPhoneNumbers(temp);
            }

        }

        private void buttonResetRetrive_Click(object sender, EventArgs e)
        {
            UpdatedataGridViewPhoneNumbers(phoneNumbersManager.GetAllPhoneNumbers());
        }

        private void dataGridViewPhoneNumbers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPhoneNumbers.SelectedRows.Count == 0)
            {
                return;
            }

            int index = int.Parse(dataGridViewPhoneNumbers.SelectedRows[0].Cells[0].Value.ToString());

            PhoneNumber findedPhoneNuber = phoneNumbersManager.GetPhoneNumberByIndex(index - 1);

            textBoxReplaceIndex.Text = index.ToString();
            textBoxReplaceNumber.Text = findedPhoneNuber.Number.ToString();
            textBoxReplaceName.Text = findedPhoneNuber.Name;
            textBoxReplaceInfo.Text = findedPhoneNuber.Info;
            comboBoxReplaceGrade.SelectedIndex = (int)findedPhoneNuber.Grade;
        }

        private void buttonOpenNewForm_Click(object sender, EventArgs e)
        {
            new FormReplacePhoneNumber().ShowDialog();

            if (Global.IsChanged == true)
            {
                int index = Global.Index;

                string number = Global.PhoneNumber.Number;

                string name = Global.PhoneNumber.Name;

                string info = Global.PhoneNumber.Info;

                PhoneNumber.GradeList grade = Global.PhoneNumber.Grade;

                PhoneNumber pnum = new PhoneNumber(number, name, info, grade);

                phoneNumbersManager.ReplacePhoneNumber(index - 1, pnum);
                UpdatedataGridViewPhoneNumbers(phoneNumbersManager.GetAllPhoneNumbers());
            }
        }
    }
}
