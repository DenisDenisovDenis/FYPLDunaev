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
    public partial class FormSponsor : Form
    {
        FfootballTournamentsDataSet.SponsorsDataTable dataSponsors;
        FfootballTournamentsDataSet.SponsorsRow rowSponsor;
        public FormSponsor()
        {
            InitializeComponent();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            //Конструктору передается команда для просмотра или редактирования формы
            FormSponsorProfile fsp = new FormSponsorProfile("ViewEdit");
            this.Hide();
            fsp.ShowDialog();
            this.Show();
        }

        private void FormSponsor_Load(object sender, EventArgs e)
        {
            //Получили все данные
            dataSponsors = this.sponsorsTableAdapter1.GetData();
            //Ищем профиль того аккаунта, который вошел в систему
            rowSponsor = dataSponsors.FindByIDSponsor(ClassTotal.idUser);
            if (rowSponsor == null)
            {
                MessageBox.Show("У Вас не заполнен профиль."
                    + Environment.NewLine + "Надо его заполнить для дальнейшей работы");
                //Конструктору передается команда о добавлении
                FormSponsorProfile ffp = new FormSponsorProfile("Addition");
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
