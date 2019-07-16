namespace LiskovSubstitutionPrinciple_Army_Penta.Logic
{
    public interface IBaseSoldier
    {
        int ID { get; }
        string Name { get; }
        string Rank { get; }

        void Attack(string commandToAttack);
    }
}