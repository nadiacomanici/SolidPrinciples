namespace LiskovSubstitutionPrinciple_Army_End.Logic
{
    public interface IRegisteredSoldier
    {
        int ID { get; }
        string Rank { get; }
        string Name { get; }
        void Attack(string commandToAttack);
    }
}
