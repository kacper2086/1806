namespace gui
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
            date = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnRefresh = new Button();
            usluga = new TextBox();
            btnAddEvent = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // date
            // 
            date.Location = new Point(30, 67);
            date.Name = "date";
            date.Size = new Size(200, 23);
            date.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(397, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(391, 244);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(397, 399);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "button1";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // usluga
            // 
            usluga.Location = new Point(30, 117);
            usluga.Name = "usluga";
            usluga.Size = new Size(100, 23);
            usluga.TabIndex = 4;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(30, 160);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(75, 23);
            btnAddEvent.TabIndex = 5;
            btnAddEvent.Text = "button1";
            btnAddEvent.UseVisualStyleBackColor = true;
            // 
            // KlientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}