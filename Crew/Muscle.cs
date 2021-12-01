using System;

namespace BankHeistPartII.Crew
{
    public class Muscle : Bank, IRobber
    {

        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        void PerformSkill(Bank bank)
        {
            SecurityGuardScore -= SkillLevel;

            Console.WriteLine($"{Name} is taking care of the guards. Decreased by {SkillLevel}");

            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has got all of the guards under control!");
            }
        }
    }
}