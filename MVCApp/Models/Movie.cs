using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models
{
    public class Movie
    {
        
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

    }
}