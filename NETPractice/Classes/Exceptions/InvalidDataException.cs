using System;

namespace NETPractice.Classes.Exceptions {

    public class InvalidDataException : Exception{

        public InvalidDataException() : base("invalid data given") { }

        public InvalidDataException(string message) : base(message) { }

    }

}