using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FYPLDunaev
{
    public partial class FormSponsorProfile : Form
    { 
        string command;						//С какой целью открывается форма
        ////По таблице Users
        //FfootballTournamentsDataSet.UsersDataTable dataUsers;		//все данные
        //FfootballTournamentsDataSet.UsersRow rowUser;			//Отдельная строка таблицы
        //Данные по таблице Spоnsors для редактирования
        FfootballTournamentsDataSet.SponsorsDataTable dataSponsors; //все данные
        FfootballTournamentsDataSet.SponsorsRow rowSpons;		//Отдельная строка таблицы
        public FormSponsorProfile(string command)
        {
            InitializeComponent();
            this.command = command;
        }
      
        private void buttonAdditionProfile_Click(object sender, EventArgs e)
        {
            byte[] photo = null;
            string NameSponsor = textBoxName.Text;
            if (NameSponsor == "")
            {
                MessageBox.Show("Не заполнили имя");
                return;
            }
            //string  = textBox1.Text;
            decimal SumTot = decimal.Parse(textBox1.Text);
            if (pictureBoxPhoto.Image != null)
            {
                photo = File.ReadAllBytes(openFileDialog1.FileName);	//в массив
            }
            try
            {
                this.sponsorsTableAdapter1.Insert(ClassTotal.idUser, NameSponsor, photo, SumTot);
                MessageBox.Show("Ваш профиль добавлен в систему");
                buttonAdditionProfile.Visible = false;
                buttonPhoto.Enabled = false;
                buttonGoSponsor.Enabled = true;		//доступ к функционалу спонсора
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении профиля");
            }
        }

        private void FormSponsorProfile_Load(object sender, EventArgs e)
        {
            //Начальные настройки интерфейса
            //buttonAdditionProfile.Visible = false;
            //buttonEditProfile.Visible = false;
            buttonGoSponsor.Enabled = true;
            //textBox1.Enabled = false;
            //textBoxPathPhoto.Enabled = false;
            openFileDialog1.Filter = "jpeg|*.jpeg|jpg|*.jpg|png|*.png";
            openFileDialog1.InitialDirectory = Application.StartupPath + @"\PhotoSponsors";
            openFileDialog1.Title = "Выбрать фото для спонсора";
            //Данные из таблицы Users, которые нельзя менять
            //dataUsers = this.usersTableAdapter1.GetData();
            //rowUser = dataUsers.FindByIDSponsor(ClassTotal.idUser);
            //labelID.Text = "Ваш номер: " + rowUser.ID.ToString();
            //labelLogin.Text = "Ваш логин: " + rowUser.Email;
            //labelPassword.Text = "Ваш пароль: " + rowUser.Password;
            //Настройка списков
            //comboBoxMonth.Items.Clear();
            //for (int i = 1; i <= 12; i++)
            //{
            //    comboBoxMonth.Items.Add(i.ToString());
            //}
            //comboBoxMonth.Text = comboBoxMonth.Items[0].ToString();
            //comboBoxYear.Items.Clear();
            //for (int i = DateTime.Now.Year - 5; i <= DateTime.Now.Year + 5; i++)
            //{
            //    comboBoxYear.Items.Add(i.ToString());
            //}
            //comboBoxYear.Text = comboBoxYear.Items[0].ToString();
            //switch (command)
            //{
            //    case "Addition":
            //        buttonAdditionProfile.Visible = true;
            //        buttonGoSponsor.Enabled = false;
            //        //textBoxSumma.Text = "0,00";
            //        break;
            //    case "ViewEdit":
            //        buttonEditProfile.Visible = true;
            //        dataSponsors = this.sponsorsTableAdapter1.GetData();	//Все данные из Sponsors
            //        //Поиск среди них запись с нужным ID
            //        rowSponsor = dataSponsors.FindByIDSponsor(ClassTotal.idUser);
            //        //Перенос данных из записи в элементы интерфейса
            //        textBox1.Text = rowSponsor.TotalSum.ToString();
            //        textBoxName.Text = rowSponsor.NameSponsor;
                    //maskedTextBoxCard.Text = rowSponsor.NumberCard;
                    //comboBoxMonth.Text = rowSponsor.MonthCard.ToString();
                    //comboBoxYear.Text = rowSponsor.YearCard.ToString();
                    ////Обработка фото
                    //if (rowSponsor.IsLogoNull())
                    //{
                    //    ////////////////////////////////pictureBoxPhoto.Image = Properties.Resources.NotPicture;
                    //}
                    //else
                    //{
                    //    byte[] photo = rowSponsor.Logo;
                    //    MemoryStream stream = new MemoryStream(photo);
                    //    Image bit = Image.FromStream(stream);
                    //    pictureBoxPhoto.Image = bit;
                    //}
                    //break;
            //}
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            //Заполнить строку-шаблон данными из элементов формы
            string sponsorName = textBoxName.Text;
            string sponsorSum = textBox1.Text;
            if (sponsorName == "")
            {
                MessageBox.Show("Не заполнили имя или фамилию");
                return;
            }
            rowSpons.FIOSponsor = sponsorName;
            rowSpons.TotalSumm = Convert.ToDecimal(sponsorSum);
            //rowSponsor.MonthCard = int.Parse(comboBoxMonth.Text);
            //rowSponsor.YearCard = int.Parse(comboBoxYear.Text);
            //rowSponsor.TotalSum = decimal.Parse(textBoxSumma.Text);
            //if (pictureBoxPhoto.Image != null)
            //{
            //    MemoryStream stream = new System.IO.MemoryStream();	//Промежуточный поток 
            //    pictureBoxPhoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            //    rowSponsor.PhotoSponsor = stream.ToArray();
            //}
            //else
            //{
            //    rowSponsor.PhotoSponsor = null;
            //}
            try
            {
                this.sponsorsTableAdapter1.Update(rowSpons);
                MessageBox.Show("Ваш профиль обновлен в системе");
                buttonPhoto.Enabled = false;
                buttonGoSponsor.Enabled = true;		//доступ к функционалу спонсора
            }
            catch
            {
                MessageBox.Show("Ошибка при обновлении профиля");
            }
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            if (buttonPhoto.Text == "Выбрать фото")
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBoxPathPhoto.Text = openFileDialog1.FileName;
                    pictureBoxPhoto.Load(openFileDialog1.FileName);
                    buttonPhoto.Text = "Удалить фото";
                }
            }
            else
            {
                textBoxPathPhoto.Text = "";
                pictureBoxPhoto.Image = null;
                buttonPhoto.Text = "Выбрать фото";
            }
        }

        private void buttonGoSponsor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
