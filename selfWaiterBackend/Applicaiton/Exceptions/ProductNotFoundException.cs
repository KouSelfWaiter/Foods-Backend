using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Exceptions
{
    public class ProductNotFoundException: Exception
    {
        public static string Message { get; } = "İlgili ürün bulunamadı !";
        public ProductNotFoundException(): base(Message) 
        {

        }

        public ProductNotFoundException(string? message) : base(message)
        {
        }

        public ProductNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
