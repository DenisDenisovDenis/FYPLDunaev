using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYPLDunaev
{
    public partial class FormCoach : Form
    {
        public FormCoach()
        {
            InitializeComponent();
        }
        FfootballTournamentsDataSet.InstructorsDataTable dataInstructors;
        FfootballTournamentsDataSet.InstructorsRow rowInstructors;
        private void button1_Click(object sender, EventArgs e)
        {
            //Конструктору передается команда для просмотра или редактирования формы
            FormCoachProfile fcp = new FormCoachProfile("ViewEdit");
            this.Hide();
            fcp.ShowDialog();
            this.Show();
        }

        private void FormCoach_Load(object sender, EventArgs e)
        {
            //Получили все данные
            dataInstructors = this.instructorsTableAdapter1.GetData();
            //Ищем профиль того аккаунта, который вошел в систему
            rowInstructors = dataInstructors.FindByIDInstructos(ClassTotal.idUser);
            if (rowInstructors == null)
            {
                MessageBox.Show("У Вас не заполнен профиль."
                    + Environment.NewLine + "Надо его заполнить для дальнейшей работы");
                //Конструктору передается команда о добавлении
                FormCoachProfile fcp = new FormCoachProfile("Addition");
                this.Hide();
                fcp.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("У Вас заполнен профиль."
                                    + Environment.NewLine + "Можете работат в системе");
            }
        }
    }
}
