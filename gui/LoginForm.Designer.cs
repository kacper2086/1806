namespace gui
{
    partial class LoginForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtUsername.Location = new Point(309, 122);
            txtUsername.MaximumSize = new Size(200, 50);
            txtUsername.MinimumSize = new Size(200, 50);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 50);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtPassword.Location = new Point(309, 203);
            txtPassword.MaximumSize = new Size(200, 50);
            txtPassword.MinimumSize = new Size(200, 50);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 50);
            txtPassword.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(309, 298);
            button1.MaximumSize = new Size(200, 50);
            button1.MinimumSize = new Size(200, 50);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 2;
            button1.Text = "Zaloguj";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(215, 9);
            label1.Name = "label1";
            label1.Size = new Size(359, 45);
            label1.TabIndex = 3;
            label1.Text = "Warsztat Samochodowy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(187, 134);
            label2.Name = "label2";
            label2.Size = new Size(73, 32);
            label2.TabIndex = 4;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(187, 203);
            label3.Name = "label3";
            label3.Size = new Size(74, 32);
            label3.TabIndex = 5;
            label3.Text = "Hasło";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            Text = "Panel logowania";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}