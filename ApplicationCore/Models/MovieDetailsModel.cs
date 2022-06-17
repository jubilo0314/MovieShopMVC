﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{   
    public class MovieDetailsModel
    {   
        //many properites
        public int Id { get; set; }
        public string Title { get; set; }
        public string PosterUrl { get; set; }
        public int Runtime { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}