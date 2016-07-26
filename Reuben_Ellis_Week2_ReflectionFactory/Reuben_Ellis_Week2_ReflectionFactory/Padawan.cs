using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reuben_Ellis_Week2_ReflectionFactory
{
    public class Padawan : Membership
    {
        #region Members
        private string
            membershipType = "Padawan",
            costOfMembership = "Leave family and be completely obedient",
            benefitNumber1 = "Get a Mentor",
            benefitNumber2 = "2nd benefit only for Jedi Knights or Jedi Masters",
            benefitNumber3 = "3rd benefit only for Jedi Masters";
        #endregion

        #region Methods
        #region Public Methods
        //Returns membership type name
        public string membershipName()
        {
            return membershipType;
        }
        //Returns membership cost
        public string membershipCost()
        {
            return costOfMembership;
        }
        //Returns membership benefit number 1
        public string membershipBenefit1()
        {
            return benefitNumber1;
        }
        //Returns membership benefit number 2
        public string membershipBenefit2()
        {
            return benefitNumber2;
        }
        //Returns membership benefit number 3
        public string membershipBenefit3()
        {
            return benefitNumber3;
        }
        #endregion
        #endregion
    }
}
