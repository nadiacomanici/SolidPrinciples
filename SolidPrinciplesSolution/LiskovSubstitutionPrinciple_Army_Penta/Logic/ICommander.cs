using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple_Army_Penta.Logic
{
    public interface ICommander : IBaseSoldier
    {
        void TakeSoldierUnderCommand(Soldier soldier);
    }
}
