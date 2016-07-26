using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reuben_Ellis_Week2_ReflectionFactory
{
    public class MembershipFactory
    {
        /// <summary>
        /// Gets the membership Type variable from the combobox value
        /// Instantiates an Assembly and gets the current assembly
        /// Gets all the current types within the assembly and finds
        /// the one which matches the variable passed into the method
        /// returns the Name and FullName of the Type
        /// </summary>
        /// <param name="membershipType"></param>
        /// <returns></returns>
        public static Membership MembershipDetails(string membershipType)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            var currentType = currentAssembly.GetTypes().SingleOrDefault(t => t.Name == membershipType);
            return (Membership)Activator.CreateInstance(currentType);
        }
    }
}
