namespace BankHeistPartII
{
    public class LockSpecialist : Bank, IRobber
    {

        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        void PerformSkill(Bank bank)
        {
            VaultScore = VaultScore - SkillLevel;
        }
    }
}