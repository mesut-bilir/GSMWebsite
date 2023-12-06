using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Sk.Models
{
    public partial class SkModel : DbContext
    {
        public SkModel()
            : base("name=SkModel")
        {
        }

        public virtual DbSet<user> users { get; set; }

    }
}
