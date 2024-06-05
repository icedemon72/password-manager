namespace PasswordManager
{
    partial class Main
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button7 = new Button();
            button6 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            tabPage3 = new TabPage();
            button5 = new Button();
            button4 = new Button();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            PasswordLabel = new Label();
            PasswordSizeLabel = new Label();
            trackBar1 = new TrackBar();
            button1 = new Button();
            button3 = new Button();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Right;
            tabControl1.Location = new Point(72, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1026, 602);
            tabControl1.TabIndex = 2;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button7);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1018, 574);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lozinke";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(935, 447);
            button7.Name = "button7";
            button7.Size = new Size(75, 56);
            button7.TabIndex = 7;
            button7.Text = "Kopiraj izabranu";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.RosyBrown;
            button6.ForeColor = Color.DarkRed;
            button6.Location = new Point(935, 509);
            button6.Name = "button6";
            button6.Size = new Size(75, 56);
            button6.TabIndex = 6;
            button6.Text = "Obriši izabranu";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(847, 61);
            button2.Name = "button2";
            button2.Size = new Size(70, 24);
            button2.TabIndex = 5;
            button2.Text = "Pretraži";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(620, 63);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Pretraži lozinke";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(879, 474);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(344, 15);
            label1.Name = "label1";
            label1.Size = new Size(277, 45);
            label1.TabIndex = 2;
            label1.Text = "Menadžer lozinki";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(PasswordLabel);
            tabPage3.Controls.Add(PasswordSizeLabel);
            tabPage3.Controls.Add(trackBar1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1018, 574);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Dodaj lozinku";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(42, 494);
            button5.Name = "button5";
            button5.Size = new Size(188, 39);
            button5.TabIndex = 8;
            button5.Text = "Kopiraj lozinku";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(791, 494);
            button4.Name = "button4";
            button4.Size = new Size(188, 39);
            button4.TabIndex = 7;
            button4.Text = "Sačuvaj";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 174);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 6;
            label5.Text = "Web-stranica";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 96);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 5;
            label4.Text = "Korisničko ime/e-adresa";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(42, 114);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Unesite e-adresu ili korisničko ime";
            textBox3.Size = new Size(627, 29);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.AutoCompleteSource = AutoCompleteSource.AllUrl;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(42, 192);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Unesite naziv/link web-stranice";
            textBox2.Size = new Size(627, 29);
            textBox2.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PasswordLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(42, 267);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(937, 32);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Lozinka";
            PasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordSizeLabel
            // 
            PasswordSizeLabel.AutoSize = true;
            PasswordSizeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordSizeLabel.Location = new Point(785, 343);
            PasswordSizeLabel.Name = "PasswordSizeLabel";
            PasswordSizeLabel.Size = new Size(194, 30);
            PasswordSizeLabel.TabIndex = 1;
            PasswordSizeLabel.Text = "Dužina lozinke: 10";
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 10;
            trackBar1.Location = new Point(42, 387);
            trackBar1.Maximum = 64;
            trackBar1.Minimum = 10;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(937, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 10;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(54, 45);
            button1.TabIndex = 3;
            button1.Text = "Odjava";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGreen;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(12, 539);
            button3.Name = "button3";
            button3.Size = new Size(54, 45);
            button3.TabIndex = 4;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(344, 27);
            label2.Name = "label2";
            label2.Size = new Size(304, 45);
            label2.TabIndex = 9;
            label2.Text = "Unesi novu lozinku";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 602);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            Text = "Menadžer lozinki";
            Load += Main_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private TabPage tabPage3;
        private Label label3;
        private Label PasswordSizeLabel;
        private TrackBar trackBar1;
        private Button button5;
        private Button button4;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label PasswordLabel;
        private Button button6;
        private Button button7;
        private Label label2;
    }
}