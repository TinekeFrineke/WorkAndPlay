namespace Work_And_Play
{
    partial class WorkAndPlay
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
            this.Work = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.textHours = new System.Windows.Forms.TextBox();
            this.textMinutes = new System.Windows.Forms.TextBox();
            this.Colon = new System.Windows.Forms.Label();
            this.textSumToday = new System.Windows.Forms.TextBox();
            this.textSumThisWeek = new System.Windows.Forms.TextBox();
            this.Today = new System.Windows.Forms.Label();
            this.ThisWeek = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMainPage = new System.Windows.Forms.TabPage();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabMainPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Work
            // 
            this.Work.BackColor = System.Drawing.Color.RoyalBlue;
            this.Work.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Work.Location = new System.Drawing.Point(71, 162);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(297, 279);
            this.Work.TabIndex = 0;
            this.Work.Text = "Work";
            this.Work.UseVisualStyleBackColor = false;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Play.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(400, 162);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(297, 279);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            // 
            // textHours
            // 
            this.textHours.BackColor = System.Drawing.SystemColors.Control;
            this.textHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textHours.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHours.Location = new System.Drawing.Point(187, 82);
            this.textHours.Name = "textHours";
            this.textHours.Size = new System.Drawing.Size(48, 25);
            this.textHours.TabIndex = 2;
            // 
            // textMinutes
            // 
            this.textMinutes.BackColor = System.Drawing.SystemColors.Control;
            this.textMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMinutes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMinutes.Location = new System.Drawing.Point(255, 82);
            this.textMinutes.Name = "textMinutes";
            this.textMinutes.Size = new System.Drawing.Size(48, 25);
            this.textMinutes.TabIndex = 3;
            // 
            // Colon
            // 
            this.Colon.AutoSize = true;
            this.Colon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colon.Location = new System.Drawing.Point(238, 79);
            this.Colon.Name = "Colon";
            this.Colon.Size = new System.Drawing.Size(15, 24);
            this.Colon.TabIndex = 4;
            this.Colon.Text = ":";
            // 
            // textSumToday
            // 
            this.textSumToday.BackColor = System.Drawing.SystemColors.Control;
            this.textSumToday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSumToday.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSumToday.Location = new System.Drawing.Point(400, 461);
            this.textSumToday.Name = "textSumToday";
            this.textSumToday.Size = new System.Drawing.Size(297, 25);
            this.textSumToday.TabIndex = 5;
            // 
            // textSumThisWeek
            // 
            this.textSumThisWeek.BackColor = System.Drawing.SystemColors.Control;
            this.textSumThisWeek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSumThisWeek.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSumThisWeek.Location = new System.Drawing.Point(400, 525);
            this.textSumThisWeek.Name = "textSumThisWeek";
            this.textSumThisWeek.Size = new System.Drawing.Size(297, 25);
            this.textSumThisWeek.TabIndex = 6;
            // 
            // Today
            // 
            this.Today.AutoSize = true;
            this.Today.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Today.Location = new System.Drawing.Point(76, 461);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(92, 25);
            this.Today.TabIndex = 7;
            this.Today.Text = "Vandaag";
            // 
            // ThisWeek
            // 
            this.ThisWeek.AutoSize = true;
            this.ThisWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThisWeek.Location = new System.Drawing.Point(76, 524);
            this.ThisWeek.Name = "ThisWeek";
            this.ThisWeek.Size = new System.Drawing.Size(109, 25);
            this.ThisWeek.TabIndex = 8;
            this.ThisWeek.Text = "Deze week";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMainPage);
            this.tabControl.Controls.Add(this.tabAdvanced);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1113, 771);
            this.tabControl.TabIndex = 9;
            // 
            // tabMainPage
            // 
            this.tabMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabMainPage.Controls.Add(this.Work);
            this.tabMainPage.Controls.Add(this.ThisWeek);
            this.tabMainPage.Controls.Add(this.Colon);
            this.tabMainPage.Controls.Add(this.Today);
            this.tabMainPage.Controls.Add(this.Play);
            this.tabMainPage.Controls.Add(this.textSumThisWeek);
            this.tabMainPage.Controls.Add(this.textHours);
            this.tabMainPage.Controls.Add(this.textSumToday);
            this.tabMainPage.Controls.Add(this.textMinutes);
            this.tabMainPage.Location = new System.Drawing.Point(4, 32);
            this.tabMainPage.Name = "tabMainPage";
            this.tabMainPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainPage.Size = new System.Drawing.Size(1105, 735);
            this.tabMainPage.TabIndex = 0;
            this.tabMainPage.Text = "Main";
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabAdvanced.Location = new System.Drawing.Point(4, 32);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvanced.Size = new System.Drawing.Size(1105, 735);
            this.tabAdvanced.TabIndex = 1;
            this.tabAdvanced.Text = "Advanced";
            // 
            // WorkAndPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1113, 771);
            this.Controls.Add(this.tabControl);
            this.Name = "WorkAndPlay";
            this.Text = "Work and Play";
            this.tabControl.ResumeLayout(false);
            this.tabMainPage.ResumeLayout(false);
            this.tabMainPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Work;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.TextBox textHours;
        private System.Windows.Forms.TextBox textMinutes;
        private System.Windows.Forms.Label Colon;
        private System.Windows.Forms.TextBox textSumToday;
        private System.Windows.Forms.TextBox textSumThisWeek;
        private System.Windows.Forms.Label Today;
        private System.Windows.Forms.Label ThisWeek;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMainPage;
        private System.Windows.Forms.TabPage tabAdvanced;
    }
}

