using System;

namespace NETPractice.Classes.Exceptions {

    public class InvalidDataFormatException: Exception {

        public InvalidDataFormatException() { }

        public InvalidDataFormatException(string message) : base(message) { }
        
    }

}
