using System;
#if !NETSTANDARD1_3
using System.Runtime.Serialization;
#endif // !NETSTANDARD1_3

namespace Renci.SshNet.Common
{
    /// <summary>
    /// The exception that is thrown when SSH exception occurs.
    /// </summary>
#if !NETSTANDARD1_3
    [Serializable]
#endif // !NETSTANDARD1_3
    public class SshException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SshException"/> class.
        /// </summary>
        public SshException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SshException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public SshException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SshException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public SshException(string message, Exception inner)
            : base(message, inner)
        {
        }

#if !NETSTANDARD1_3
        /// <summary>
        /// Initializes a new instance of the <see cref="SshException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="info"/> parameter is <c>null</c>.</exception>
        /// <exception cref="SerializationException">The class name is <c>null</c> or <see cref="Exception.HResult"/> is zero (0). </exception>
        protected SshException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif // !NETSTANDARD1_3
    }
}
