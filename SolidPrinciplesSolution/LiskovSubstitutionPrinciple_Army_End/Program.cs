using LiskovSubstitutionPrinciple_Army_End.Logic;

namespace LiskovSubstitutionPrinciple_Army_End
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 1;

            // Hierarchy:
            //  napoleon
            //  --> jacques
            //  --> philipe
            //  ------> pasquale
            //  ------> gaston

            var napoleon = new HeadOfState(id++, "Napoleon Bonaparte", "Commander in chief");

            var jacquesGeneral = new Officer(id++, "General Jacques", "General");
            napoleon.TakeSoldierUnderCommand(jacquesGeneral);

            var philipeColonel = new Officer(id++, "Colonel Philipe", "Colonel");
            napoleon.TakeSoldierUnderCommand(philipeColonel);

            var pasqualeSoldier = new Officer(id++, "Pasquale", "Infanterist");
            philipeColonel.TakeSoldierUnderCommand(pasqualeSoldier);

            var gastonSoldier = new Officer(id++, "Gaston", "Infanterist");
            philipeColonel.TakeSoldierUnderCommand(gastonSoldier);

            napoleon.DeclareWar();
            napoleon.Attack("Attaaaack");

            gastonSoldier.ReportToSuperior();
            jacquesGeneral.ReportToSuperior();
        }
    }
}
