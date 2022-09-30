using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;

namespace UniversidadBacked.Models.DataModels
{
    public class Course:BaseEntity
    {
        [Required, StringLength(50)]

        public String Name { get; set; }

        [StringLength(280)]

        public String ShortDescription { get; set; }
                
        [StringLength(666)]
        public String Description { get; set; }

        [StringLength(280)]

        public String Target { get; set; }


        [StringLength(280)]

        public String Goals { get; set; }

        public int Levels { get; set; }


    }

}
