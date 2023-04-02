using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Exceptions
{
    public class BasketNotFoundException : Exception
    {
        public static string Message { get; } = "İlgili Sepete Bulunamadı !";
        public BasketNotFoundException(): base(Message)
        {
        }

        public BasketNotFoundException(string? message) : base(message)
        {
        }

        public BasketNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
