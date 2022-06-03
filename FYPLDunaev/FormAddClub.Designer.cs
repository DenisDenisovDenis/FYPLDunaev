
namespace FYPLDunaev
{
    partial class FormAddClub
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
            this.usersTableAdapter1 = new FYPLDunaev.FfootballTournamentsDataSetTableAdapters.UsersTableAdapter();
            this.teamsTableAdapter1 = new FYPLDunaev.FfootballTournamentsDataSetTableAdapters.TeamsTableAdapter();
            this.instructorsTableAdapter1 = new FYPLDunaev.FfootballTournamentsDataSetTableAdapters.InstructorsTableAdapter();
            this.buttonAddCl = new System.Windows.Forms.Button();
            this.textBoxNameTeam = new System.Windows.Forms.TextBox();
            this.comboBoxCoach = new System.Windows.Forms.ComboBox();
            this.textBoxWallet = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.textBoxCountVictory = new System.Windows.Forms.TextBox();
            this.textBoxCountDefeat = new System.Windows.Forms.TextBox();
            this.textBoxCountEquality = new System.Windows.Forms.TextBox();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // teamsTableAdapter1
            // 
            this.teamsTableAdapter1.ClearBeforeFill = true;
            // 
            // instructorsTableAdapter1
            // 
            this.instructorsTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonAddCl
            // 
            this.buttonAddCl.Location = new System.Drawing.Point(411, 154);
            this.buttonAddCl.Name = "buttonAddCl";
            this.buttonAddCl.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCl.TabIndex = 0;
            this.buttonAddCl.Text = "Добавить";
            this.buttonAddCl.UseVisualStyleBackColor = true;
            this.buttonAddCl.Click += new System.EventHandler(this.buttonAddCl_Click);
            // 
            // textBoxNameTeam
            // 
            this.textBoxNameTeam.Location = new System.Drawing.Point(164, 154);
            this.textBoxNameTeam.Name = "textBoxNameTeam";
            this.textBoxNameTeam.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameTeam.TabIndex = 1;
            // 
            // comboBoxCoach
            // 
            this.comboBoxCoach.FormattingEnabled = true;
            this.comboBoxCoach.Location = new System.Drawing.Point(164, 181);
            this.comboBoxCoach.Name = "comboBoxCoach";
            this.comboBoxCoach.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCoach.TabIndex = 2;
            // 
            // textBoxWallet
            // 
            this.textBoxWallet.Location = new System.Drawing.Point(164, 209);
            this.textBoxWallet.Name = "textBoxWallet";
            this.textBoxWallet.Size = new System.Drawing.Size(100, 20);
            this.textBoxWallet.TabIndex = 3;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(164, 235);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(100, 20);
            this.textBoxScore.TabIndex = 4;
            // 
            // textBoxCountVictory
            // 
            this.textBoxCountVictory.Location = new System.Drawing.Point(164, 261);
            this.textBoxCountVictory.Name = "textBoxCountVictory";
            this.textBoxCountVictory.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountVictory.TabIndex = 5;
            // 
            // textBoxCountDefeat
            // 
            this.textBoxCountDefeat.Location = new System.Drawing.Point(164, 288);
            this.textBoxCountDefeat.Name = "textBoxCountDefeat";
            this.textBoxCountDefeat.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountDefeat.TabIndex = 6;
            // 
            // textBoxCountEquality
            // 
            this.textBoxCountEquality.Location = new System.Drawing.Point(164, 314);
            this.textBoxCountEquality.Name = "textBoxCountEquality";
            this.textBoxCountEquality.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountEquality.TabIndex = 7;
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Location = new System.Drawing.Point(164, 340);
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.Size = new System.Drawing.Size(100, 20);
            this.textBoxPoints.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Тренер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Забито мячей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Деньги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Очки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Поражения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ничьи";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Выйгрыши";
            // 
            // FormAddClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPoints);
            this.Controls.Add(this.textBoxCountEquality);
            this.Controls.Add(this.textBoxCountDefeat);
            this.Controls.Add(this.textBoxCountVictory);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxWallet);
            this.Controls.Add(this.comboBoxCoach);
            this.Controls.Add(this.textBoxNameTeam);
            this.Controls.Add(this.buttonAddCl);
            this.Name = "FormAddClub";
            this.Text = "FormAddClub";
            this.Load += new System.EventHandler(this.FormAddClub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FfootballTournamentsDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private FfootballTournamentsDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter1;
        private FfootballTournamentsDataSetTableAdapters.InstructorsTableAdapter instructorsTableAdapter1;
        private System.Windows.Forms.Button buttonAddCl;
        private System.Windows.Forms.TextBox textBoxNameTeam;
        private System.Windows.Forms.ComboBox comboBoxCoach;
        private System.Windows.Forms.TextBox textBoxWallet;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.TextBox textBoxCountVictory;
        private System.Windows.Forms.TextBox textBoxCountDefeat;
        private System.Windows.Forms.TextBox textBoxCountEquality;
        private System.Windows.Forms.TextBox textBoxPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}