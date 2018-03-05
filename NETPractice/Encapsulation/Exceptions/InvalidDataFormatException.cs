using System;

namespace NETPractice.Encapsulation.Exceptions {

    public class InvalidDataFormatException: Exception {

        public InvalidDataFormatException(string message) : base(message) { }
        
    }

}
