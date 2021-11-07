using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jeudontonestleheros.Core.Data.Models {

    [Table("Adventure")]
    public class Adventure {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre est requis")]
        public string Title { get; set; }
    }
}