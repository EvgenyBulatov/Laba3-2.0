
namespace Laba3_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChooseFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ChooseType = new System.Windows.Forms.ComboBox();
            this.ShowObj = new System.Windows.Forms.Button();
            this.SortBy = new System.Windows.Forms.Button();
            this.FilterBy = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ShowSorted = new System.Windows.Forms.Button();
            this.SortSalary = new System.Windows.Forms.RadioButton();
            this.SortAmntPpl = new System.Windows.Forms.RadioButton();
            this.SortProjName = new System.Windows.Forms.RadioButton();
            this.SortExp = new System.Windows.Forms.RadioButton();
            this.SortAge = new System.Windows.Forms.RadioButton();
            this.SortName = new System.Windows.Forms.RadioButton();
            this.Older20 = new System.Windows.Forms.RadioButton();
            this.ExpOver4 = new System.Windows.Forms.RadioButton();
            this.PplOver10 = new System.Windows.Forms.RadioButton();
            this.FilterShow = new System.Windows.Forms.Button();
            this.AddObj = new System.Windows.Forms.Button();
            this.PplAmntTB = new System.Windows.Forms.TextBox();
            this.ProjNameTB = new System.Windows.Forms.TextBox();
            this.WorkExpTB = new System.Windows.Forms.TextBox();
            this.StatusTB = new System.Windows.Forms.TextBox();
            this.SalaryTB = new System.Windows.Forms.TextBox();
            this.GenderTB = new System.Windows.Forms.TextBox();
            this.AgeTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.DeleteGroup = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DeleteGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1266, 606);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1293, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1293, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(660, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите тип объектов для работы с ним";
            // 
            // ChooseFile
            // 
            this.ChooseFile.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseFile.Location = new System.Drawing.Point(1917, 120);
            this.ChooseFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(231, 47);
            this.ChooseFile.TabIndex = 3;
            this.ChooseFile.Text = "Выбрать файл ...";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1299, 120);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(607, 45);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // ChooseType
            // 
            this.ChooseType.FormattingEnabled = true;
            this.ChooseType.Location = new System.Drawing.Point(1299, 253);
            this.ChooseType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChooseType.Name = "ChooseType";
            this.ChooseType.Size = new System.Drawing.Size(607, 33);
            this.ChooseType.TabIndex = 5;
            // 
            // ShowObj
            // 
            this.ShowObj.Location = new System.Drawing.Point(1917, 233);
            this.ShowObj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowObj.Name = "ShowObj";
            this.ShowObj.Size = new System.Drawing.Size(230, 75);
            this.ShowObj.TabIndex = 6;
            this.ShowObj.Text = "Отобразить из файла";
            this.ShowObj.UseVisualStyleBackColor = true;
            this.ShowObj.Click += new System.EventHandler(this.ShowObj_Click);
            // 
            // SortBy
            // 
            this.SortBy.Location = new System.Drawing.Point(1299, 319);
            this.SortBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortBy.Name = "SortBy";
            this.SortBy.Size = new System.Drawing.Size(166, 72);
            this.SortBy.TabIndex = 7;
            this.SortBy.Text = "Сортировка";
            this.SortBy.UseVisualStyleBackColor = true;
            this.SortBy.Click += new System.EventHandler(this.SortBy_Click);
            // 
            // FilterBy
            // 
            this.FilterBy.Location = new System.Drawing.Point(1299, 414);
            this.FilterBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilterBy.Name = "FilterBy";
            this.FilterBy.Size = new System.Drawing.Size(166, 72);
            this.FilterBy.TabIndex = 8;
            this.FilterBy.Text = "Фильтрация";
            this.FilterBy.UseVisualStyleBackColor = true;
            this.FilterBy.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1299, 514);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 72);
            this.button3.TabIndex = 9;
            this.button3.Text = "Добавить элемент";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1299, 612);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 72);
            this.button4.TabIndex = 10;
            this.button4.Text = "Удалить элемент";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ShowSorted
            // 
            this.ShowSorted.Location = new System.Drawing.Point(1917, 514);
            this.ShowSorted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowSorted.Name = "ShowSorted";
            this.ShowSorted.Size = new System.Drawing.Size(231, 55);
            this.ShowSorted.TabIndex = 24;
            this.ShowSorted.Text = "Применить";
            this.ShowSorted.UseVisualStyleBackColor = true;
            this.ShowSorted.Click += new System.EventHandler(this.ShowSorted_Click_1);
            // 
            // SortSalary
            // 
            this.SortSalary.AutoSize = true;
            this.SortSalary.Location = new System.Drawing.Point(1516, 442);
            this.SortSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortSalary.Name = "SortSalary";
            this.SortSalary.Size = new System.Drawing.Size(301, 29);
            this.SortSalary.TabIndex = 23;
            this.SortSalary.TabStop = true;
            this.SortSalary.Text = "Сортировать по стоимости обучения";
            this.SortSalary.UseVisualStyleBackColor = true;
            // 
            // SortAmntPpl
            // 
            this.SortAmntPpl.AutoSize = true;
            this.SortAmntPpl.Location = new System.Drawing.Point(1516, 358);
            this.SortAmntPpl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortAmntPpl.Name = "SortAmntPpl";
            this.SortAmntPpl.Size = new System.Drawing.Size(440, 29);
            this.SortAmntPpl.TabIndex = 22;
            this.SortAmntPpl.TabStop = true;
            this.SortAmntPpl.Text = "Сортировать по количеству человек в учебной группе";
            this.SortAmntPpl.UseVisualStyleBackColor = true;
            // 
            // SortProjName
            // 
            this.SortProjName.AutoSize = true;
            this.SortProjName.Location = new System.Drawing.Point(1516, 316);
            this.SortProjName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortProjName.Name = "SortProjName";
            this.SortProjName.Size = new System.Drawing.Size(393, 29);
            this.SortProjName.TabIndex = 21;
            this.SortProjName.TabStop = true;
            this.SortProjName.Text = "Сортировать по названию(номеру) группы";
            this.SortProjName.UseVisualStyleBackColor = true;
            // 
            // SortExp
            // 
            this.SortExp.AutoSize = true;
            this.SortExp.Location = new System.Drawing.Point(1516, 400);
            this.SortExp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortExp.Name = "SortExp";
            this.SortExp.Size = new System.Drawing.Size(347, 29);
            this.SortExp.TabIndex = 20;
            this.SortExp.TabStop = true;
            this.SortExp.Text = "Сортировать по количеству лет обучения в вузе ";
            this.SortExp.UseVisualStyleBackColor = true;
            // 
            // SortAge
            // 
            this.SortAge.AutoSize = true;
            this.SortAge.Location = new System.Drawing.Point(1516, 358);
            this.SortAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortAge.Name = "SortAge";
            this.SortAge.Size = new System.Drawing.Size(298, 29);
            this.SortAge.TabIndex = 19;
            this.SortAge.TabStop = true;
            this.SortAge.Text = "Сортировать по возрасту";
            this.SortAge.UseVisualStyleBackColor = true;
            // 
            // SortName
            // 
            this.SortName.AutoSize = true;
            this.SortName.Location = new System.Drawing.Point(1516, 316);
            this.SortName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortName.Name = "SortName";
            this.SortName.Size = new System.Drawing.Size(271, 29);
            this.SortName.TabIndex = 18;
            this.SortName.TabStop = true;
            this.SortName.Text = "Сортировать по имени";
            this.SortName.UseVisualStyleBackColor = true;
            // 
            // Older30
            // 
            this.Older20.AutoSize = true;
            this.Older20.Location = new System.Drawing.Point(1516, 319);
            this.Older20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Older20.Name = "Older20";
            this.Older20.Size = new System.Drawing.Size(208, 29);
            this.Older20.TabIndex = 25;
            this.Older20.TabStop = true;
            this.Older20.Text = "Люди старше 20";
            this.Older20.UseVisualStyleBackColor = true;
            // 
            // ExpOver10
            // 
            this.ExpOver4.AutoSize = true;
            this.ExpOver4.Location = new System.Drawing.Point(1516, 319);
            this.ExpOver4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExpOver4.Name = "ExpOver4";
            this.ExpOver4.Size = new System.Drawing.Size(491, 29);
            this.ExpOver4.TabIndex = 26;
            this.ExpOver4.TabStop = true;
            this.ExpOver4.Text = "Ученики, обучающиеся в вузе более 4 лет";
            this.ExpOver4.UseVisualStyleBackColor = true;
            // 
            // PplOver10
            // 
            this.PplOver10.AutoSize = true;
            this.PplOver10.Location = new System.Drawing.Point(1516, 319);
            this.PplOver10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PplOver10.Name = "PplOver10";
            this.PplOver10.Size = new System.Drawing.Size(446, 29);
            this.PplOver10.TabIndex = 27;
            this.PplOver10.TabStop = true;
            this.PplOver10.Text = "Учебные группы с числом человек больше 10";
            this.PplOver10.UseVisualStyleBackColor = true;
            // 
            // FilterShow
            // 
            this.FilterShow.Location = new System.Drawing.Point(1917, 361);
            this.FilterShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilterShow.Name = "FilterShow";
            this.FilterShow.Size = new System.Drawing.Size(231, 55);
            this.FilterShow.TabIndex = 28;
            this.FilterShow.Text = "Применить";
            this.FilterShow.UseVisualStyleBackColor = true;
            this.FilterShow.Click += new System.EventHandler(this.FilterShow_Click);
            // 
            // AddObj
            // 
            this.AddObj.Location = new System.Drawing.Point(1917, 612);
            this.AddObj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddObj.Name = "AddObj";
            this.AddObj.Size = new System.Drawing.Size(231, 53);
            this.AddObj.TabIndex = 62;
            this.AddObj.Text = "Добавить";
            this.AddObj.UseVisualStyleBackColor = true;
            this.AddObj.Click += new System.EventHandler(this.AddObj_Click);
            // 
            // PplAmntTB
            // 
            this.PplAmntTB.Location = new System.Drawing.Point(1810, 378);
            this.PplAmntTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PplAmntTB.Name = "PplAmntTB";
            this.PplAmntTB.Size = new System.Drawing.Size(150, 31);
            this.PplAmntTB.TabIndex = 61;
            this.PplAmntTB.TextChanged += new System.EventHandler(this.PplAmntTB_TextChanged);
            // 
            // ProjNameTB
            // 
            this.ProjNameTB.Location = new System.Drawing.Point(1810, 334);
            this.ProjNameTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjNameTB.Name = "ProjNameTB";
            this.ProjNameTB.Size = new System.Drawing.Size(150, 31);
            this.ProjNameTB.TabIndex = 60;
            this.ProjNameTB.TextChanged += new System.EventHandler(this.ProjNameTB_TextChanged);
            // 
            // WorkExpTB
            // 
            this.WorkExpTB.Location = new System.Drawing.Point(1810, 553);
            this.WorkExpTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WorkExpTB.Name = "WorkExpTB";
            this.WorkExpTB.Size = new System.Drawing.Size(150, 31);
            this.WorkExpTB.TabIndex = 59;
            this.WorkExpTB.TextChanged += new System.EventHandler(this.WorkExpTB_TextChanged);
            // 
            // StatusTB
            // 
            this.StatusTB.Location = new System.Drawing.Point(1810, 509);
            this.StatusTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.Size = new System.Drawing.Size(150, 31);
            this.StatusTB.TabIndex = 58;
            this.StatusTB.TextChanged += new System.EventHandler(this.StatusTB_TextChanged);
            // 
            // CostTB
            // 
            this.SalaryTB.Location = new System.Drawing.Point(1810, 466);
            this.SalaryTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalaryTB.Name = "CostTB";
            this.SalaryTB.Size = new System.Drawing.Size(150, 31);
            this.SalaryTB.TabIndex = 57;
            this.SalaryTB.TextChanged += new System.EventHandler(this.SalaryTB_TextChanged);
            // 
            // GenderTB
            // 
            this.GenderTB.Location = new System.Drawing.Point(1810, 422);
            this.GenderTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenderTB.Name = "GenderTB";
            this.GenderTB.Size = new System.Drawing.Size(150, 31);
            this.GenderTB.TabIndex = 56;
            this.GenderTB.TextChanged += new System.EventHandler(this.GenderTB_TextChanged);
            // 
            // AgeTB
            // 
            this.AgeTB.Location = new System.Drawing.Point(1810, 378);
            this.AgeTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgeTB.Name = "AgeTB";
            this.AgeTB.Size = new System.Drawing.Size(150, 31);
            this.AgeTB.TabIndex = 55;
            this.AgeTB.TextChanged += new System.EventHandler(this.AgeTB_TextChanged);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(1810, 334);
            this.NameTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(150, 31);
            this.NameTB.TabIndex = 54;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1556, 384);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 25);
            this.label10.TabIndex = 53;
            this.label10.Text = "Количество участников";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1608, 334);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 25);
            this.label9.TabIndex = 52;
            this.label9.Text = "Название группы";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1568, 558);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 25);
            this.label8.TabIndex = 51;
            this.label8.Text = "Количесвто лет обучения в вузе";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1502, 514);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 25);
            this.label7.TabIndex = 50;
            this.label7.Text = "Статус(бакалавр/магистрант)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1695, 470);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Стоимость обучения";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1752, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Пол";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1710, 383);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Возраст";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1750, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Имя";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(15, 52);
            this.IdTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(230, 31);
            this.IdTB.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 6);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(517, 25);
            this.label11.TabIndex = 64;
            this.label11.Text = "Укажите порядковый номер удаляемого элемента";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(416, 86);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(230, 53);
            this.Delete.TabIndex = 65;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteGroup
            // 
            this.DeleteGroup.Controls.Add(this.Delete);
            this.DeleteGroup.Controls.Add(this.label11);
            this.DeleteGroup.Controls.Add(this.IdTB);
            this.DeleteGroup.Location = new System.Drawing.Point(253, 262);
            this.DeleteGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteGroup.Name = "DeleteGroup";
            this.DeleteGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteGroup.Size = new System.Drawing.Size(669, 167);
            this.DeleteGroup.TabIndex = 66;
            this.DeleteGroup.TabStop = false;
            this.DeleteGroup.Text = "Удаление элемента";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(1734, 739);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(206, 44);
            this.Save.TabIndex = 67;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(1962, 739);
            this.SaveAs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(200, 44);
            this.SaveAs.TabIndex = 68;
            this.SaveAs.Text = "Сохранить как";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1482, 741);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 41);
            this.button1.TabIndex = 69;
            this.button1.Text = "Логи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2199, 795);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DeleteGroup);
            this.Controls.Add(this.AddObj);
            this.Controls.Add(this.PplAmntTB);
            this.Controls.Add(this.ProjNameTB);
            this.Controls.Add(this.WorkExpTB);
            this.Controls.Add(this.StatusTB);
            this.Controls.Add(this.SalaryTB);
            this.Controls.Add(this.GenderTB);
            this.Controls.Add(this.AgeTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilterShow);
            this.Controls.Add(this.PplOver10);
            this.Controls.Add(this.ExpOver4);
            this.Controls.Add(this.Older20);
            this.Controls.Add(this.ShowSorted);
            this.Controls.Add(this.SortSalary);
            this.Controls.Add(this.SortAmntPpl);
            this.Controls.Add(this.SortProjName);
            this.Controls.Add(this.SortExp);
            this.Controls.Add(this.SortAge);
            this.Controls.Add(this.SortName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.FilterBy);
            this.Controls.Add(this.SortBy);
            this.Controls.Add(this.ShowObj);
            this.Controls.Add(this.ChooseType);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ChooseFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Laba3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DeleteGroup.ResumeLayout(false);
            this.DeleteGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox ChooseType;
        private System.Windows.Forms.Button ShowObj;
        private System.Windows.Forms.Button SortBy;
        private System.Windows.Forms.Button FilterBy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ShowSorted;
        private System.Windows.Forms.RadioButton SortSalary;
        private System.Windows.Forms.RadioButton SortAmntPpl;
        private System.Windows.Forms.RadioButton SortProjName;
        private System.Windows.Forms.RadioButton SortExp;
        private System.Windows.Forms.RadioButton SortAge;
        private System.Windows.Forms.RadioButton SortName;
        private System.Windows.Forms.RadioButton Older20;
        private System.Windows.Forms.RadioButton ExpOver4;
        private System.Windows.Forms.RadioButton PplOver10;
        private System.Windows.Forms.Button FilterShow;
        private System.Windows.Forms.Button AddObj;
        private System.Windows.Forms.TextBox PplAmntTB;
        private System.Windows.Forms.TextBox ProjNameTB;
        private System.Windows.Forms.TextBox WorkExpTB;
        private System.Windows.Forms.TextBox StatusTB;
        private System.Windows.Forms.TextBox SalaryTB;
        private System.Windows.Forms.TextBox GenderTB;
        private System.Windows.Forms.TextBox AgeTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.GroupBox DeleteGroup;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button SaveAs;
        private System.Windows.Forms.Button button1;
    }
}

