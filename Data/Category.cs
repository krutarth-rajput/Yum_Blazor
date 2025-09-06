using System.ComponentModel.DataAnnotations;

namespace YumBlazor.Data
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="The name is a required field.")]
        public string Name { get; set; }
    }
}
