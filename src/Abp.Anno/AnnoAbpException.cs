using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Abp.Anno
{
    /// <summary>
    /// AnnoAbp异常
    /// </summary>
    [Serializable]
    public class AnnoAbpException : AbpException
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public AnnoAbpException()
        {

        }

        /// <summary>
        /// Constructor for serializing.
        /// </summary>
        public AnnoAbpException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {

        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="message">Exception message</param>
        public AnnoAbpException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public AnnoAbpException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
