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
    public partial class FormFootballist : Form
    {
        FfootballTournamentsDataSet.FootballersDataTable dataFootballers;
        FfootballTournamentsDataSet.FootballersRow rowFootballers;
        public FormFootballist()
        {
            InitializeComponent();
        }

        private void FormFootballist_Load(object sender, EventArgs e)
        {
            //Получили все данные
            dataFootballers = this.footballersTableAdapter1.GetData();
            //Ищем профиль того аккаунта, который вошел в систему
            rowFootballers = dataFootballers.FindByIDFootballer(ClassTotal.idUser);
            if (rowFootballers == null)
            {
                MessageBox.Show("У Вас не заполнен профиль."
                    + Environment.NewLine + "Надо его заполнить для дальнейшей работы");
                //Конструктору передается команда о добавлении
                FormFootballistProfile ffp = new FormFootballistProfile("Addition");
                this.Hide();
                ffp.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("У Вас заполнен профиль."
                                    + Environment.NewLine + "Можете работат в системе");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Конструктору передается команда для просмотра или редактирования формы
            FormFootballistProfile ffp = new FormFootballistProfile("ViewEdit");
            this.Hide();
            ffp.ShowDialog();
            this.Show();
        }
    }
}
