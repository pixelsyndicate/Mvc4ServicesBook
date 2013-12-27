using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC4ServicesBook.Data.Model
{
    /// <summary>
    /// Making virtuals so NHibernate can do lazy loading
    /// </summary>
    public class User
    {
        public virtual Guid UserId { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        /// <summary>
        /// this will be used by NHibernate to detecte dirty data. This will map to a type of rowversion.
        /// </summary>
        public virtual byte[] Version { get; set; }

    }
}
