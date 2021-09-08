using System;

namespace Heist_II
{
    public class LockSpecialist : IRobber
        {

        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
           bank.VaultScore -= SkillLevel; 
           Console.WriteLine($"{Name} is making progress... Decreased security {SkillLevel}");
           if (bank.VaultScore <= 0)
           {
               Console.WriteLine($"{Name} has disabled the vault door");
           }
        }
     }
}        