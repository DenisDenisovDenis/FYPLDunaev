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
    public partial class FormAddClub : Form
    {
        FfootballTournamentsDataSet.TeamsDataTable dataTeams;
        public FormAddClub()
        {
            InitializeComponent();
        }

        private void buttonAddCl_Click(object sender, EventArgs e)
        {
            string NM = textBoxNameTeam.Text;
            int idTeam = (int)comboBoxCoach.SelectedValue;
            decimal wallet = Convert.ToDecimal(textBoxWallet.Text);
            int score = Convert.ToInt32(textBoxScore.Text);
            int victory = Convert.ToInt32(textBoxCountVictory.Text);
            int defeat = Convert.ToInt32(textBoxCountDefeat.Text);
            int equality = Convert.ToInt32(textBoxCountEquality.Text);
            int points = Convert.ToInt32(textBoxPoints.Text);

            //Поиск совпадений по данным
            //var filter = dataTeams.Where(rec => rec.NameTeam == NM && rec.NameTeam == NM);
            //if (filter.Count() == 0)    //Нет записей – совпадение 
            var filter = 0;
            if (filter == 0)	//Нет записей – совпадение 
            {
                try
                {
                    teamsTableAdapter1.Insert(NM,idTeam,wallet,score,victory,defeat,equality,points);
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

        private void FormAddClub_Load(object sender, EventArgs e)
        {
            comboBoxCoach.DataSource = instructorsTableAdapter1.GetData();
            comboBoxCoach.DisplayMember = "FIOInstructor";
            comboBoxCoach.ValueMember = "IDInstructos";
        }
    }
}
