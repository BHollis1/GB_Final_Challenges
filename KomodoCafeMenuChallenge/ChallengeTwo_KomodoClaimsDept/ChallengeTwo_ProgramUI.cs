using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_KomodoClaimsDept
{
    public class ChallengeTwo_ProgramUI
    {
        private readonly ChallengeTwo_ClaimRepository _claimRepo = new ChallengeTwo_ClaimRepository();

        public void Run()
        {
            SeedContent();
            RunMenu();
        }

        public void RunMenu()
        {
            bool contiinueToRun = true;
            while (contiinueToRun)
            {
                Console.Clear();
                Console.WriteLine("Choose a menu item: \n" +
                    "1) See all claims \n" +
                    "2) Take care of the next claim \n" +
                    "3) Enter a new claim \n" +
                    "4) Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllClaims();
                        break;
                    case "2":
                        UpdateExistingClaim();
                        break;
                    case "3":
                        AddNewClaim();
                        break;
                    case "4":
                        //Exit
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number. \n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
                
            }
        }
        public void AddNewClaim()
        {

        }

        public void ShowAllClaims()
        {
            Console.Clear();
            List<ChallengeTwo_Claim> listOfClaims = _claimRepo.GetClaims();
            foreach (ChallengeTwo_Claim content in listOfClaims)
            {
                Console.WriteLine(content);
            }

        }

        public void UpdateExistingClaim()
        {

        }

        private void DisplaySetup(ChallengeTwo_Claim content)
        {

        }

        private void SeedContent()
        {
            var claimOne = new ChallengeTwo_Claim(1, ClaimType.Car, "Car accident on 465.", 400.00m, 4 / 25 / 18, 4/27/18, true);
            var claimTwo = new ChallengeTwo_Claim(2, ClaimType.Home, "House fire in kitchen.", 4000.00m, 4 / 11 / 18, 4 / 12 / 18, true);
            var claimThree = new ChallengeTwo_Claim(3, ClaimType.Theft, "Stolen pancakes", 4.00m, 4 / 27 / 18, 6 / 01 / 18, false);

            _claimRepo.AddNewClaim(claimOne);
            _claimRepo.AddNewClaim(claimTwo);
            _claimRepo.AddNewClaim(claimThree);

        }
    }
}
