using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class BoardGame
    {
        [Key]
        public int ID { get; set; } 
        public string Name { get; set; }  
        public string Company {  get; set; }
        public int Players { get; set; }  
        public string Image {  get; set; }  
    }

}
