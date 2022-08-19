using System;

namespace LiskovSubstitutionPrinciple_Army_End.Logic
{
    public class Soldier : RegisteredSoldier, IReportable
    {
        public ICommander HierarchicalSuperior { get; set; }

        public Soldier(int id, string name, string rank) : base(id, name, rank)
        {
        }

        public virtual void ReportToSuperior()
        {
            Console.WriteLine($"{Name} reports to {HierarchicalSuperior.Name}");
        }
    }
}
