using AluraFlix.Domain.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraFlix.Domain.Base
{
    public abstract class EntityBase
        : IEntity
    {

        [Key]
        public int Id { get; set; }
    }
}
