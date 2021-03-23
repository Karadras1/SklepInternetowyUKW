﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sklep
{
    public class Category
    {

        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Wprowadź nazwe kategorii")]
        [StringLength(50)]

        public string Name { get; set; }


        public string Desc { get; set; }


        public ICollection<Film> Films { get; set; }



    }
}