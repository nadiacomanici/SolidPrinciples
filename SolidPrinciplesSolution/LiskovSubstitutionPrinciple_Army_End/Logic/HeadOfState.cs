using System;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple_Army_End.Logic
{
    public class HeadOfState : RegisteredSoldier, ICommander
    {
        public List<Soldier> SoldiersUnderCommand { get; private set; }

        public HeadOfState(int id, string name, string rank)
            : base(id, name, rank)
        {
        }

        public void DeclareWar()
        {

        }

        public void TakeSoldierUnderCommand(Soldier soldier)
        {
            soldier.HierarchicalSuperior = this;
            SoldiersUnderCommand.Add(soldier);
        }
    }
}
