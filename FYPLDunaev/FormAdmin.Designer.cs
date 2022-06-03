
namespace FYPLDunaev
{
    partial class FormAdmin
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
            this.buttonAddAccount = new System.Windows.Forms.Button();
            this.buttonAddClubs = new System.Windows.Forms.Button();
            this.buttonAddMath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.Location = new System.Drawing.Point(70, 202);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Size = new System.Drawing.Size(129, 23);
            this.buttonAddAccount.TabIndex = 0;
            this.buttonAddAccount.Text = "Добавить аккаунт";
            this.buttonAddAccount.UseVisualStyleBackColor = true;
            this.buttonAddAccount.Click += new System.EventHandler(this.buttonAddAccount_Click);
            // 
            // buttonAddClubs
            // 
            this.buttonAddClubs.Location = new System.Drawing.Point(70, 231);
            this.buttonAddClubs.Name = "buttonAddClubs";
            this.buttonAddClubs.Size = new System.Drawing.Size(129, 23);
            this.buttonAddClubs.TabIndex = 1;
            this.buttonAddClubs.Text = "Добавить клуб";
            this.buttonAddClubs.UseVisualStyleBackColor = true;
            this.buttonAddClubs.Click += new System.EventHandler(this.buttonAddClubs_Click);
            // 
            // buttonAddMath
            // 
            this.buttonAddMath.Location = new System.Drawing.Point(70, 261);
            this.buttonAddMath.Name = "buttonAddMath";
            this.buttonAddMath.Size = new System.Drawing.Size(129, 23);
            this.buttonAddMath.TabIndex = 2;
            this.buttonAddMath.Text = "Добавить матч";
            this.buttonAddMath.UseVisualStyleBackColor = true;
            this.buttonAddMath.Click += new System.EventHandler(this.buttonAddMath_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddMath);
            this.Controls.Add(this.buttonAddClubs);
            this.Controls.Add(this.buttonAddAccount);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddAccount;
        private System.Windows.Forms.Button buttonAddClubs;
        private System.Windows.Forms.Button buttonAddMath;
    }
}