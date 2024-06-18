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
            parts1 = new ComboBox();
            users1 = new ComboBox();
            ilosc1 = new TextBox();
            shopname = new ComboBox();
            ilosczam = new TextBox();
            zamow = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // parts1
            // 
            parts1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            parts1.FormattingEnabled = true;
            parts1.Location = new Point(72, 141);
            parts1.MaximumSize = new Size(180, 0);
            parts1.MinimumSize = new Size(180, 0);
            parts1.Name = "parts1";
            parts1.Size = new Size(180, 33);
            parts1.TabIndex = 0;
            // 
            // users1
            // 
            users1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            users1.FormattingEnabled = true;
            users1.Location = new Point(72, 199);
            users1.MaximumSize = new Size(180, 0);
            users1.MinimumSize = new Size(180, 0);
            users1.Name = "users1";
            users1.Size = new Size(180, 33);
            users1.TabIndex = 1;
            // 
            // ilosc1
            // 
            ilosc1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ilosc1.Location = new Point(72, 256);
            ilosc1.MaximumSize = new Size(180, 33);
            ilosc1.MinimumSize = new Size(180, 33);
            ilosc1.Name = "ilosc1";
            ilosc1.Size = new Size(180, 33);
            ilosc1.TabIndex = 2;
            // 
            // shopname
            // 
            shopname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            shopname.FormattingEnabled = true;
            shopname.Location = new Point(577, 141);
            shopname.Name = "shopname";
            shopname.Size = new Size(180, 33);
            shopname.TabIndex = 3;
            // 
            // ilosczam
            // 
            ilosczam.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ilosczam.Location = new Point(577, 199);
            ilosczam.MaximumSize = new Size(180, 33);
            ilosczam.MinimumSize = new Size(180, 33);
            ilosczam.Name = "ilosczam";
            ilosczam.Size = new Size(180, 33);
            ilosczam.TabIndex = 4;
            // 
            // zamow
            // 
            zamow.Location = new Point(577, 256);
            zamow.MaximumSize = new Size(180, 33);
            zamow.MinimumSize = new Size(180, 33);
            zamow.Name = "zamow";
            zamow.Size = new Size(180, 33);
            zamow.TabIndex = 5;
            zamow.Text = "Zamów";
            zamow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(256, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 45);
            label1.TabIndex = 6;
            label1.Text = "Panel magazyniera";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(593, 83);
            label2.Name = "label2";
            label2.Size = new Size(142, 30);
            label2.TabIndex = 7;
            label2.Text = "Zamów czesci";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(91, 83);
            label3.Name = "label3";
            label3.Size = new Size(132, 30);
            label3.TabIndex = 8;
            label3.Text = "Wydaj czesci";
            // 
            // MagazynForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(zamow);
            Controls.Add(ilosczam);
            Controls.Add(shopname);
            Controls.Add(ilosc1);
            Controls.Add(users1);
            Controls.Add(parts1);
            Name = "MagazynForm";
            Text = "MagazynForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox parts1;
        private ComboBox users1;
        private TextBox ilosc1;
        private ComboBox shopname;
        private TextBox ilosczam;
        private Button zamow;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}