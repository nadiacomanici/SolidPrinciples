using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple_Army_End.Logic
{
    public interface ICommander : IRegisteredSoldier
    {
        List<IReportable> SoldiersUnderCommand { get; }
        void TakeSoldierUnderCommand(IReportable soldier);
    }
}
