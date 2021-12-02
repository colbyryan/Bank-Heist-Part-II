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
            player1.SkillLevel = 12;
            player1.PercentageCut = 50;
            Muscle player2 = new Muscle();
            player2.Name = "Katie";
            player2.SkillLevel = 32;
            player2.PercentageCut = 36;
            LockSpecialist player3 = new LockSpecialist();
            player3.Name = "Ben";
            player3.SkillLevel = 89;
            player3.PercentageCut = 68;
            Hacker player4 = new Hacker();
            player4.Name = "Josh";
            player4.SkillLevel = 57;
            player4.PercentageCut = 76;
            Muscle player5 = new Muscle();
            player5.Name = "Sam";
            player5.SkillLevel = 90;
            player5.PercentageCut = 80;
            LockSpecialist player6 = new LockSpecialist();
            player6.Name = "Scott";
            player6.SkillLevel = 55;
            player6.PercentageCut = 15;

            List<IRobber> rolodex = new List<IRobber>
            {
              player1, player2, player3, player4, player5, player6
            };
            Console.WriteLine();
            Console.WriteLine("Current Operatives:\n");
            foreach (IRobber r in rolodex)
            {
                Console.Write("Crew Member: ");
                Console.WriteLine(r.Name);
            }

            string CrewMember = "";
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
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
                string specialty = Console.ReadLine();


                Console.WriteLine();
                Console.WriteLine("-----------------------------------------");
                Console.Write($"Enter {CrewMember}'s Skill Level (1-100): ");
                int OperativeSkillLevel = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"What percentage of the cut does {CrewMember} demand?");
                Console.Write("Enter a percentage (0-100): ");
                int cut = int.Parse(Console.ReadLine());

                if (specialty == "Hacker")
                {
                    rolodex.Add(new Hacker()
                    {
                        Name = CrewMember,
                        SkillLevel = OperativeSkillLevel,
                        PercentageCut = cut
                    }
                    );
                }
                else if (specialty == "Muscle")
                {
                    rolodex.Add(new Muscle()
                    {
                        Name = CrewMember,
                        SkillLevel = OperativeSkillLevel,
                        PercentageCut = cut
                    });
                }
                else if (specialty == "Lock Specialist")
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
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------");
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
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            for (int i = 0; i < rolodex.Count; i++)
            {
                Console.WriteLine($"{i} {rolodex[i].Name}:  {rolodex[i].SkillLevel} {rolodex[i].PercentageCut}% ");
                Console.WriteLine($"     Specialty: {rolodex[i].GetType().ToString().Split('.')[2]}");
                Console.WriteLine($"     Skill Level: {rolodex[i].SkillLevel}");
                Console.WriteLine($"     Cut Percent: {rolodex[i].PercentageCut}%");
            }

            List<IRobber> crew = new List<IRobber>();

            int num = -1;

            Console.Write("Enter the number of the operatives you want to include in the heist: ");
            string output = Console.ReadLine();

            while (output != "")
            {
                num = int.Parse(output);
                Console.Write("Enter the number of the operatives you want to include in the heist: ");
                output = Console.ReadLine();
            }




        }
    }
}
