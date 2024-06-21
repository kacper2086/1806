namespace gui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerwisForm));
            label7 = new Label();
            wydaj = new Button();
            label3 = new Label();
            users1 = new ComboBox();
            parts1 = new ComboBox();
            hour = new TextBox();
            label2 = new Label();
            label5 = new Label();
            btnRefresh = new Button();
            label8 = new Label();
            label9 = new Label();
            btnBackToLogin = new Button();
            endserv = new Button();
            deny = new Button();
            label4 = new Label();
            editserv = new Button();
            label1 = new Label();
            ser = new ComboBox();
            eve = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(599, 167);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 22;
            label7.Text = "Część";
            // 
            // wydaj
            // 
            wydaj.BackColor = Color.Transparent;
            wydaj.BackgroundImage = (Image)resources.GetObject("wydaj.BackgroundImage");
            wydaj.FlatAppearance.BorderSize = 0;
            wydaj.FlatStyle = FlatStyle.Flat;
            wydaj.Location = new Point(765, 346);
            wydaj.MaximumSize = new Size(223, 31);
            wydaj.MinimumSize = new Size(223, 31);
            wydaj.Name = "wydaj";
            wydaj.Size = new Size(223, 31);
            wydaj.TabIndex = 20;
            wydaj.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(697, 108);
            label3.Name = "label3";
            label3.Size = new Size(368, 30);
            label3.TabIndex = 19;
            label3.Text = "Przydziel część oraz okreś ilość godzin";
            // 
            // users1
            // 
            users1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            users1.FormattingEnabled = true;
            users1.Location = new Point(779, 217);
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
            parts1.Location = new Point(708, 160);
            parts1.MaximumSize = new Size(340, 0);
            parts1.MinimumSize = new Size(340, 0);
            parts1.Name = "parts1";
            parts1.Size = new Size(340, 33);
            parts1.TabIndex = 17;
            // 
            // hour
            // 
            hour.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            hour.Location = new Point(779, 282);
            hour.Name = "hour";
            hour.Size = new Size(180, 33);
            hour.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(587, 305);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 35;
            label2.Text = "Godzina robocza = 120zł";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(561, 285);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 36;
            label5.Text = "Ilość godzin roboczych";
            label5.Click += label5_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.None;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(49, 492);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(117, 34);
            btnRefresh.TabIndex = 38;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label8.Location = new Point(392, 25);
            label8.Name = "label8";
            label8.Size = new Size(253, 45);
            label8.TabIndex = 39;
            label8.Text = "Panel serwisanta";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label9.Location = new Point(25, 167);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 49;
            label9.Text = "Zlecenie";
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.Transparent;
            btnBackToLogin.BackgroundImage = (Image)resources.GetObject("btnBackToLogin.BackgroundImage");
            btnBackToLogin.FlatAppearance.BorderSize = 0;
            btnBackToLogin.FlatStyle = FlatStyle.Flat;
            btnBackToLogin.Location = new Point(953, 492);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(112, 31);
            btnBackToLogin.TabIndex = 48;
            btnBackToLogin.UseVisualStyleBackColor = false;
            // 
            // endserv
            // 
            endserv.BackColor = Color.Transparent;
            endserv.BackgroundImage = (Image)resources.GetObject("endserv.BackgroundImage");
            endserv.FlatAppearance.BorderSize = 0;
            endserv.FlatStyle = FlatStyle.Flat;
            endserv.Location = new Point(185, 346);
            endserv.MaximumSize = new Size(213, 31);
            endserv.MinimumSize = new Size(213, 31);
            endserv.Name = "endserv";
            endserv.Size = new Size(213, 31);
            endserv.TabIndex = 47;
            endserv.UseVisualStyleBackColor = false;
            // 
            // deny
            // 
            deny.BackColor = Color.Transparent;
            deny.BackgroundImage = (Image)resources.GetObject("deny.BackgroundImage");
            deny.FlatAppearance.BorderSize = 0;
            deny.FlatStyle = FlatStyle.Flat;
            deny.Location = new Point(313, 289);
            deny.MaximumSize = new Size(149, 31);
            deny.MinimumSize = new Size(149, 31);
            deny.Name = "deny";
            deny.Size = new Size(149, 31);
            deny.TabIndex = 46;
            deny.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(241, 108);
            label4.Name = "label4";
            label4.Size = new Size(166, 30);
            label4.TabIndex = 45;
            label4.Text = "Przyjmij zlecenie";
            // 
            // editserv
            // 
            editserv.BackColor = Color.Transparent;
            editserv.BackgroundImage = (Image)resources.GetObject("editserv.BackgroundImage");
            editserv.FlatAppearance.BorderSize = 0;
            editserv.FlatStyle = FlatStyle.Flat;
            editserv.Location = new Point(92, 289);
            editserv.MaximumSize = new Size(183, 31);
            editserv.MinimumSize = new Size(183, 31);
            editserv.Name = "editserv";
            editserv.Size = new Size(183, 31);
            editserv.TabIndex = 44;
            editserv.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(146, 219);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 43;
            label1.Text = "Serwisant";
            // 
            // ser
            // 
            ser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ser.FormattingEnabled = true;
            ser.Location = new Point(241, 219);
            ser.Name = "ser";
            ser.Size = new Size(121, 33);
            ser.TabIndex = 42;
            // 
            // eve
            // 
            eve.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            eve.FormattingEnabled = true;
            eve.Location = new Point(107, 160);
            eve.MaximumSize = new Size(400, 0);
            eve.MinimumSize = new Size(400, 0);
            eve.Name = "eve";
            eve.Size = new Size(400, 33);
            eve.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(604, 224);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 21;
            label6.Text = "Zlecenie";
            // 
            // SerwisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1102, 559);
            Controls.Add(label9);
            Controls.Add(btnBackToLogin);
            Controls.Add(endserv);
            Controls.Add(deny);
            Controls.Add(label4);
            Controls.Add(editserv);
            Controls.Add(label1);
            Controls.Add(ser);
            Controls.Add(eve);
            Controls.Add(label8);
            Controls.Add(btnRefresh);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(hour);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(wydaj);
            Controls.Add(label3);
            Controls.Add(users1);
            Controls.Add(parts1);
            Name = "SerwisForm";
            Text = "Warsztat samochodowy - Panel serwisanta";
            Load += SerwisForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button wydaj;
        private Label label3;
        private ComboBox users1;
        private ComboBox parts1;
        private ComboBox st;
        private Label label2;
        private TextBox hour;
        private Label label5;
        private Button btnRefresh;
        private Label label8;
        private Label label9;
        private Button btnBackToLogin;
        private Button endserv;
        private Button deny;
        private Label label4;
        private Button editserv;
        private Label label1;
        private ComboBox ser;
        private ComboBox eve;
        private Label label6;
    }
}