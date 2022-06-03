
namespace FYPLDunaev
{
    partial class FormAddMatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxTeam1 = new System.Windows.Forms.ComboBox();
            this.comboBoxTeam2 = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBrth = new System.Windows.Forms.DateTimePicker();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.textBoxResult1 = new System.Windows.Forms.TextBox();
            this.textBoxResult2 = new System.Windows.Forms.TextBox();
            this.buttonAddMatch = new System.Windows.Forms.Button();
            this.teamsTableAdapter1 = new FYPLDunaev.FfootballTournamentsDataSetTableAdapters.TeamsTableAdapter();
            this.tournamentsTableAdapter1 = new FYPLDunaev.FfootballTournamentsDataSetTableAdapters.TournamentsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTeam1
            // 
            this.comboBoxTeam1.FormattingEnabled = true;
            this.comboBoxTeam1.Location = new System.Drawing.Point(186, 161);
            this.comboBoxTeam1.Name = "comboBoxTeam1";
            this.comboBoxTeam1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeam1.TabIndex = 0;
            // 
            // comboBoxTeam2
            // 
            this.comboBoxTeam2.FormattingEnabled = true;
            this.comboBoxTeam2.Location = new System.Drawing.Point(186, 188);
            this.comboBoxTeam2.Name = "comboBoxTeam2";
            this.comboBoxTeam2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeam2.TabIndex = 1;
            // 
            // dateTimePickerBrth
            // 
            this.dateTimePickerBrth.Location = new System.Drawing.Point(186, 216);
            this.dateTimePickerBrth.Name = "dateTimePickerBrth";
            this.dateTimePickerBrth.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerBrth.TabIndex = 2;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(186, 243);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(121, 20);
            this.textBoxMoney.TabIndex = 3;
            // 
            // textBoxResult1
            // 
            this.textBoxResult1.Location = new System.Drawing.Point(186, 269);
            this.textBoxResult1.Name = "textBoxResult1";
            this.textBoxResult1.Size = new System.Drawing.Size(121, 20);
            this.textBoxResult1.TabIndex = 4;
            // 
            // textBoxResult2
            // 
            this.textBoxResult2.Location = new System.Drawing.Point(186, 296);
            this.textBoxResult2.Name = "textBoxResult2";
            this.textBoxResult2.Size = new System.Drawing.Size(121, 20);
            this.textBoxResult2.TabIndex = 5;
            // 
            // buttonAddMatch
            // 
            this.buttonAddMatch.Location = new System.Drawing.Point(371, 185);
            this.buttonAddMatch.Name = "buttonAddMatch";
            this.buttonAddMatch.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMatch.TabIndex = 6;
            this.buttonAddMatch.Text = "Добавить";
            this.buttonAddMatch.UseVisualStyleBackColor = true;
            this.buttonAddMatch.Click += new System.EventHandler(this.buttonAddMatch_Click);
            // 
            // teamsTableAdapter1
            // 
            this.teamsTableAdapter1.ClearBeforeFill = true;
            // 
            // tournamentsTableAdapter1
            // 
            this.tournamentsTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Команда 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Команда 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Деньги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Забито 2 командой";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Забито 1 командой";
            // 
            // FormAddMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddMatch);
            this.Controls.Add(this.textBoxResult2);
            this.Controls.Add(this.textBoxResult1);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.dateTimePickerBrth);
            this.Controls.Add(this.comboBoxTeam2);
            this.Controls.Add(this.comboBoxTeam1);
            this.Name = "FormAddMatch";
            this.Text = "FormAddMatch";
            this.Load += new System.EventHandler(this.FormAddMatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTeam1;
        private System.Windows.Forms.ComboBox comboBoxTeam2;
        private System.Windows.Forms.DateTimePicker dateTimePickerBrth;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.TextBox textBoxResult1;
        private System.Windows.Forms.TextBox textBoxResult2;
        private System.Windows.Forms.Button buttonAddMatch;
        private FfootballTournamentsDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter1;
        private FfootballTournamentsDataSetTableAdapters.TournamentsTableAdapter tournamentsTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}