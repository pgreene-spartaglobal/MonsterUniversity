using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            monsterCohort.ListStudents();
        }
    }

    class Monster
    {
        public int id;
        public int eyes;
        public string hairColour;
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
            this.eyes = 2;
            this.hairColour = "blue";
            this.scareLevel = 50;
            this.specialAbility = "Roar!";
        }
    }

    class MonsterCohort
    {
        string subject;
        DateTime startDate;
        List<MonsterStudent> listOfStudents = new List<MonsterStudent>();

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
                Console.WriteLine(String.Format("ID: {0}\nEyes: {1}\nHair Colour: {2}\nScare Level: {3}\nSpecial Ability: {4}",monsterStudent.id, monsterStudent.eyes, monsterStudent.hairColour, monsterStudent.scareLevel, monsterStudent.scareLevel));
            }
        }
    }
}
