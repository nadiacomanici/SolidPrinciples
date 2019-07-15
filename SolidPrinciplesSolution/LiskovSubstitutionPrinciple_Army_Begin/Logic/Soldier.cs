using System;

namespace LiskovSubstitutionPrinciple_Army_Begin.Logic
{
    public class Soldier
    {
        public int ID { get; protected set; }

        public string Rank { get; protected set; }

        public string Name { get; protected set; }

        public Officer HierarchicalSuperior { get; set; }

        public Soldier(int id, string name, string rank)
        {
            ID = id;
            Name = name;
            Rank = rank;
        }

        public virtual void ReportToSuperior()
        {
            Console.WriteLine($"{Name} reports to {HierarchicalSuperior.Name}");
        }

        public virtual void Attack(string commandToAttack)
        {
            Console.WriteLine($"{commandToAttack} -> {Name}");
        }
    }
}
