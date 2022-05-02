using System;
using System.Runtime.Serialization;

namespace PhoneSpamerRobot.Sites
{
    [Serializable]
    internal class SiteHTMLException : Exception
    {
        public SiteHTMLException()
        {
        }

        public SiteHTMLException(string message) : base(message)
        {
        }

        public SiteHTMLException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SiteHTMLException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}