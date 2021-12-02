using System;

namespace BankHeistPartII.Crew
{
    public class LockSpecialist : Bank, IRobber
    {

        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            VaultScore -= SkillLevel;

            Console.WriteLine($"{Name} is picking the locks! Decreased by {SkillLevel}");

            if (bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has cracked the code to the Vault!");
            }
        }
    }
}