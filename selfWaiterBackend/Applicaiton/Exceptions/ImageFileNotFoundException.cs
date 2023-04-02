using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Exceptions
{
    public class ImageFileNotFoundException: Exception
    {
        public static string Message { get; } = "İlgili fotoğraf dosyası bulunamadı !";
        public ImageFileNotFoundException(): base(Message)
        {

        }

        public ImageFileNotFoundException(string? message) : base(message)
        {
        }

        public ImageFileNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
