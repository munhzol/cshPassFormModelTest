using System.ComponentModel.DataAnnotations;

namespace MvcSurvey.Models {
    public class Survey {

        [Required]
        [MinLength(2,ErrorMessage="Min char 2")]
        public string Name {get;set;}
        [Required]
        public string Location {get;set;}
        [Required]
        public string Language {get;set;}
        [MaxLength(20)]
        public string Comment {get;set;}

    }
}