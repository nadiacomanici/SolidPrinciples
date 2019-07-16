using System;

namespace LiskovSubstitutionPrinciple_Army_Penta.Logic
{
    public abstract class BaseSoldier : IBaseSoldier
    {
        public int ID { get; protected set; }

        public string Rank { get; protected set; }

        public string Name { get; protected set; }


        public BaseSoldier(int id, string name, string rank)
        {
            ID = id;
            Name = name;
            Rank = rank;
        }        

        public virtual void Attack(string commandToAttack)
        {
            Console.WriteLine($"{commandToAttack} -> {Name}");
        }
    }
}
