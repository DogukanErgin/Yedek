using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_APP.Models.entities
{
    public class BaseEntityId
    {

        [Dapper.Contrib.Extensions.Key]
        public int Id { get; set; }


    }
}
