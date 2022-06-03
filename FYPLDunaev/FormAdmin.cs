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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            FormAccounts fr = new FormAccounts();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void buttonAddClubs_Click(object sender, EventArgs e)
        {
            FormAddClub fac = new FormAddClub();
            this.Hide();
            fac.ShowDialog();
            this.Show();
        }

        private void buttonAddMath_Click(object sender, EventArgs e)
        {
            FormAddMatch fam = new FormAddMatch();
            this.Hide();
            fam.ShowDialog();
            this.Show();
        }
    }
}
