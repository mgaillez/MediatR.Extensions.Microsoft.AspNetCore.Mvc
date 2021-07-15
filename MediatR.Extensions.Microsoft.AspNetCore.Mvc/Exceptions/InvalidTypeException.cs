using System;

namespace MediatR.Extensions.Microsoft.AspNetCore.Mvc.Exceptions
{
    /// <summary>
    /// 
    /// </summary>
    public class InvalidTypeException : Exception
    {
        private readonly Type requiredType;
        private readonly Type providedType;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requiredType"></param>
        /// <param name="providedType"></param>
        public InvalidTypeException(Type requiredType, Type providedType) : base()
        {
            this.requiredType = requiredType;
            this.providedType = providedType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="requiredType"></param>
        /// <param name="providedType"></param>
        public InvalidTypeException(string message, Type requiredType, Type providedType) : base(message)
        {
            this.requiredType = requiredType;
            this.providedType = providedType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        /// <param name="requiredType"></param>
        /// <param name="providedType"></param>
        public InvalidTypeException(string message, Exception inner, Type requiredType, Type providedType) : base(message, inner)
        {
            this.requiredType = requiredType;
            this.providedType = providedType;
        }

        /// <summary>
        /// 
        /// </summary>
        public override string Message => $"{base.Message}{Environment.NewLine}Provided Type: {providedType.FullName}. Required type: {requiredType.FullName}";
    }
}
