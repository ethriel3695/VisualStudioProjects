using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reuben_Ellis_Week2_ReflectionFactory
{
    public interface Membership
    {
        string membershipName();

        string membershipCost();

        string membershipBenefit1();

        string membershipBenefit2();

        string membershipBenefit3();
    }
}
