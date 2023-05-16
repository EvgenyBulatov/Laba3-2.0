using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NLog;
using System.IO;
using System.Diagnostics;

namespace Laba3_2._0
{
    public partial class Form1 : Form
    {
        
        private static Logger logger = LogManager.GetCurrentClassLogger();
        string path = "";
        Repository repository = new Repository();
        public Form1()
        {
            File.WriteAllText("logs.txt", string.Empty);
            InitializeComponent();
            ChooseType.Items.AddRange(new string[] { "Person", "Student", "Study Group" });
            Clean();

        }
        public void Clean()
        {
            SortName.Visible = false;
            SortAge.Visible = false;
            SortSalary.Visible = false;
            SortExp.Visible = false;
            SortProjName.Visible = false;
            SortAmntPpl.Visible = false;
            ExpOver4.Visible = false;
            Older20.Visible = false;
            FilterShow.Visible = false;
            PplOver10.Visible = false;
            ShowSorted.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            NameTB.Visible = false;
            AgeTB.Visible = false;
            GenderTB.Visible = false;
            SalaryTB.Visible = false;
            StatusTB.Visible = false;
            WorkExpTB.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            ProjNameTB.Visible = false;
            PplAmntTB.Visible = false;
            AddObj.Visible = false;
            DeleteGroup.Visible = false;
        }
        private void ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON files (*.json)|*.json|XML files (*.xml)|*.xml|CSV files (*csv)|*.csv";
            repository.ReadInfo(path);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                repository.ReadInfo(path);
                richTextBox1.Text = path;
                logger.Info($"Открытие файла {path}");
            }
            
            
        }
        private void FillTable(string type)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            if (type == "Person")
            {
                dataGridView1.Columns.Add("Column1", "Type");
                dataGridView1.Columns.Add("Column2", "Name");
                dataGridView1.Columns.Add("Column3", "Age");
                dataGridView1.Columns.Add("Column4", "Gender");
            }
            else if (type == "Student")
            {
                dataGridView1.Columns.Add("Column1", "Type");
                dataGridView1.Columns.Add("Column2", "Name");
                dataGridView1.Columns.Add("Column3", "Age");
                dataGridView1.Columns.Add("Column4", "Gender");
                dataGridView1.Columns.Add("Column5", "Cost of study");
                dataGridView1.Columns.Add("Column5", "Status");
                dataGridView1.Columns.Add("Column6", "Stage of learning");
            }
            else if (type == "Study Group")
            {
                dataGridView1.Columns.Add("Column1", "Type");
                dataGridView1.Columns.Add("Column3", "Study Group Name");
                dataGridView1.Columns.Add("Column2", "Amount of People");
            }
        }
        public void FillInfoTable(string type, List<Person> persons, List<Student> students, List<StudyGroup> studygroups)
        {
            if (type == "Person")
            {
                foreach (Person p in persons)
                {
                    string str = p.ToString();
                    dataGridView1.Rows.Add(str.Split(','));
                }
            }
            else if (type == "Student")
            {
                foreach (Student en in students)
                {
                    string str = en.ToString();
                    dataGridView1.Rows.Add(str.Split(','));
                }
            }
            else if (type == "Study Group")
            {
                foreach (StudyGroup wg in studygroups)
                {
                    string str = wg.ToString();
                    dataGridView1.Rows.Add(str.Split(','));
                }
            }
        }
        private void ShowObj_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                if (ChooseType.SelectedItem != null)
                {
                    string type = ChooseType.SelectedItem.ToString();
                    FillTable(type);
                    FillInfoTable(type, repository.GetPersonList(), repository.GetStudentList(), repository.GetStudyGroupList());
                    logger.Info($"Показ объектов из файла типа {type}");
                }
                else
                {
                    MessageBox.Show("Не выбран тип объектов");
                    logger.Info($"Ошибка из-за отсутствия выбранного типа объектов");
                }
            }
            else
            {
                MessageBox.Show("Не выбран файл");
                logger.Info($"Ошибка из-за отсутствия выбранного файла");
            }
        }

        private void SortBy_Click(object sender, EventArgs e)
        {
            if (ChooseType.SelectedItem != null)
            {
                Clean();
                string type = ChooseType.SelectedItem.ToString();
                if (type == "Person")
                {
                    SortName.Visible = true;
                    SortAge.Visible = true;
                    SortSalary.Visible = false;
                    SortExp.Visible = false;
                    SortProjName.Visible = false;
                    SortAmntPpl.Visible = false;
                }
                else if (type == "Student")
                {
                    SortName.Visible = true;
                    SortAge.Visible = true;
                    SortSalary.Visible = true;
                    SortExp.Visible = true;
                    SortProjName.Visible = false;
                    SortAmntPpl.Visible = false;
                }
                else if (type == "Study Group")
                {
                    SortName.Visible = false;
                    SortAge.Visible = false;
                    SortSalary.Visible = false;
                    SortExp.Visible = false;
                    SortProjName.Visible = true;
                    SortAmntPpl.Visible = true;
                }
                ShowSorted.Visible = true;
                logger.Info($"Выбор сортировки объектов типа {type}");
            }
            else
            {
                MessageBox.Show("Не выбран типа объектов");
            }
        }

        private void ShowSorted_Click_1(object sender, EventArgs e)
        {
            
            string type = ChooseType.SelectedItem.ToString();
            List<Person> persons = repository.GetPersonList();
            List<Student> students = repository.GetStudentList();
            List<StudyGroup> studygroups = repository.GetStudyGroupList();
            if (type == "Person")
            {
                if (SortName.Checked)
                {
                    var items = from person in persons orderby person.name select person;
                    persons = items.ToList<Person>();
                    logger.Info($"Сортировка объектов {type} по имени");
                }
                else if (SortAge.Checked)
                {
                    persons = (from person in persons orderby person.age select person).ToList<Person>();
                    logger.Info($"Сортировка объектов {type} по возрасту");
                }
                FillTable(type);
                FillInfoTable(type, persons, students, studygroups);
            }
            else if (type == "Student")
            {
                if (SortName.Checked)
                {
                    students = (from eng in students orderby eng.name select eng).ToList<Student>();
                    logger.Info($"Сортировка объектов {type} по имени");
                }
                else if (SortAge.Checked)
                {
                    students = (from eng in students orderby eng.age select eng).ToList<Student>();
                    logger.Info($"Сортировка объектов {type} по возрасту");
                }
                else if (SortExp.Checked)
                {
                    students = (from eng in students orderby eng.workexp select eng).ToList<Student>();
                    logger.Info($"Сортировка объектов {type} по годам обучения в вузе");
                }
                else if (SortSalary.Checked)
                {
                    students = (from eng in students orderby eng.coststud select eng).ToList<Student>();
                    logger.Info($"Сортировка объектов {type} по зарплате");
                }
                FillTable(type);
                FillInfoTable(type, persons, students, studygroups);
            }
            else if (type == "Ыегвн Group")
            {
                if (SortProjName.Checked)
                {
                    studygroups = (from wg in studygroups orderby wg.GroupName select wg).ToList<StudyGroup>();
                    logger.Info($"Сортировка объектов {type} по названию группы");
                }
                else if (SortAmntPpl.Checked)
                {
                    studygroups = (from wg in studygroups orderby wg.amountOfPeople select wg).ToList<StudyGroup>();
                    logger.Info($"Сортировка объектов {type} по количеству человек в учебной группе");
                }
                FillTable(type);
                FillInfoTable(type, persons, students, studygroups);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clean();
            
            if (ChooseType.SelectedItem != null)
            {
                string type = ChooseType.SelectedItem.ToString();
                if (type == "Person")
                {
                    Older20.Visible = true;
                    
                }
                else if (type == "Student")
                {
                    ExpOver4.Visible = true;
                    
                }
                else if (type == "Study Group")
                {
                    PplOver10.Visible = true;
                    
                }
                FilterShow.Visible = true;
                logger.Info($"Выбор фильтрации объектов");
            }
            else
            {
                MessageBox.Show("Не выбран тип объектов");
                logger.Info($"Ошибка из-за невыбранного типа объектов");
            }
            
        }

        private void FilterShow_Click(object sender, EventArgs e)
        {
            string type = ChooseType.SelectedItem.ToString();
            List<Person> persons = repository.GetPersonList();
            List<Student> students = repository.GetStudentList();
            List<StudyGroup> studygroups = repository.GetStudyGroupList();
            if (type == "Person")
            {
                persons = (from person in persons where (person.age > 30) select person).ToList<Person>();
                logger.Info($"Фильрация объектов {type} по возрасту");
            }
            else if (type == "Student")
            {
                students = (from eng in students where (eng.workexp > 10) select eng).ToList<Student>();
                logger.Info($"Фильтрация объектов {type} по количеству лет обучения в вузе");
            }
            else if (type == "Study Group")
            {
                studygroups = (from wg in studygroups where (wg.amountOfPeople > 10) select wg).ToList<StudyGroup>();
                logger.Info($"Фильтрация объектов {type} по количеству человек в группе");
            }
            FillTable(type);
            FillInfoTable(type, persons, students, studygroups);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clean();
            if (ChooseType.SelectedItem != null)
            {
                string type = ChooseType.SelectedItem.ToString();
                if (type == "Person")
                {
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    NameTB.Visible = true;
                    AgeTB.Visible = true;
                    GenderTB.Visible = true;
                }
                else if (type == "Student")
                {
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    NameTB.Visible = true;
                    AgeTB.Visible = true;
                    GenderTB.Visible = true;
                    SalaryTB.Visible = true;
                    StatusTB.Visible = true;
                    WorkExpTB.Visible = true;
                }
                else if (type == "Study Group")
                {
                    label9.Visible = true;
                    label10.Visible = true;

                    ProjNameTB.Visible = true;
                    PplAmntTB.Visible = true;
                }
                AddObj.Visible = true;
                logger.Info($"Выбор добавления объекта {type}");
            }
            else
            {
                MessageBox.Show("Не выбран тип объектов");
                logger.Info($"Ошибка из-за невыбранного типа");
            }
        }

        private void AddObj_Click(object sender, EventArgs e)
        {
            string type = ChooseType.SelectedItem.ToString();
            List<Person> persons = repository.GetPersonList();
            List<Student> students = repository.GetStudentList();
            List<StudyGroup> studygroups = repository.GetStudyGroupList();
            if (type == "Person")
            {
                if (NameTB.Text !="" && AgeTB.Text != "" && GenderTB.Text != "")
                {
                    string[] lst = { type, NameTB.Text, AgeTB.Text, GenderTB.Text };
                    List<string> create = new List<string>();
                    foreach (string x in lst)
                    {
                        create.Add(x);
                    }
                    repository.AddPerson(new Person(create));
                    FillTable(type);
                    FillInfoTable(type, persons, students, studygroups);
                    logger.Info($"Добавление нового объекта {type}: name: {NameTB.Text}, age: {AgeTB.Text}, gender: {GenderTB.Text}");
                }
                else
                {
                    MessageBox.Show("Поля пустые");
                    logger.Info("Ошибка из-за пустых полей");
                }
                
            }
            else if (type == "Student")
            {
                if (NameTB.Text !="" && AgeTB.Text != "" && GenderTB.Text != "" && SalaryTB.Text != "" && StatusTB.Text != "" && WorkExpTB.Text != "")
                {
                    string[] lst = { type, NameTB.Text, AgeTB.Text, GenderTB.Text, SalaryTB.Text, StatusTB.Text, WorkExpTB.Text};
                    List<string> create = new List<string>();
                    foreach (string x in lst)
                    {
                        create.Add(x);
                    }
                    repository.AddStud(new Student(create));
                    FillTable(type);
                    FillInfoTable(type, persons, students, studygroups);
                    logger.Info($"Добавление нового объекта {type}: name: {NameTB.Text}, age: {AgeTB.Text}, gender: {GenderTB.Text}, salary: {SalaryTB.Text}, status: {StatusTB.Text}, work experience: {WorkExpTB.Text} ");
                }
                else
                {
                    MessageBox.Show("Поля пустые");
                    logger.Info("Ошибка из-за пустых полей");
                }
            }
            else if (type == "Study Group")
            {
                if (ProjNameTB.Text != "" && PplAmntTB.Text != "")
                {
                    string[] lst = { type, ProjNameTB.Text, PplAmntTB.Text};
                    List<string> create = new List<string>();
                    foreach (string x in lst)
                    {
                        create.Add(x);
                    }
                    repository.AddStudyGroup(new StudyGroup(create));
                    FillTable(type);
                    FillInfoTable(type, persons, students, studygroups);
                    logger.Info($"Добавление нового объекта {type}: project name: {ProjNameTB.Text}, amount of people: {PplAmntTB.Text}");
                }
                else
                {
                    MessageBox.Show("Поля пустые");
                    logger.Info("Ошибка из-за пустых полей");
                }
            }
            

        }

        private void PplAmntTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void WorkExpTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatusTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalaryTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenderTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ChooseType.SelectedItem != null)
            {
                Clean();
                DeleteGroup.Visible = true;
                logger.Info("Выбор удаления элемента");
            }
            else
            {
                MessageBox.Show("Не выбран тип объектов");
            }
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string type = ChooseType.SelectedItem.ToString();
            if (IdTB.Text != "")
            {
                int id = Convert.ToInt32(IdTB.Text) - 1;
                if (type == "Person")
                {
                    try
                    {
                        repository.DeletePerson(id);
                        FillTable(type);
                        FillInfoTable(type, repository.GetPersonList(), repository.GetStudentList(),repository.GetStudyGroupList());
                        
                    }
                    catch
                    {
                        MessageBox.Show("Такого элемента нет");
                        logger.Info("Ошибка из-за отсутствия элемента с заданным индексом");
                    }
                    
                }
                else if (type == "Student")
                {
                    try
                    {
                        repository.DeleteStudent(id);
                        FillTable(type);
                        FillInfoTable(type, repository.GetPersonList(), repository.GetStudentList(), repository.GetStudyGroupList());
                    }
                    catch
                    {
                        MessageBox.Show("Такого элемента нет");
                        logger.Info("Ошибка из-за отсутствия элемента с заданным индексом");
                    }
                    
                }
                else
                {
                    try
                    {
                        repository.DeleteStudyGroup(id);
                        FillTable(type);
                        FillInfoTable(type, repository.GetPersonList(), repository.GetStudentList(), repository.GetStudyGroupList());
                    }
                    catch
                    {
                        MessageBox.Show("Такого элемента нет");
                        logger.Info("Ошибка из-за отсутствия элемента с заданным индексом");
                    }
                    
                }
                logger.Info($"Удаление элемента типа{type} с индексом {id}");
            }
            else
            {
                MessageBox.Show("Пустое значение");
            }
            
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            repository.Save(path);
            logger.Info("Сохранение документа под старым именем");
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JSON|*.json|CSV|*.csv|XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                repository.Save(sfd.FileName);
            }
            logger.Info("Сохранене документа под новым именем");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fpath = "logs.txt";
            Process proc = Process.Start("notepad.exe", fpath);
            proc.Close();
        }
    }
}
