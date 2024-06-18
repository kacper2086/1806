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
            SuspendLayout();
            // 
            // parts1
            // 
            parts1.FormattingEnabled = true;
            parts1.Location = new Point(72, 130);
            parts1.Name = "parts1";
            parts1.Size = new Size(121, 23);
            parts1.TabIndex = 0;
            // 
            // users1
            // 
            users1.FormattingEnabled = true;
            users1.Location = new Point(72, 181);
            users1.Name = "users1";
            users1.Size = new Size(121, 23);
            users1.TabIndex = 1;
            // 
            // ilosc1
            // 
            ilosc1.Location = new Point(72, 230);
            ilosc1.Name = "ilosc1";
            ilosc1.Size = new Size(100, 23);
            ilosc1.TabIndex = 2;
            // 
            // shopname
            // 
            shopname.FormattingEnabled = true;
            shopname.Location = new Point(540, 127);
            shopname.Name = "shopname";
            shopname.Size = new Size(121, 23);
            shopname.TabIndex = 3;
            // 
            // MagazynForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}