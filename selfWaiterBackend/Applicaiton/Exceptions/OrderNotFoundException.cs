using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Exceptions
{
    public class OrderNotFoundException: Exception
    {
        public static string Message { get; } = "İlgili sipariş bulunamadı !";
        public OrderNotFoundException(): base(Message) 
        {

        }

        public OrderNotFoundException(string? message) : base(message)
        {
        }

        public OrderNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
