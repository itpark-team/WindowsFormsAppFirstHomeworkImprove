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
    public partial class FormReplacePhoneNumber : Form
    {
        public FormReplacePhoneNumber()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Global.Index = int.Parse(textBoxIndex.Text);

            string number = textBoxNumber.Text;

            string name = textBoxName.Text;

            string info = textBoxInfo.Text;

            PhoneNumber.GradeList grade = (PhoneNumber.GradeList)int.Parse(textBoxGrade.Text);

            Global.PhoneNumber = new PhoneNumber(number, name, info, grade);

            Global.IsChanged = true;

            MessageBox.Show("успешно сохранено");

            this.Close();
        }

        private void FormReplacePhoneNumber_Load(object sender, EventArgs e)
        {
            Global.IsChanged = false;
        }
    }
}
