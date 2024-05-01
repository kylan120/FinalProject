using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class BoardGame
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter a boardgame")]
        [StringLength(30)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a company")]
        [StringLength (30)]
        public string Company {  get; set; }
        [Range(1,8, ErrorMessage = "Please enter player count of 1-8")]
        public int Players { get; set; }
        
        public string Image {  get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }   
        
    }

}
