﻿namespace gui
{
    partial class KlientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KlientForm));
            date = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnRefresh = new Button();
            usluga = new TextBox();
            btnAddEvent = new Button();
            btnBackToLogin = new Button();
            btnPobierzFakture = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // date
            // 
            date.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            date.Location = new Point(12, 112);
            date.Name = "date";
            date.Size = new Size(361, 35);
            date.TabIndex = 0;
            date.ValueChanged += date_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(397, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(519, 244);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.None;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(22, 404);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(117, 34);
            btnRefresh.TabIndex = 3;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // usluga
            // 
            usluga.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            usluga.Location = new Point(12, 165);
            usluga.MaximumSize = new Size(361, 35);
            usluga.MinimumSize = new Size(361, 35);
            usluga.Name = "usluga";
            usluga.Size = new Size(361, 35);
            usluga.TabIndex = 4;
            // 
            // btnAddEvent
            // 
            btnAddEvent.BackgroundImage = (Image)resources.GetObject("btnAddEvent.BackgroundImage");
            btnAddEvent.FlatAppearance.BorderSize = 0;
            btnAddEvent.FlatStyle = FlatStyle.Flat;
            btnAddEvent.Location = new Point(119, 219);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(143, 31);
            btnAddEvent.TabIndex = 5;
            btnAddEvent.UseVisualStyleBackColor = true;
            btnAddEvent.Click += btnAddEvent_Click_1;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.Transparent;
            btnBackToLogin.BackgroundImage = (Image)resources.GetObject("btnBackToLogin.BackgroundImage");
            btnBackToLogin.FlatAppearance.BorderSize = 0;
            btnBackToLogin.FlatStyle = FlatStyle.Flat;
            btnBackToLogin.Location = new Point(804, 404);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(112, 31);
            btnBackToLogin.TabIndex = 6;
            btnBackToLogin.UseVisualStyleBackColor = false;
            // 
            // btnPobierzFakture
            // 
            btnPobierzFakture.BackColor = Color.Transparent;
            btnPobierzFakture.BackgroundImage = (Image)resources.GetObject("btnPobierzFakture.BackgroundImage");
            btnPobierzFakture.FlatAppearance.BorderSize = 0;
            btnPobierzFakture.FlatStyle = FlatStyle.Flat;
            btnPobierzFakture.Location = new Point(579, 283);
            btnPobierzFakture.Name = "btnPobierzFakture";
            btnPobierzFakture.Size = new Size(208, 31);
            btnPobierzFakture.TabIndex = 8;
            btnPobierzFakture.UseVisualStyleBackColor = false;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // KlientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 450);
            Controls.Add(btnPobierzFakture);
            Controls.Add(btnBackToLogin);
            Controls.Add(btnAddEvent);
            Controls.Add(usluga);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(date);
            Name = "KlientForm";
            Text = "KlientForm";
            Load += KlientForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker date;
        private DataGridView dataGridView1;
        private Button btnRefresh;
        private TextBox usluga;
        private Button btnAddEvent;
        private Button btnBackToLogin;
        private Button btnPobierzFakture;
        private SaveFileDialog saveFileDialog1;
    }
}