using System;
using System.Runtime.Serialization;

namespace PhoneSpamerRobot
{
    [Serializable]
    internal class CaptchaErrorException : Exception
    {
        public CaptchaErrorException()
        {
        }

        public CaptchaErrorException(string message) : base(message)
        {
        }

        public CaptchaErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CaptchaErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}