using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dairy.Models
{
    public class Day
    {
        [Key]
        public int Id { get; set; } 
        public int IdWeather { get; set; }
        [ForeignKey("IdWeather")]
        public Weather weather { get; set; }
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public User user { get; set; }
        public int idSocial { get; set; }
        [ForeignKey("idSocial")]
        public Social social { get; set; }
        public int idMood { get; set; }
        [ForeignKey("idMood")]
        public Mood mood { get; set; }
        public int idEmotions { get; set; }
        [ForeignKey("idEmotions")]
        public Emotions emotions { get; set; }
        public int idHobbies { get; set; }
        [ForeignKey("idHobbies")]
        public Hobbies hobbies { get; set; }
        public DateTime? sleep { get; set; }
        [Column(TypeName = "text")]
        public string? note { get; set; } 
    }
}
