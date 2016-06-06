using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Model
{
    public abstract class Entity :IEntity
    {
        
        public virtual Guid Id { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }
    }

    public interface IEntity
    {
        Guid Id { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedOn { get; set; }

        string UpdatedBy { get; set; }

        DateTime UpdatedOn { get; set; }
    }
}
