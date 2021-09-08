using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank Suntrust = new Bank
            {
                AlarmScore =  new Random().Next(0, 101),
                VaultScore =  new Random().Next(0, 101),
                SecurityGuardScore =  new Random().Next(0, 101),
                CashOnHand =  new Random().Next(50000, 1000001)
            };

            var bankProperities = new List<int>{Suntrust.AlarmScore, Suntrust.VaultScore, Suntrust.SecurityGuardScore};
            void ReconReport()
            {
                if (bankProperities.Max() == Suntrust.AlarmScore)
                {
                    Console.WriteLine("Most Secure: Alarm");
                }
                else if (bankProperities.Max() == Suntrust.VaultScore)
                {
                    Console.WriteLine("Most Secure: Vault");
                }
                else
                {
                    Console.WriteLine("Most Secure: SecurityGuard");
                }

                if (bankProperities.Min() == Suntrust.AlarmScore)
                {
                    Console.WriteLine("Least Secure: Alarm");
                }
                else if (bankProperities.Min() == Suntrust.VaultScore)
                {
                    Console.WriteLine("Least Secure: Vault");
                }
                else
                {
                    Console.WriteLine("Least Secure: SecurityGuard");
                }
            }

            Hacker Jon = new Hacker
            {
                Name = "Jon",
                SkillLevel = 25,
                PercentageCut = 8
            };
            Muscle Dan = new Muscle
            {
                Name = "Dan",
                SkillLevel = 50,
                PercentageCut = 10
            };
            Muscle Kurt = new Muscle
            {
                Name = "Kurt",
                SkillLevel = 35,
                PercentageCut = 10
            };
            Hacker Kim = new Hacker
            {
                Name = "Kim",
                SkillLevel = 28,
                PercentageCut = 10
            };
            LockSpecialist Tim = new LockSpecialist
            {
                Name = "Tim",
                SkillLevel = 32,
                PercentageCut = 10
            };
            LockSpecialist Lars = new LockSpecialist
            {
                Name = "Lars",
                SkillLevel = 29,
                PercentageCut = 25
            };

            List<IRobber> rolodex = new List<IRobber>
        {
            Jon, Dan, Kurt, Kim, Tim, Lars
        };

            HeistTime();

            void HeistTime()
            {

                Console.WriteLine($"{rolodex.Count}");
                Console.WriteLine("Enter the name of the new member.");
                var NewCrewMember = Console.ReadLine();

                Console.WriteLine(@"
                1. Hacker
                2. Muscle
                3. Lock Specialist");

                var Specialty = int.Parse(Console.ReadLine());

                var SpecialityChoice = new List<int>
                {
                    1, 2, 3
                };

                var SelectedChoice = SpecialityChoice[Specialty - 1];


                Console.WriteLine("Choose a Skill level between 1 - 100");
                var MemberSkillLevel = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose your percentage of the cut");
                var MemberPercentCut = int.Parse(Console.ReadLine());

                if (Specialty == 1)
                {
                    Hacker user = new Hacker
                    {
                        Name = NewCrewMember,
                        SkillLevel = MemberSkillLevel,
                        PercentageCut = MemberPercentCut
                    };

                    rolodex.Add(user);

                }
                else if (Specialty == 2)
                {
                    Muscle user = new Muscle
                    {
                        Name = NewCrewMember,
                        SkillLevel = MemberSkillLevel,
                        PercentageCut = MemberPercentCut
                    };

                    rolodex.Add(user);

                }
                else
                {
                    LockSpecialist user = new LockSpecialist
                    {
                        Name = NewCrewMember,
                        SkillLevel = MemberSkillLevel,
                        PercentageCut = MemberPercentCut
                    };

                    rolodex.Add(user);
                }



                Console.WriteLine($"{rolodex.Count}");
                Console.WriteLine($"{Suntrust.AlarmScore}");
                ReconReport();
                PlayAgain();
            }
            void PlayAgain()
            {
                Console.WriteLine("Would you like to add another crew member? Y/N");
                string PlayAgain = Console.ReadLine();

                if (PlayAgain == "y" || PlayAgain == "Y")
                {
                    HeistTime();
                }
                else
                {
                    Console.WriteLine("Well you suck then");
                }
            }
        }
    }
}
