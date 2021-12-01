using System;
using BankHeistPartII.Crew;
using System.Collections.Generic;

namespace BankHeistPartII
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker player1 = new Hacker();
            Muscle player2 = new Muscle();
            LockSpecialist player3 = new LockSpecialist();
            Hacker player4 = new Hacker();
            Muscle player5 = new Muscle();
            LockSpecialist player6 = new LockSpecialist();

            List<IRobber> rolodex = new List<IRobber>
            {
              player1, player2, player3, player4, player5, player6
            };

            Console.WriteLine("Current Operatives:\n");
            foreach (IRobber r in rolodex)
            {
                Console.WriteLine(r.Name);
            }

            Console.Write("Enter the name of a new crew member: ");
            string CrewMember = Console.ReadLine();

            Console.WriteLine(@$"
            Please Select a Specialty for {CrewMember}:
            - Hacker
            - Muscle
            - Lock Specialist
            ");

            Console.Write("Enter your selection: ");
            string OperativeSpecialist = Console.ReadLine();

            Console.Write($"Enter {CrewMember}'s Skill Level (1-100): ");
            int OperativeSkillLevel = int.Parse(Console.ReadLine());

            Console.WriteLine($"What percentage of the cut does {CrewMember} demand?");
            Console.Write("Enter a percentage (0-100): ");
            int cut = int.Parse(Console.ReadLine());

            if (OperativeSpecialist == "Hacker")
            {
                rolodex.Add(new Hacker()
                {
                    Name = CrewMember,
                    SkillLevel = OperativeSkillLevel,
                    PercentageCut = cut
                }
                );
            }
            else if (OperativeSpecialist == "Muscle")
            {
                rolodex.Add(new Muscle()
                {
                    Name = CrewMember,
                    SkillLevel = OperativeSkillLevel,
                    PercentageCut = cut
                });
            }
            else if (OperativeSpecialist == "Lock Specialist")
            {
                rolodex.Add(new LockSpecialist
                {
                    Name = CrewMember,
                    SkillLevel = OperativeSkillLevel,
                    PercentageCut = cut
                });
            }
            else
            {
                Console.WriteLine("Not a specialist option, try again");
            }
        }
    }
}
