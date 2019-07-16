using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple_Army_Penta.Logic
{
    public class Soldier : BaseSoldier, IReportable
    {
        public Soldier(int id, string name, string rank) : base(id, name, rank)
        {
        }

        public ICommander HierarchicalSuperior { get; set; }

        public virtual void ReportToSuperior()
        {
            Console.WriteLine($"{Name} reports to {HierarchicalSuperior.Name}");
        }
    }
}
