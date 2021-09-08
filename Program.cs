using System;
using System.Collections.Generic;

namespace Heist_II
{
    class Program
    {
        static void Main(string[] args)
        {
                 




             Hacker Jon = new Hacker
             {
                 Name = "Jon",
                 SkillLevel = 25,
                 PercentageCut = 8 
             };
             Muscle Dan = new Muscle{
                 Name = "Dan",
                 SkillLevel = 50,
                 PercentageCut = 10
             };
             Muscle Kurt = new Muscle{
                 Name = "Kurt",
                 SkillLevel = 35,
                 PercentageCut = 10
             };     
             Hacker Kim = new Hacker{
                 Name = "Kim",
                 SkillLevel = 28,
                 PercentageCut = 10 
             };
             LockSpecialist Tim = new LockSpecialist{
                 Name = "Tim",
                 SkillLevel = 32,
                 PercentageCut = 10 
             };
             LockSpecialist Lars = new LockSpecialist{
                 Name = "Lars",
                 SkillLevel = 29,
                 PercentageCut = 25
             };
         
         List<IRobber> rolodex = new List<IRobber>
         { 
             Jon, Dan, Kurt, Kim, Tim, Lars
         };

            Console.WriteLine($"{rolodex.Count}");
            Console.WriteLine("Enter the name of the new member.");
            var NewCrewMember = Console.ReadLine();
                  
        }}}