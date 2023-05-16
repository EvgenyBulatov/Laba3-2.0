using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;
using Newtonsoft.Json;
using System.Xml.Serialization;
using CsvHelper.Configuration;

namespace Laba3_2._0
{
    class Repository
    {
        List<Person> persons { get; set; }
        List<Student> students { get; set; }
        List<StudyGroup> StudyGroups { get; set; }
        
        public void ReadInfo(string path)
        {
            persons = new List<Person>();
            students = new List<Student>();
            StudyGroups = new List<StudyGroup>();

            if (path.Contains(".json"))
            {
                string[] lines = File.ReadAllLines(path, Encoding.Default);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains("Person"))
                    {
                        persons.Add(JsonConvert.DeserializeObject<Person>(lines[i]));
                    }
                    else if (lines[i].Contains("Student"))
                    {
                        students.Add(JsonConvert.DeserializeObject<Student>(lines[i]));
                    }
                    else if (lines[i].Contains("StudyGroup"))
                    {
                        StudyGroups.Add(JsonConvert.DeserializeObject<StudyGroup>(lines[i]));
                    }
                }
            }
            else if (path.Contains(".csv"))
            {
                string[] lines = File.ReadAllLines(path, System.Text.Encoding.UTF8);
                List<string> lst = new List<string>();
                for (int i = 0; i < lines.Length; i++)
                {
                    lst.Add(lines[i]);
                }
                foreach (string t in lst)
                {
                    string[] createstr = t.Split(',');
                    List<string> create = new List<string>();
                    foreach (string x in createstr)
                    {
                        create.Add(x);
                    }
                    if (create[0] == "Person")
                    {
                        persons.Add(new Person(create));
                    }
                    else if (create[0] == "Student")
                    {
                        students.Add(new Student(create));
                    }
                    else
                    {
                        StudyGroups.Add(new StudyGroup(create));
                    }
                }

            }
            else if (path.Contains(".xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<string>));
                List<string> lst = new List<string>();
                using (FileStream stream = File.Open(path, FileMode.Open))
                {
                    lst = (List<string>)xs.Deserialize(stream);
                    foreach (string t in lst)
                    {
                        string[] createstr = t.Split(',');
                        List<string> create = new List<string>();
                        foreach (string x in createstr)
                        {
                            create.Add(x);
                        }
                        if (create[0] == "Person")
                        {
                            persons.Add(new Person(create));
                        }
                        else if (create[0] == "Student")
                        {
                            students.Add(new Student(create));
                        }
                        else
                        {
                            StudyGroups.Add(new StudyGroup(create));
                        }
                    }
                }
            }
            
        }
        public List<Person> GetPersonList()
        {
            return persons;
        }
        public List<Student> GetStudentList()
        {
            return students;
        }
        public List<StudyGroup> GetStudyGroupList()
        {
            return StudyGroups;
        }
        public Person GetPersonById (int id)
        {
            return persons[id];
        }

        public void AddPerson(Person p)
        {

            persons.Add(p);
        }
        public void AddStud(Student en)
        {
            students.Add(en);
        }
        public void AddStudyGroup(StudyGroup wg)
        {
            StudyGroups.Add(wg);
        }
        public void DeletePerson(int id)
        {
            persons.RemoveAt(id);
        }
        public void DeleteStudent(int id)
        {
            students.RemoveAt(id);
        }
        public void DeleteStudyGroup(int id)
        {
            StudyGroups.RemoveAt(id);
        }

        public void Save(string path)
        {
            if (path.Contains(".xml"))
            {
                List<string> lst = new List<string>();
                foreach (Student p in students)
                {
                    lst.Add(p.ToString());
                }
                foreach (Person p in persons)
                {
                    lst.Add(p.ToString());
                }
                foreach (StudyGroup p in StudyGroups)
                {
                    lst.Add(p.ToString());
                }

                XmlAttributeOverrides xOver = new XmlAttributeOverrides();
                XmlSerializer xml = new XmlSerializer(typeof(List<string>), xOver);
                StreamWriter sw = new StreamWriter(path);
                xml.Serialize(sw, lst);
                sw.Close();
            }
            else if (path.Contains (".json"))
            {
                StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8);
                foreach (Person p in persons)
                {
                    sw.Write(JsonConvert.SerializeObject(p) + '\n');
                }
                foreach (Student p in students)
                {
                    sw.Write(JsonConvert.SerializeObject(p) + '\n');
                }
                foreach (StudyGroup p in StudyGroups)
                {
                    sw.Write(JsonConvert.SerializeObject(p) + '\n');
                }
                sw.Close();
            }
            else if (path.Contains (".csv"))
            {

                List<string> lst = new List<string>();
                foreach (Person p in persons)
                {
                    lst.Add(p.ToString());
                }
                foreach (Student p in students)
                {
                    lst.Add(p.ToString());
                }
                foreach (StudyGroup p in StudyGroups)
                {
                    lst.Add(p.ToString());
                }
                StreamWriter sw = new StreamWriter(path);

                for (int i = 0; i < lst.Count; i++)
                {
                    sw.WriteLine(lst[i]);
                }
                sw.Close();
            }
        }
    }
}
