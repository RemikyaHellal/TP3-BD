﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP3_ORM.Entities
{
    public class Groupe : Entity
    {
        [Key]
        public string NOM_GROUPE { get; set; }
        [Required]
        public float CACHET_SOUHAITE { get; set; }

        public ICollection<Role> ROLES { get; set; }
        public ICollection<Contrat> CONTRATS { get; set; }
    }
}
