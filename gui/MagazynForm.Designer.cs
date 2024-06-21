namespace gui
{
    partial class MagazynForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazynForm));
            parts1 = new ComboBox();
            users1 = new ComboBox();
            shopname = new ComboBox();
            ilosczam = new TextBox();
            zamow = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            wydaj = new Button();
            przyjmpart = new ComboBox();
            label4 = new Label();
            przyjmij = new Button();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnRefresh = new Button();
            btnBackToLogin = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // parts1
            // 
            parts1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            parts1.FormattingEnabled = true;
            parts1.Location = new Point(72, 150);
            parts1.MaximumSize = new Size(320, 0);
            parts1.MinimumSize = new Size(320, 0);
            parts1.Name = "parts1";
            parts1.Size = new Size(320, 33);
            parts1.TabIndex = 0;
            parts1.SelectedIndexChanged += parts1_SelectedIndexChanged;
            // 
            // users1
            // 
            users1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            users1.FormattingEnabled = true;
            users1.Location = new Point(72, 208);
            users1.MaximumSize = new Size(320, 0);
            users1.MinimumSize = new Size(320, 0);
            users1.Name = "users1";
            users1.Size = new Size(320, 33);
            users1.TabIndex = 1;
            // 
            // shopname
            // 
            shopname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            shopname.FormattingEnabled = true;
            shopname.Location = new Point(812, 150);
            shopname.Name = "shopname";
            shopname.Size = new Size(283, 33);
            shopname.TabIndex = 3;
            // 
            // ilosczam
            // 
            ilosczam.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ilosczam.Location = new Point(812, 208);
            ilosczam.MaximumSize = new Size(283, 33);
            ilosczam.MinimumSize = new Size(283, 33);
            ilosczam.Name = "ilosczam";
            ilosczam.Size = new Size(283, 33);
            ilosczam.TabIndex = 4;
            // 
            // zamow
            // 
            zamow.BackColor = Color.Transparent;
            zamow.BackgroundImage = (Image)resources.GetObject("zamow.BackgroundImage");
            zamow.FlatAppearance.BorderSize = 0;
            zamow.FlatStyle = FlatStyle.Flat;
            zamow.Location = new Point(882, 265);
            zamow.MaximumSize = new Size(108, 31);
            zamow.MinimumSize = new Size(108, 31);
            zamow.Name = "zamow";
            zamow.Size = new Size(108, 31);
            zamow.TabIndex = 5;
            zamow.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(408, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 45);
            label1.TabIndex = 6;
            label1.Text = "Panel magazyniera";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(865, 92);
            label2.Name = "label2";
            label2.Size = new Size(142, 30);
            label2.TabIndex = 7;
            label2.Text = "Zamów czesci";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(124, 92);
            label3.Name = "label3";
            label3.Size = new Size(132, 30);
            label3.TabIndex = 8;
            label3.Text = "Wydaj czesci";
            // 
            // wydaj
            // 
            wydaj.BackColor = Color.Transparent;
            wydaj.BackgroundImage = (Image)resources.GetObject("wydaj.BackgroundImage");
            wydaj.FlatAppearance.BorderSize = 0;
            wydaj.FlatStyle = FlatStyle.Flat;
            wydaj.ForeColor = SystemColors.ControlText;
            wydaj.Location = new Point(124, 266);
            wydaj.MaximumSize = new Size(101, 31);
            wydaj.MinimumSize = new Size(101, 31);
            wydaj.Name = "wydaj";
            wydaj.Size = new Size(101, 31);
            wydaj.TabIndex = 9;
            wydaj.UseVisualStyleBackColor = false;
            wydaj.Click += wydaj_Click_1;
            // 
            // przyjmpart
            // 
            przyjmpart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            przyjmpart.FormattingEnabled = true;
            przyjmpart.Location = new Point(479, 150);
            przyjmpart.MaximumSize = new Size(190, 0);
            przyjmpart.MinimumSize = new Size(240, 0);
            przyjmpart.Name = "przyjmpart";
            przyjmpart.Size = new Size(240, 33);
            przyjmpart.TabIndex = 10;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 13;
            // 
            // przyjmij
            // 
            przyjmij.BackColor = Color.Transparent;
            przyjmij.BackgroundImage = (Image)resources.GetObject("przyjmij.BackgroundImage");
            przyjmij.FlatAppearance.BorderSize = 0;
            przyjmij.FlatStyle = FlatStyle.Flat;
            przyjmij.Location = new Point(479, 266);
            przyjmij.MaximumSize = new Size(234, 31);
            przyjmij.MinimumSize = new Size(234, 31);
            przyjmij.Name = "przyjmij";
            przyjmij.Size = new Size(234, 31);
            przyjmij.TabIndex = 12;
            przyjmij.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(502, 92);
            label5.Name = "label5";
            label5.Size = new Size(146, 30);
            label5.TabIndex = 14;
            label5.Text = "Przyjmij czesci";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(12, 157);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 16;
            label7.Text = "Część";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label8.Location = new Point(408, 157);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 17;
            label8.Text = "Zlecenie";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label9.Location = new Point(760, 157);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 18;
            label9.Text = "Część";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label10.Location = new Point(767, 215);
            label10.Name = "label10";
            label10.Size = new Size(39, 20);
            label10.TabIndex = 19;
            label10.Text = "Ilość";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.None;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(32, 436);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(117, 34);
            btnRefresh.TabIndex = 40;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.Transparent;
            btnBackToLogin.BackgroundImage = (Image)resources.GetObject("btnBackToLogin.BackgroundImage");
            btnBackToLogin.FlatAppearance.BorderSize = 0;
            btnBackToLogin.FlatStyle = FlatStyle.Flat;
            btnBackToLogin.Location = new Point(972, 439);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(112, 31);
            btnBackToLogin.TabIndex = 39;
            btnBackToLogin.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(0, 215);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 15;
            label6.Text = "Zlecenie";
            // 
            // MagazynForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1112, 482);
            Controls.Add(btnRefresh);
            Controls.Add(btnBackToLogin);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(przyjmij);
            Controls.Add(label4);
            Controls.Add(przyjmpart);
            Controls.Add(wydaj);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(zamow);
            Controls.Add(ilosczam);
            Controls.Add(shopname);
            Controls.Add(users1);
            Controls.Add(parts1);
            Name = "MagazynForm";
            Text = "Warsztat samochodowy - Panel magazyniera";
            Load += MagazynForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox parts1;
        private ComboBox users1;
        private ComboBox shopname;
        private TextBox ilosczam;
        private Button zamow;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button wydaj;
        private ComboBox przyjmpart;
        private Label label4;
        private Button przyjmij;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnRefresh;
        private Button btnBackToLogin;
        private Label label6;
    }
}