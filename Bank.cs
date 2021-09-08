using System;

namespace Heist_II
{
    public class Bank
    {
        public int CashOnHand { get; set; }

        public int AlarmScore { get; set; }

        public int VaultScore { get; set; }

        public int SecurityGuardScore { get; set; }

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