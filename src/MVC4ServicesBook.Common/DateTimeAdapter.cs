using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC4ServicesBook.Common
{
    /// <summary>
    /// Calling a static class like DateTime.Now will get ugly in tests, where we would have to change the system date.
    /// So we are going to use the Adapter patter, wrap the DateTime class in an injectable interface.
    /// </summary>
    public interface IDateTime
    {
        DateTime UtcNow { get; }
    }

    public class DateTimeAdapter : IDateTime
    {
        public DateTime UtcNow
        {
            get { return DateTime.UtcNow; }
        }
    }
}

