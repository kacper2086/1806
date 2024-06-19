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
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(11, 218);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 22;
            label7.Text = "Część";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(11, 160);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 21;
            label6.Text = "Zlecenie";
            // 
            // wydaj
            // 
            wydaj.Location = new Point(82, 268);
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
            label3.Location = new Point(101, 95);
            label3.Name = "label3";
            label3.Size = new Size(132, 30);
            label3.TabIndex = 19;
            label3.Text = "Wydaj czesci";
            // 
            // users1
            // 
            users1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            users1.FormattingEnabled = true;
            users1.Location = new Point(82, 211);
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
            parts1.Location = new Point(82, 153);
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
            eve.Location = new Point(286, 153);
            eve.MaximumSize = new Size(400, 0);
            eve.MinimumSize = new Size(400, 0);
            eve.Name = "eve";
            eve.Size = new Size(400, 33);
            eve.TabIndex = 23;
            // 
            // ser
            // 
            ser.FormattingEnabled = true;
            ser.Location = new Point(394, 211);
            ser.Name = "ser";
            ser.Size = new Size(121, 23);
            ser.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(316, 210);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 28;
            label1.Text = "Serwisant";
            // 
            // editserv
            // 
            editserv.Location = new Point(316, 268);
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
            refreshButton.Location = new Point(462, 489);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
            refreshButton.TabIndex = 30;
            refreshButton.Text = "Odśwież dane";
            refreshButton.UseVisualStyleBackColor = true;
            // 
            // SerwisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 559);
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
    }
}