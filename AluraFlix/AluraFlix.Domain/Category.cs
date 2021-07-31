using AluraFlix.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraFlix.Domain
{
    public class Category
        : EntityBase
    {

        [Required(ErrorMessage = "O campo é obrigatório", AllowEmptyStrings = false)]
        public string Title { get; set; }
        public string Color { get; set; }

    }
}
