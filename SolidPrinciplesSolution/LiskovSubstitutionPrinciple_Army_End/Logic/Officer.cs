using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple_Army_End.Logic
{
    public class Officer : Soldier, ICommander
    {
        public List<IReportable> SoldiersUnderCommand { get; protected set; }

        public Officer(int id, string name, string rank)
            : base(id, name, rank)
        {
            SoldiersUnderCommand = new List<IReportable>();
        }

        public void TakeSoldierUnderCommand(IReportable soldier)
        {
            soldier.HierarchicalSuperior = this;
            SoldiersUnderCommand.Add(soldier);
        }

        public override void Attack(string commandToAttack)
        {
            if (SoldiersUnderCommand.Count > 0)
            {
                foreach (var soldier in SoldiersUnderCommand)
                {
                    soldier.Attack($"{commandToAttack} -> {Name}");
                }
            }
            else
            {
                base.Attack(commandToAttack);
            }
        }
    }
}
