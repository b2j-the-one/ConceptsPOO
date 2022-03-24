using System.Runtime.Serialization;

namespace ConceptsPOO
{
    [Serializable]
    internal class MonthdException : Exception
    {
        public MonthdException()
        {
        }

        public MonthdException(string? message) : base(message)
        {
        }

        public MonthdException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MonthdException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}