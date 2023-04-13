using System.ComponentModel.DataAnnotations;

namespace JwtApp.Front.Models
{
    public class CategoryCreateModel
    {
        [Required(ErrorMessage ="Bu alan zorunludur.")]
        public string Definition { get; set; } = null!;
    }
}
