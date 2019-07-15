using LiskovSubstitutionPrinciple_Army_Penta.Logic;

namespace LiskovSubstitutionPrinciple_Army_Penta
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 1;

            // napoleon
            // --> jacques
            // --> philipe
            // ------> pasquale
            // ------> gaston

            var napoleon = new HeadOfState(id++, "Napoleon Bonaparte", "Commander in chief");

            var jacquesGeneral = new Officer(id++, "General Jacques", "General");
            napoleon.TakeSoldierUnderCommand(jacquesGeneral);

            var philipeColonel = new Officer(id++, "Colonel Philipe", "Colonel");
            napoleon.TakeSoldierUnderCommand(philipeColonel);

            var pasqualeSoldier = new Soldier(id++, "Pasquale", "Infanterist");
            philipeColonel.TakeSoldierUnderCommand(pasqualeSoldier);

            var gastonSoldier = new Soldier(id++, "Gaston", "Infanterist");
            philipeColonel.TakeSoldierUnderCommand(gastonSoldier);

            napoleon.DeclareWar();
            napoleon.Attack("Attaaaack");

            gastonSoldier.ReportToSuperior();
            jacquesGeneral.ReportToSuperior();
        }
    }
}
