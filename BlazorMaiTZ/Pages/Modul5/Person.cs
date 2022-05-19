using System.ComponentModel.DataAnnotations;

namespace BlazorMaiTZ.Pages.Modul5
{
    public class Person
    {
        [Required(ErrorMessage ="bitte ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "bitte Name")]
        [StringLength(10,ErrorMessage ="max 10")]
        public string Name { get; set; }
        [Required(ErrorMessage = "bitte Größe")]
        [Range(140,199,ErrorMessage ="keine Achterbahn")]
        public int Gross { get; set; }
        [Required(ErrorMessage = "bitte Gebdat")]
        public DateTime GebDat { get; set; }
    }
}
