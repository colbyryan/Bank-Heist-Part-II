using System;

namespace BankHeistPartII.Crew
{
    public class Hacker : Bank, IRobber
    {

        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= SkillLevel;

            Console.WriteLine($"{Name} is hacking the alarm system. Decreased by {SkillLevel}");

            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has hacked the alarm system, its fully disabled!");
            }
        }
    }
}