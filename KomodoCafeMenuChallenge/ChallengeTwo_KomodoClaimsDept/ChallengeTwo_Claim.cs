using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_KomodoClaimsDept
{
    public enum ClaimType { Car, Home, Theft }
    public class ChallengeTwo_Claim
    {

        public int ClaimID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public int DateOfIncident { get; set; }
        public int DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        public ChallengeTwo_Claim() { }
       
        public ChallengeTwo_Claim(int claimID, ClaimType claimType, string desc, decimal claimAmount, int dateOfIncident, int dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = desc;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;

        }

    }
}
