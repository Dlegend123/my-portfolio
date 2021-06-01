﻿using System;
using System.Runtime.Serialization;

namespace GameWebAPI
{
    [Serializable]
    internal class TooLowLevelException : Exception
    {
        public TooLowLevelException()
        {

        }

        public TooLowLevelException(string message) : base(message)
        {
   
        }

        public TooLowLevelException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TooLowLevelException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}