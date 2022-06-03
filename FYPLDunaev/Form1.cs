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
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }
        FfootballTournamentsDataSet.UsersDataTable dataUsers;
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string log, pas;
            pas = this.textBoxPassword.Text;
            log = this.textBoxLogin.Text;			//Исходные данные
            dataUsers = this.usersTableAdapter1.GetData();
            //Наложить на все записи фильтр на совпадение по логину и паролю
            var filter = dataUsers.Where(rec => rec.Login == log && rec.Password == pas);
            if (filter.Count() == 0)    //Нет записей – совпадение логина+пароля не найдено
            {
                MessageBox.Show("Таких данных нет.");
            }
            else				//Данные в БД есть
            {
                //Получение данных об этом пользователе и запись их в общий класс
                //Первая и единственная запись с 0 индексом
                ClassTotal.idUser = filter.ElementAt(0).IDUser;
                ClassTotal.idRole = filter.ElementAt(0).IDRole;
                ClassTotal.login = filter.ElementAt(0).Login;
                //Переход к формам в зависимости от роли
                switch (ClassTotal.idRole)
                {
                    case 2:
                        MessageBox.Show("Вы успешно авторизовались как футболист.");
                        FormFootballist ff = new FormFootballist();
                        this.Hide();
                        ff.ShowDialog();
                        this.Show();
                        break;
                    case 3:
                        MessageBox.Show("Вы успешно авторизовались как спонсор.");
                        FormSponsor fs = new FormSponsor();
                        this.Hide();
                        fs.ShowDialog();
                        this.Show();
                        break;
                    case 1:
                        MessageBox.Show("Вы успешно авторизовались как администратор.");
                        FormAdmin fa = new FormAdmin();
                        this.Hide();
                        fa.ShowDialog();
                        this.Show();
                        break;
                    case 4:
                        MessageBox.Show("Вы успешно авторизовались как трейнер.");
                        FormCoach fc = new FormCoach();
                        this.Hide();
                        fc.ShowDialog();
                        this.Show();
                        break;
                }
            }
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            //Получение всех записей из таблицы Users
            dataUsers = this.usersTableAdapter1.GetData();
            //Количество записей
            int totalCount = dataUsers.Count;
            //Отобразить полученные записи в компоненте
            this.dataGridViewUsers.DataSource = dataUsers;
            //Настроить компонент по ширине
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Разрешить добавлять новые строки
            dataGridViewUsers.AllowUserToAddRows = false;
            //Настроить видимость нужных столбцов
            this.dataGridViewUsers.Columns["IDUser"].Visible = false;
            //Изменить заголовки столбцов таблицы
            this.dataGridViewUsers.Columns["IDRole"].HeaderText = "Роль";
            this.dataGridViewUsers.Columns["Login"].HeaderText = "Логин";
            this.dataGridViewUsers.Columns["Password"].HeaderText = "Пароль";
            //this.checkBoxShow.Checked = true;
            //this.textBoxPassword.PasswordChar = '*';		//Пароль не видим
        }
    }
}
