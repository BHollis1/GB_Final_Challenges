using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_KomodoClaimsDept
{
    public class ChallengeTwo_ClaimRepository
    {
        protected readonly List<ChallengeTwo_Claim> _claimDirectory = new List<ChallengeTwo_Claim>();

        //Create
        public bool AddNewClaim(ChallengeTwo_Claim content)
        {
            int startingCount = _claimDirectory.Count;
            _claimDirectory.Add(content);
            bool wasAdded = (_claimDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read

        public List<ChallengeTwo_Claim> GetClaims()
        {
            return _claimDirectory;
        }

        public ChallengeTwo_Claim GetClaimByClaimID(int claimID)
        {
            foreach (ChallengeTwo_Claim singleClaim in _claimDirectory)
            {
                if (singleClaim.ClaimID == claimID)
                {
                    return singleClaim;
                }
            }
            return null;
        }

        //Update
        public bool UpdateExistingClaim(int originalClaimID, ChallengeTwo_Claim newClaimInfo)
        {
            ChallengeTwo_Claim oldClaimInfo = GetClaimByClaimID(originalClaimID);

            if (oldClaimInfo != null)
            {
                oldClaimInfo.ClaimID = newClaimInfo.ClaimID;
                oldClaimInfo.ClaimType = newClaimInfo.ClaimType;
                oldClaimInfo.Description = newClaimInfo.Description;
                oldClaimInfo.ClaimAmount = newClaimInfo.ClaimAmount;
                oldClaimInfo.DateOfIncident = newClaimInfo.DateOfIncident;
                oldClaimInfo.DateOfClaim = newClaimInfo.DateOfClaim;
                oldClaimInfo.IsValid = newClaimInfo.IsValid;

                return true;
            }
            {
                return false;
            }
        }

        

    

    

    }


}

