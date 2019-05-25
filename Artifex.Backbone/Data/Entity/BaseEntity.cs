using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.Data.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int MerchantId { get; set; }
    }
}
