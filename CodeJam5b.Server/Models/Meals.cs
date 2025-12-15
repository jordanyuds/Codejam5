/*
Well defined Meal model with appropriate data annotations.
Good use of Entity Framework Core attributes for table and column mapping.
*/

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeJam5b.Models
{
    [Table("meals")]
    public class Meal
    {
        [Key]
        [Column("meal_id")]
        public required string MealId { get; set; }

        [Column("name")]
        public string MealName { get; set; }

        [Column("calories")]
        public int Calories { get; set; }

        [Column("carbs")]
        public int Carbs { get; set; }

        [Column("fat")]
        public int Fat { get; set; }

        [Column("protein")]
        public int Protein { get; set; }

    }
}
