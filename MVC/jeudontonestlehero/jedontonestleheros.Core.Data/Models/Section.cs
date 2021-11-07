using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jeudontonestleheros.Core.Data.Models {

    [Table("Section")]
    public class Section {

        [Key]
        public int Id { get; set; }

        [Range(1, 9999999)]
        public int Number { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Titre requis")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Description requise")]
        public string Description { get; set; }

        public bool IsInit { get; set; }

        public Question MyQuestion { get; set; }

        public IEnumerable<Response> Responses { get; set; }
    }
}