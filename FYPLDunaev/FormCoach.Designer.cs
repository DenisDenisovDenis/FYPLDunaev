
namespace FYPLDunaev
{
    partial class FormCoach
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
            this.buttonProfile = new System.Windows.Forms.Button();
            this.usersTableAdapter1 = new FYPLDunaev.FfootballTournamentsDataSetTableAdapters.UsersTableAdapter();
            this.instructorsTableAdapter1 = new FYPLDunaev.FfootballTournamentsDataSetTableAdapters.InstructorsTableAdapter();
            this.SuspendLayout();
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(178, 247);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(75, 23);
            this.buttonProfile.TabIndex = 0;
            this.buttonProfile.Text = "Профиль";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // instructorsTableAdapter1
            // 
            this.instructorsTableAdapter1.ClearBeforeFill = true;
            // 
            // FormCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonProfile);
            this.Name = "FormCoach";
            this.Text = "FormCoach";
            this.Load += new System.EventHandler(this.FormCoach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProfile;
        private FfootballTournamentsDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private FfootballTournamentsDataSetTableAdapters.InstructorsTableAdapter instructorsTableAdapter1;
    }
}