﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Specify.Models
{
    public class Artist
    {      
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
}