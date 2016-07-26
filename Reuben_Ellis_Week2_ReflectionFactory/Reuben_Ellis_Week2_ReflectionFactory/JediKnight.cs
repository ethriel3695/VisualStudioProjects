using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reuben_Ellis_Week2_ReflectionFactory
{
    public class Jedi_Knight : Membership
    {
        #region Members
        string
            membershipType = "Jedi Knight",
            costOfMembership = "Must control emotions and no relationships",
            benefitNumber1 = "Get a Mentor",
            benefitNumber2 = "Cool Missions",
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
