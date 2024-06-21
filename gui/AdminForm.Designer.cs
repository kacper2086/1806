namespace gui
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            btnAddUser = new Button();
            dataGridViewUsers = new DataGridView();
            label1 = new Label();
            btnRefresh = new Button();
            btnBackToLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(132, 185);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(185, 23);
            txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(132, 246);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(185, 23);
            txtPassword.TabIndex = 1;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "admin", "serwis", "magazyn", "klient" });
            cmbRole.Location = new Point(132, 314);
            cmbRole.MaximumSize = new Size(185, 0);
            cmbRole.MinimumSize = new Size(185, 0);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(185, 23);
            cmbRole.TabIndex = 2;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Transparent;
            btnAddUser.BackgroundImage = (Image)resources.GetObject("btnAddUser.BackgroundImage");
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Location = new Point(132, 387);
            btnAddUser.MaximumSize = new Size(185, 31);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(185, 31);
            btnAddUser.TabIndex = 3;
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(433, 143);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(500, 300);
            dataGridViewUsers.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(270, 11);
            label1.Name = "label1";
            label1.Size = new Size(298, 45);
            label1.TabIndex = 7;
            label1.Text = "Panel Adimistratora";
            label1.Click += label1_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.None;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(13, 474);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(117, 34);
            btnRefresh.TabIndex = 42;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.Transparent;
            btnBackToLogin.BackgroundImage = (Image)resources.GetObject("btnBackToLogin.BackgroundImage");
            btnBackToLogin.FlatAppearance.BorderSize = 0;
            btnBackToLogin.FlatStyle = FlatStyle.Flat;
            btnBackToLogin.Location = new Point(845, 477);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(112, 31);
            btnBackToLogin.TabIndex = 41;
            btnBackToLogin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(83, 98);
            label2.Name = "label2";
            label2.Size = new Size(268, 30);
            label2.TabIndex = 43;
            label2.Text = "Dodaj nowego użytkownika";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(589, 98);
            label3.Name = "label3";
            label3.Size = new Size(191, 30);
            label3.TabIndex = 44;
            label3.Text = "Lista użytkowników";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 188);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 45;
            label4.Text = "Login";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 249);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 46;
            label5.Text = "Hasło";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 317);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 47;
            label6.Text = "Rola";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(969, 517);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRefresh);
            Controls.Add(btnBackToLogin);
            Controls.Add(label1);
            Controls.Add(dataGridViewUsers);
            Controls.Add(btnAddUser);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Name = "AdminForm";
            Text = "Warsztat samochodowy - Panel administratora";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private Label label1;
        private Button btnRefresh;
        private Button btnBackToLogin;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
