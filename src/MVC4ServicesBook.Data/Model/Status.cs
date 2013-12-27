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
    public class Status
    {
        public virtual long StatusId { get; set; }
        public virtual string Name { get; set; }
        public virtual int Ordinal { get; set; }
        /// <summary>
        /// this will be used by NHibernate to detecte dirty data. This will map to a type of rowversion.
        /// </summary>
        public virtual byte[] Version { get; set; }
    }
}
