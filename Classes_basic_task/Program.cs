using System;
using System.Collections.Generic;

namespace Classes_basic_task
{

    class Program
    {
        static void Main(string[] args)
        {
            //6) Організувати можливість введення команд та співробітників до команд та виведення інформації про них
            var team = new Team("Тестова команда");
            team.Add_teammate(new Manager("Даніїл Макаров"));
            team.Show_detailed_info();
            Console.ReadKey();
        }
    }

    abstract class Worker
    {
        // конструктор, який приймає на вхід ім'я
        public Worker(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public string Position { get; protected set; }
        public string WorkDay { get; private set; }
        protected void Call()
        {
            // TODO
        }
        protected void WriteCode()
        {
            // TODO
        }
        protected void Relax()
        {
            // TODO
        }
        public abstract void FillWorkDay();
    }
    class Developer : Worker
    {
        public Developer(string name) : base(name)
        {
            Position = "Розробник";
        }
        public override void FillWorkDay()
        {
            WriteCode();
            Call();
            Relax();
            WriteCode();
        }
    }
    class Manager : Worker
    {
        public Manager(string name) : base(name)
        {
            //Position = ??
        }
        private Random rand;
        public override void FillWorkDay()
        {
            for (int i = 0; i < rand.Next(10) + 1; i++)
            {
                Call();
            }
            Relax();
            for (int i = 0; i < rand.Next(5) + 1; i++)
            {
                Call();
            }
        }
    }
    class Team
    {
        public Team(string name)
        {
            Name = name;
            team_list = new List<Worker>();
        }
        private string Name;
        public void Add_teammate(Worker teammate)
        {
            team_list.Add(teammate);
        }
        public void Show_info()
        {
            // TODO
        }
        public void Show_detailed_info()
        {
            Console.WriteLine(Name);
            foreach (Worker teammate in team_list)
            {
                Console.WriteLine($"<{teammate.Name}> - <{teammate.Position}> - <{teammate.WorkDay}>$");
            }
        }
        private List<Worker> team_list;
    }
}
