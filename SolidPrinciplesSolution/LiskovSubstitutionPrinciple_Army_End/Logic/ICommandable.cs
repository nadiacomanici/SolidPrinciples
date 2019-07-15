using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple_Army_End.Logic
{
    public interface ICommandable
    {
        ICommander HierarchicalSuperior { get; set; }
        void ReportToSuperior();
    }
}
