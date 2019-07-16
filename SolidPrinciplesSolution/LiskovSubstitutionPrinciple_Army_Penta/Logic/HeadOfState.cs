using System;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple_Army_Penta.Logic
{
    public class HeadOfState : BaseSoldier, ICommander
    {
        public List<Soldier> SoldiersUnderCommand { get; protected set; }

        public HeadOfState(int id, string name, string rank)
            : base(id, name, rank)
        {
            SoldiersUnderCommand = new List<Soldier>();
        }

        public void DeclareWar()
        {
            Console.WriteLine("WAAAAR");
        }

        public void TakeSoldierUnderCommand(Soldier soldier)
        {
            soldier.HierarchicalSuperior = this;
            SoldiersUnderCommand.Add(soldier);
        }

        public override void Attack(string commandToAttack)
        {
            foreach (var soldier in SoldiersUnderCommand)
            {
                soldier.Attack($"{commandToAttack} -> {Name}");
            }
        }
    }
}
