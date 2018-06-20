using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Contracts.Entities
{
    public class BaseEntity
    {
        protected BaseEntity()
        { }

        public string CreatedBy { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDateUtc { get; set; }
        public bool IsDeleted { get; set; }
    }
}
