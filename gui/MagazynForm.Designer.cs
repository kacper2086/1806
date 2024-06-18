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
            SuspendLayout();
            // 
            // parts1
            // 
            parts1.FormattingEnabled = true;
            parts1.Location = new Point(331, 219);
            parts1.Name = "parts1";
            parts1.Size = new Size(121, 23);
            parts1.TabIndex = 0;
            // 
            // MagazynForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(parts1);
            Name = "MagazynForm";
            Text = "MagazynForm";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox parts1;
    }
}