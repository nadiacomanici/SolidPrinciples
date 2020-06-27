using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple_Army_End.Logic
{
    public interface ICommander : IRegisteredSoldier
    {
        List<ICommandable> SoldiersUnderCommand { get; }
        void TakeSoldierUnderCommand(ICommandable soldier);
    }
}
