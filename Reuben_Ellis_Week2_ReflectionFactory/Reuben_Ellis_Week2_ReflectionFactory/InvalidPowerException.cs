using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Reuben_Ellis_Week2_ReflectionFactory
{
    class InvalidPowerException : Exception
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public InvalidPowerException() : base()
        {

        }

        /// <summary>
        /// Constructor with one argument
        /// </summary>
        /// <param name="details"></param>
        public InvalidPowerException(string details) : base(details)
        {

        }

        /// <summary>
        /// Constructor with an argument and an inner Exception
        /// </summary>
        /// <param name="details"></param>
        /// <param name="innerException"></param>
        public InvalidPowerException(string details, Exception innerException) : base(details, innerException)
        {

        }

        /// <summary>
        /// Constructor with an argument and serialization support
        /// </summary>
        /// <param name="serialize"></param>
        /// <param name="context"></param>
        public InvalidPowerException(SerializationInfo serialize, StreamingContext context) : base(serialize, context)
        {

        }
    }
}
