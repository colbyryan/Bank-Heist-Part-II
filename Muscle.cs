namespace BankHeistPartII
{
    public class Muscle : Bank, IRobber
    {

        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        void PerformSkill(Bank bank)
        {
            SecurityGuardScore = SecurityGuardScore - SkillLevel;
        }
    }
}