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
    public partial class FormCoachProfile : Form
    {


        string command;						//С какой целью открывается форма
        public FormCoachProfile(string command)
        {
            InitializeComponent();
            this.command = command;
        }
        FfootballTournamentsDataSet.InstructorsDataTable dataInstructors;
        FfootballTournamentsDataSet.InstructorsRow rowInstructors;
        FfootballTournamentsDataSet.UsersDataTable dataUsers;		//все данные
        FfootballTournamentsDataSet.UsersRow rowUser;			//Отдельная строка таблицы
        private void FormCoachProfile_Load(object sender, EventArgs e)
        {
            dataUsers = this.usersTableAdapter1.GetData();
            rowUser = dataUsers.FindByIDUser(ClassTotal.idUser);
            switch (command)	//С какой целью будет открываться форма
            {
                case "Addition":	//Цель - добавление
                    //buttonAdditionProfile.Visible = true;
                    //buttonGoRunner.Enabled = false;
                    //textBoxWallet.Text = "0,00";
                    break;
                case "ViewEdit":
                    dataInstructors = instructorsTableAdapter1.GetData(); 	//Все данные из таблице Runners
                    //Поиск среди них запись с нужным ID
                    rowInstructors = dataInstructors.FindByIDInstructos(ClassTotal.idUser);
                    //Перенос данных из записи в элементы интерфейса
                    textBoxName.Text = rowInstructors.FIOInstructor.ToString();
                    //textBoxName.Text = rowRunner.NameRunner;
                    //textBoxCount.Text = Convert.ToString(rowFootballers.CountGoals);
                    //comboBoxTeam.SelectedValue = rowFootballers.IDTeam;
                    //comboBoxGenders.SelectedValue = rowRunner.IDGender;
                    //dateTimePickerBirthday.Value = rowRunner.Birthday;
                    //comboBoxCountries.SelectedValue = rowRunner.IDCountry;
                    //maskedTextBoxPhone.Text = rowRunner.Phone;
                    //Получить фото из БД и отобразить его в компоненте
                    if (rowInstructors.IsPhotoInstructorNull())		//проверка пустого значения в поле фото
                    {
                        ////pictureBoxPhoto.Image = Properties.Resources.NotPicture;
                    }
                    else
                    {
                        byte[] photo = rowInstructors.PhotoInstructor;
                        MemoryStream stream = new MemoryStream(photo);
                        Image bit = Image.FromStream(stream);
                        pictureBox1.Image = bit;
                    }
                    break;

            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            byte[] photo = null;
            string NameCoach = textBoxName.Text;
            if (NameCoach == "")
            {
                MessageBox.Show("Не заполнили имя");
                return;
            }
            //string  = textBox1.Text;
            //int Count = Convert.ToInt32(textBoxCount.Text);
            //int idTeam = (int)comboBoxTeam.SelectedValue;
            if (pictureBox1.Image != null)
            {
                //photo = File.ReadAllBytes(openFileDialog1.FileName);	//в массив
            }
            try
            {
                this.instructorsTableAdapter1.Insert(ClassTotal.idUser, NameCoach,  photo);
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
