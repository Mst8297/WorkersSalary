namespace WorkerSalary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_add = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_addWorkers = new System.Windows.Forms.Button();
            this.bt_sort = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_fName = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_add
            // 
            this.b_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_add.Location = new System.Drawing.Point(755, 403);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(125, 40);
            this.b_add.TabIndex = 0;
            this.b_add.Text = "הוסף עובד";
            this.b_add.UseVisualStyleBackColor = false;
            this.b_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(960, 96);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(31, 20);
            this.ID.TabIndex = 1;
            this.ID.Text = ":ת.ז";
            this.ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(957, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = ":שם";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(902, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = ":שם משפחה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(936, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = ":אימייל";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(933, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = ":כתובת";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(936, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = ":טלפון";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(918, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = ":משכורת";
            // 
            // bt_addWorkers
            // 
            this.bt_addWorkers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_addWorkers.Location = new System.Drawing.Point(634, 89);
            this.bt_addWorkers.Name = "bt_addWorkers";
            this.bt_addWorkers.Size = new System.Drawing.Size(82, 75);
            this.bt_addWorkers.TabIndex = 8;
            this.bt_addWorkers.Text = "הוספת 10,000 עובדים";
            this.bt_addWorkers.UseVisualStyleBackColor = false;
            this.bt_addWorkers.Click += new System.EventHandler(this.bt_addWorkers_Click);
            // 
            // bt_sort
            // 
            this.bt_sort.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_sort.Location = new System.Drawing.Point(634, 170);
            this.bt_sort.Name = "bt_sort";
            this.bt_sort.Size = new System.Drawing.Size(82, 70);
            this.bt_sort.TabIndex = 9;
            this.bt_sort.Text = "מיון לפי משכורת";
            this.bt_sort.UseVisualStyleBackColor = false;
            this.bt_sort.Click += new System.EventHandler(this.bt_sort_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(842, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = ":הכנס את פרטי העובד";
            // 
            // tb_fName
            // 
            this.tb_fName.Location = new System.Drawing.Point(755, 181);
            this.tb_fName.Name = "tb_fName";
            this.tb_fName.Size = new System.Drawing.Size(125, 27);
            this.tb_fName.TabIndex = 12;
            this.tb_fName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(755, 137);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(125, 27);
            this.tb_name.TabIndex = 13;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(755, 96);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(125, 27);
            this.tb_id.TabIndex = 14;
            this.tb_id.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.tb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_id_KeyPress);
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(755, 226);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(125, 27);
            this.tb_Email.TabIndex = 15;
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(755, 361);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(125, 27);
            this.tb_salary.TabIndex = 16;
            this.tb_salary.TextChanged += new System.EventHandler(this.tb_salary_TextChanged);
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(755, 313);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(125, 27);
            this.tb_phone.TabIndex = 17;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(755, 268);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(125, 27);
            this.tb_address.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.ID_C,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(153, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(425, 470);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "משכורת";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // ID_C
            // 
            this.ID_C.HeaderText = "ת.ז";
            this.ID_C.MinimumWidth = 6;
            this.ID_C.Name = "ID_C";
            this.ID_C.ReadOnly = true;
            this.ID_C.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "שם";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(468, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = ":רשימת העובדים";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(12, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 63);
            this.button5.TabIndex = 21;
            this.button5.Text = ":חישוב מס";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = ":מס הכנסה חודשי";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "XXXX";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(75, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = ":זמן ריצה";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 25;
            // 
            // bt_exit
            // 
            this.bt_exit.AutoEllipsis = true;
            this.bt_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_exit.Location = new System.Drawing.Point(918, 481);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(94, 29);
            this.bt_exit.TabIndex = 26;
            this.bt_exit.Text = "יציאה";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 550);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_fName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_sort);
            this.Controls.Add(this.bt_addWorkers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.b_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button b_add;
        private Label ID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button bt_addWorkers;
        private Button bt_sort;
        private Label label7;
        private TextBox tb_fName;
        private TextBox tb_name;
        private TextBox tb_id;
        private TextBox tb_Email;
        private TextBox tb_salary;
        private TextBox tb_phone;
        private TextBox tb_address;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn ID_C;
        private DataGridViewTextBoxColumn Column2;
        private Label label8;
        private Button button5;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button bt_exit;
    }
}