using System;
using BankHeistPartII.Crew;
using System.Collections.Generic;
using System.Linq;

namespace BankHeistPartII
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker player1 = new Hacker();
            player1.Name = "Brady";
            Muscle player2 = new Muscle();
            player2.Name = "Katie";
            LockSpecialist player3 = new LockSpecialist();
            player3.Name = "Ben";
            Hacker player4 = new Hacker();
            player4.Name = "Josh";
            Muscle player5 = new Muscle();
            player5.Name = "Sam";
            LockSpecialist player6 = new LockSpecialist();
            player6.Name = "Scott";

            List<IRobber> rolodex = new List<IRobber>
            {
              player1, player2, player3, player4, player5, player6
            };

            Console.WriteLine("Current Operatives:\n");
            foreach (IRobber r in rolodex)
            {
                Console.WriteLine(r.Name);
            }

            string CrewMember = "";
            Console.Write("Enter the name of a new crew member: ");
            CrewMember = Console.ReadLine();

            while (CrewMember != "")
            {
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
                Console.Write("Enter the name of a new crew member: ");
                CrewMember = Console.ReadLine();
            }

            Random randInt = new Random();

            Bank bank1 = new Bank()
            {
                AlarmScore = randInt.Next(0, 100),
                VaultScore = randInt.Next(0, 100),
                SecurityGuardScore = randInt.Next(0, 100),
                CashOnHand = randInt.Next(50000, 1000000)
            };

            Dictionary<string, int> systemList = new Dictionary<string, int>
            {
                {"Alarm", bank1.AlarmScore}, {"Vault",bank1.VaultScore}, {"Security", bank1.SecurityGuardScore}
            };

            var sortDict = from entry in systemList orderby entry.Value ascending select entry;


            Console.WriteLine($"Least Score: {sortDict.ElementAt(0).Key}");
            Console.WriteLine($"Most Secure: {sortDict.ElementAt(2).Key}");

        }
    }
}
