using System;

namespace Heist_II
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public string Specialty { get; set; } = "Muscle";
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= SkillLevel;
            Console.WriteLine($"{Name} wooped that ass! Decreased security {SkillLevel}");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the guards");
            }
        }
    }
}