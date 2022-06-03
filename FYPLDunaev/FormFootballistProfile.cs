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
    public partial class FormFootballistProfile : Form
    {
        string command;						//С какой целью открывается форма
        public FormFootballistProfile(string command)
        {
            InitializeComponent();
            this.command = command;
        }
        FfootballTournamentsDataSet.FootballersDataTable dataFootballers;
        FfootballTournamentsDataSet.FootballersRow rowFootballers;
        FfootballTournamentsDataSet.UsersDataTable dataUsers;		//все данные
        FfootballTournamentsDataSet.UsersRow rowUser;			//Отдельная строка таблицы
        private void FormFootballistProfile_Load(object sender, EventArgs e)
        {
            ////Начальные настройки интерфейса
            //buttonAdditionProfile.Visible = false;
            //buttonGoRunner.Enabled = true;
            //textBoxWallet.Enabled = false;
            //textBoxPathPhoto.Enabled = false;
            //openFileDialog.Filter = "jpg|*.jpg|png|*.png";
            //Данные из таблицы Users, которые нельзя менять
            dataUsers = this.usersTableAdapter1.GetData();
            rowUser = dataUsers.FindByIDUser(ClassTotal.idUser);
            //labelID.Text = "Ваш номер: " + rowUser.ID.ToString();
            //labelLogin.Text = "Ваш логин: " + rowUser.Email;
            //labelPassword.Text = "Ваш пароль: " + rowUser.Password;
            //Настройка списков
            comboBoxTeam.DataSource = teamsTableAdapter1.GetData();
            comboBoxTeam.DisplayMember = "NameTeam";
            comboBoxTeam.ValueMember = "IDTeam";
            //comboBoxGenders.DataSource = teamsTableAdapter1.GetData();
            //comboBoxGenders.DisplayMember = "Title";
            //comboBoxGenders.ValueMember = "ID";
            switch (command)	//С какой целью будет открываться форма
            {
                case "Addition":	//Цель - добавление
                    //buttonAdditionProfile.Visible = true;
                    //buttonGoRunner.Enabled = false;
                    //textBoxWallet.Text = "0,00";
                    break;
                case "ViewEdit":
                    dataFootballers = footballersTableAdapter1.GetData(); 	//Все данные из таблице Runners
                    //Поиск среди них запись с нужным ID
                    rowFootballers = dataFootballers.FindByIDFootballer(ClassTotal.idUser);
                    //Перенос данных из записи в элементы интерфейса
                    textBoxFIO.Text = rowFootballers.FIOFootballer.ToString();
                    //textBoxName.Text = rowRunner.NameRunner;
                    textBoxCount.Text = Convert.ToString(rowFootballers.CountGoals);
                    comboBoxTeam.SelectedValue = rowFootballers.IDTeam;
                    //comboBoxGenders.SelectedValue = rowRunner.IDGender;
                    //dateTimePickerBirthday.Value = rowRunner.Birthday;
                    //comboBoxCountries.SelectedValue = rowRunner.IDCountry;
                    //maskedTextBoxPhone.Text = rowRunner.Phone;
                    //Получить фото из БД и отобразить его в компоненте
                    if (rowFootballers.IsPhotoFootballerNull())		//проверка пустого значения в поле фото
                    {
                        ////pictureBoxPhoto.Image = Properties.Resources.NotPicture;
                    }
                    else
                    {
                        byte[] photo = rowFootballers.PhotoFootballer;
                        MemoryStream stream = new MemoryStream(photo);
                        Image bit = Image.FromStream(stream);
                        pictureBoxPhoto.Image = bit;
                    }
                    break;

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            byte[] photo = null;
            string NameFootballist = textBoxFIO.Text;
            if (NameFootballist == "")
            {
                MessageBox.Show("Не заполнили имя");
                return;
            }
            //string  = textBox1.Text;
            int Count = Convert.ToInt32(textBoxCount.Text);
            int idTeam = (int)comboBoxTeam.SelectedValue;
            if (pictureBoxPhoto.Image != null)
            {
                //photo = File.ReadAllBytes(openFileDialog1.FileName);	//в массив
            }
            try
            {
                this.footballersTableAdapter1.Insert(ClassTotal.idUser, NameFootballist, idTeam ,photo, Count);
                MessageBox.Show("Ваш профиль добавлен в систему");
                //buttonAdditionProfile.Visible = false;
                //buttonPhoto.Enabled = false;
                //buttonGoSponsor.Enabled = true;		//доступ к функционалу спонсора
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении профиля");
            }
        }
    }
}
