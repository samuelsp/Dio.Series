using System.ComponentModel.DataAnnotations;

namespace Dio.Series.Models
{
    public abstract class Base    
    {
        [Key]
        public int Id { get; set; }
    }
}