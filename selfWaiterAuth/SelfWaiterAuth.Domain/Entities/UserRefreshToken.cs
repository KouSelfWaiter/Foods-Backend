using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfWaiterAuth.Domain.Entities
{
    public class UserRefreshToken
    {
        public string UserId { get; set; }
        public UserApp User { get; set; }
        public string Code { get; set; }
        public DateTime Expiration { get; set; }
    }
}
