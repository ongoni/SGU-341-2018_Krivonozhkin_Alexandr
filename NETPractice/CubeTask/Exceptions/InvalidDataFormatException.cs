using System;

namespace NETPractice.CubeTask.Exceptions {

    public class InvalidDataFormatException: Exception {

        public InvalidDataFormatException(string message) : base(message) { }
        
    }

}
