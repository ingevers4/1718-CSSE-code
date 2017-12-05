using System;

namespace week08 {
    public class CustomException : Exception 
    {
        public CustomException(string message) : base(message)
        {
            
        }

        public CustomException(string message, Exception innerException) : base(message, innerException) 
        {

        }
    }
}
