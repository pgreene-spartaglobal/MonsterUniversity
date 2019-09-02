using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MonsterUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            MonsterStudent defaultMonster = new MonsterStudent();
            defaultMonster.Jump();

            MonsterCohort monsterCohort = new MonsterCohort();
            monsterCohort.AddStudent(defaultMonster);
            
            StreamReader file =  new StreamReader("monster_students.txt");
            Console.WriteLine(Directory.GetCurrentDirectory());

            string line;

            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                monsterCohort.listOfStudents.Add(new MonsterStudent(Convert.ToInt32(words[0]), words[1], Convert.ToInt32(words[2]), words[3], Convert.ToDouble(words[4]), words[5]));
            }

            file.Close();

            monsterCohort.ListStudents();
        }
    
    }

    class Monster
    {
        public int id;
        public string name;
        public int eyes;
        public string colour;
        public double scareLevel;
        public string specialAbility;

        public void Jump()
        {
            Console.WriteLine("Monster Jump");
        }

        public void Scare()
        {
            Console.WriteLine("Monster Scare");
        }
    }

    class MonsterStudent : Monster
    {
        public MonsterStudent()
        {
            this.id = 0;
            this.name = "DefaultName";
            this.eyes = 2;
            this.colour = "DefaultColour";
            this.scareLevel = 50;
            this.specialAbility = "DefaultSpecialAbility";
        }

        public MonsterStudent(int id, string name, int eyes, string colour, double scareLevel, string specialAbility)
        {
            this.id = id;
            this.name = name;
            this.colour = colour;
            this.scareLevel = scareLevel;
            this.specialAbility = specialAbility;
        }
    }

    class MonsterCohort
    {
        string subject;
        DateTime startDate;
        public List<MonsterStudent> listOfStudents = new List<MonsterStudent>();

        public MonsterCohort()
        {
            this.subject = "The Art of Scaring";
            this.startDate = DateTime.Now;
        }

        public void AddStudent(MonsterStudent monsterStudent)
        {
            listOfStudents.Add(monsterStudent);
        }

        public void ListStudents()
        {
            foreach (MonsterStudent monsterStudent in listOfStudents)
            {
                Console.WriteLine(String.Format("\nID: {0}\nEyes: {1}\nHair Colour: {2}\nScare Level: {3}\nSpecial Ability: {4}",monsterStudent.id, monsterStudent.eyes, monsterStudent.colour, monsterStudent.scareLevel, monsterStudent.scareLevel));
            }
        }
    }
}
