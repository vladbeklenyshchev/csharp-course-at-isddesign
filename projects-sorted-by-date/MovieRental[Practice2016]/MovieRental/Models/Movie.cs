﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class Movie : BaseEntity
    {
        #region Properties

        public String Name { get; set; }

        #endregion
        #region Methods

        public Movie()
        {

        }

        #endregion
    }
}