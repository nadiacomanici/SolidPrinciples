using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple_Army_Begin.Logic
{
    public class Officer : Soldier
    {
        public List<Soldier> SoldiersUnderCommand { get; protected set; }

        public Officer(int id, string name, string rank)
            : base(id, name, rank)
        {
            SoldiersUnderCommand = new List<Soldier>();
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
