using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Exceptions
{
    public class TranslationAlreadyExist: Exception
    {
        public static string Message { get; } = "İlgili dil zaten var ! Güncellemeyi deneyiniz.";
        public TranslationAlreadyExist(): base(Message) 
        {

        }

        public TranslationAlreadyExist(string? message) : base(message)
        {
        }

        public TranslationAlreadyExist(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
