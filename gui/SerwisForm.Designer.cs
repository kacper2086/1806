﻿namespace gui
{
    partial class SerwisForm
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
            label7 = new Label();
            label6 = new Label();
            wydaj = new Button();
            label3 = new Label();
            users1 = new ComboBox();
            parts1 = new ComboBox();
            eve = new ComboBox();
            ser = new ComboBox();
            label1 = new Label();
            editserv = new Button();
            refreshButton = new Button();
            label4 = new Label();
            deny = new Button();
            endserv = new Button();
            hour = new TextBox();
            label2 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(164, 190);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 22;
            label7.Text = "Część";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(145, 132);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 21;
            label6.Text = "Zlecenie";
            // 
            // wydaj
            // 
            wydaj.Location = new Point(235, 304);
            wydaj.MaximumSize = new Size(180, 33);
            wydaj.MinimumSize = new Size(180, 33);
            wydaj.Name = "wydaj";
            wydaj.Size = new Size(180, 33);
            wydaj.TabIndex = 20;
            wydaj.Text = "Wydaj";
            wydaj.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(254, 67);
            label3.Name = "label3";
            label3.Size = new Size(132, 30);
            label3.TabIndex = 19;
            label3.Text = "Wydaj czesci";
            // 
            // users1
            // 
            users1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            users1.FormattingEnabled = true;
            users1.Location = new Point(235, 183);
            users1.MaximumSize = new Size(180, 0);
            users1.MinimumSize = new Size(180, 0);
            users1.Name = "users1";
            users1.Size = new Size(180, 33);
            users1.TabIndex = 18;
            // 
            // parts1
            // 
            parts1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            parts1.FormattingEnabled = true;
            parts1.Location = new Point(235, 125);
            parts1.MaximumSize = new Size(180, 0);
            parts1.MinimumSize = new Size(180, 0);
            parts1.Name = "parts1";
            parts1.Size = new Size(180, 33);
            parts1.TabIndex = 17;
            // 
            // eve
            // 
            eve.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            eve.FormattingEnabled = true;
            eve.Location = new Point(599, 124);
            eve.MaximumSize = new Size(400, 0);
            eve.MinimumSize = new Size(400, 0);
            eve.Name = "eve";
            eve.Size = new Size(400, 33);
            eve.TabIndex = 23;
            // 
            // ser
            // 
            ser.FormattingEnabled = true;
            ser.Location = new Point(670, 182);
            ser.Name = "ser";
            ser.Size = new Size(121, 23);
            ser.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(578, 181);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 28;
            label1.Text = "Serwisant";
            // 
            // editserv
            // 
            editserv.Location = new Point(599, 228);
            editserv.MaximumSize = new Size(180, 33);
            editserv.MinimumSize = new Size(180, 33);
            editserv.Name = "editserv";
            editserv.Size = new Size(180, 33);
            editserv.TabIndex = 29;
            editserv.Text = "Wyslij edycje zlecenia";
            editserv.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(740, 467);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
            refreshButton.TabIndex = 30;
            refreshButton.Text = "Odśwież dane";
            refreshButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(710, 66);
            label4.Name = "label4";
            label4.Size = new Size(166, 30);
            label4.TabIndex = 31;
            label4.Text = "Przyjmij zlecenie";
            // 
            // deny
            // 
            deny.Location = new Point(805, 228);
            deny.MaximumSize = new Size(180, 33);
            deny.MinimumSize = new Size(180, 33);
            deny.Name = "deny";
            deny.Size = new Size(180, 33);
            deny.TabIndex = 32;
            deny.Text = "Odrzuć usługe";
            deny.UseVisualStyleBackColor = true;
            // 
            // endserv
            // 
            endserv.Location = new Point(710, 281);
            endserv.MaximumSize = new Size(180, 33);
            endserv.MinimumSize = new Size(180, 33);
            endserv.Name = "endserv";
            endserv.Size = new Size(180, 33);
            endserv.TabIndex = 33;
            endserv.Text = "Oznacz wykonanie usługi";
            endserv.UseVisualStyleBackColor = true;
            // 
            // hour
            // 
            hour.Location = new Point(235, 241);
            hour.Name = "hour";
            hour.Size = new Size(180, 23);
            hour.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 264);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 35;
            label2.Text = "Godzina robocza = 120zł";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(49, 244);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 36;
            label5.Text = "Ilość godzin roboczych";
            label5.Click += label5_Click;
            // 
            // SerwisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 559);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(hour);
            Controls.Add(endserv);
            Controls.Add(deny);
            Controls.Add(label4);
            Controls.Add(refreshButton);
            Controls.Add(editserv);
            Controls.Add(label1);
            Controls.Add(ser);
            Controls.Add(eve);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(wydaj);
            Controls.Add(label3);
            Controls.Add(users1);
            Controls.Add(parts1);
            Name = "SerwisForm";
            Text = "SerwisForm";
            Load += SerwisForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Button wydaj;
        private Label label3;
        private ComboBox users1;
        private ComboBox parts1;
        private ComboBox eve;
        private ComboBox st;
        private ComboBox ser;
        private Label label2;
        private Label label1;
        private Button editserv;
        private Button refreshButton;
        private Label label4;
        private Button deny;
        private Button endserv;
        private TextBox hour;
        private Label label5;
    }
}