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
    public partial class FormAddMatch : Form
    {
        public FormAddMatch()
        {
            InitializeComponent();
        }
        FfootballTournamentsDataSet.TournamentsDataTable dataTournaments;
        private void FormAddMatch_Load(object sender, EventArgs e)
        {
            comboBoxTeam1.DataSource = teamsTableAdapter1.GetData();
            comboBoxTeam1.DisplayMember = "NameTeam";
            comboBoxTeam1.ValueMember = "IDTeam";
            comboBoxTeam2.DataSource = teamsTableAdapter1.GetData();
            comboBoxTeam2.DisplayMember = "NameTeam";
            comboBoxTeam2.ValueMember = "IDTeam";
        }

        private void buttonAddMatch_Click(object sender, EventArgs e)
        {
            int idTeam1 = (int)comboBoxTeam1.SelectedValue;
            int idTeam2 = (int)comboBoxTeam2.SelectedValue;
            DateTime birthday = dateTimePickerBrth.Value;
            decimal wallet = Convert.ToDecimal(textBoxMoney.Text);
            int result1 = Convert.ToInt32(textBoxResult1.Text);
            int result2 = Convert.ToInt32(textBoxResult2.Text);
            var filter = 0;
            if (filter == 0)	//Нет записей – совпадение 
            {
                try
                {
                    tournamentsTableAdapter1.Insert(idTeam1, idTeam2, birthday, wallet, result1, result2);
                    MessageBox.Show("Данные о новом пользователе успешно сохранены в БД");
                    //FormAddClub_Load(null, null);		//Обновить данные в таблице
                }
                catch
                {
                    MessageBox.Show("При добавлении нового пользователя возникли проблемы");
                    return;
                }
            }
            else				//Данные в БД есть
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован в системе." +
                                                    Environment.NewLine + " Введите другие данные");
                return;
            }
        }
    }
}
