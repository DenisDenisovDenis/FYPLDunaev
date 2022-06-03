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
    public partial class FormAccounts : Form
    {
        public FormAccounts()
        {
            InitializeComponent();
        }
        FfootballTournamentsDataSet.UsersDataTable dataUsers;	//
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.groupBoxAccount.Enabled = true;	//Доступно для изменения
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            this.buttonInsert.Enabled = true;		//Разблокировано внесение изменений
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string log = textBoxLogin.Text;
            string pas = textBoxPassword.Text;
            //Контроль корректности заполнения полей
            if (String.IsNullOrEmpty(log) || String.IsNullOrEmpty(pas))
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            int pos = log.IndexOf('@');
            if (pos < 0)
            {
                MessageBox.Show("В логине отсутствуют обязательный символ @");
                return;
            }
            pos = log.IndexOf('.');
            if (pos < 0)
            {
                MessageBox.Show("В логине отсутствуют обязательный символ .");
                return;
            }
            if ((int)comboBoxRole.SelectedValue == 3)
            {
                MessageBox.Show("Нельзя добавлять нового организатора."
                    + Environment.NewLine + "Выберите другою роль");
                return;
            }
            //Поиск совпадений по данным
            var filter = dataUsers.Where(rec => rec.Login == log && rec.Password == pas);
            if (filter.Count() == 0)	//Нет записей – совпадение логина+пароля не найдено
            {
                try
                {
                    usersTableAdapter1.Insert(log, pas, (int)comboBoxRole.SelectedValue);
                    MessageBox.Show("Данные о новом пользователе успешно сохранены в БД");
                    FormAccounts_Load(null, null);		//Обновить данные в таблице
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

        private void FormAccounts_Load(object sender, EventArgs e)
        {
            //Получение всех записей из таблицы Users
            dataUsers = this.usersTableAdapter1.GetData();
            //Отбор только с ролью бегун (1) и спонсор (2)
            var filter = dataUsers.Where(rec => rec.IDRole == 3 || rec.IDRole == 2 || rec.IDRole == 4);
            //Количество записей
            int totalCount = filter.Count();
            //Отобразить полученные записи в компоненте
            this.dataGridViewAccounts.DataSource = filter.CopyToDataTable();
            //Выделять всю строку
            this.dataGridViewAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccounts.Select();		//Выбрать первую строку
            //Настроить список ролей в ComboBox
            this.comboBoxRole.DataSource = this.rolesTableAdapter1.GetData();
            this.comboBoxRole.DisplayMember = "RoleName";	//Видеть
            this.comboBoxRole.ValueMember = "IDRole";		//Получить
            this.groupBoxAccount.Enabled = false;		//Недоступно для изменения
            this.buttonInsert.Enabled = false;			//Заблокировано внесение изменений
        }

        private void dataGridViewAccounts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;				//Получить номер выбранной строки
            //Отобразить в контейнере значения нужных полей
            textBoxLogin.Text = dataGridViewAccounts.Rows[numRow].Cells[1].Value.ToString();
            textBoxPassword.Text = dataGridViewAccounts.Rows[numRow].Cells[2].Value.ToString();
            //Отобразить название роли по ее номеру
            comboBoxRole.SelectedValue = (int)dataGridViewAccounts.Rows[numRow].Cells[3].Value;
        }
    }
}
