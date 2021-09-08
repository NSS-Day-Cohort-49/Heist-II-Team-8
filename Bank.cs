using System;

namespace Heist_II
{
    public class Bank
    {
        public int CashOnHand { get; set; } = 100;

        public int AlarmScore { get; set; } = 100;

        public int VaultScore { get; set; }  = 100;

        public int SecurityGuardScore { get; set; }  = 100;

        public bool IsSecure 
        { 
            get 
        {
            if (VaultScore is <= 0 && AlarmScore is <= 0 && SecurityGuardScore is <= 0) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    }
}