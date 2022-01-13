using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekat.Models
{
    public class Company
    {
        public string name;
        public string picture;

        public Company(string name, string picture)
        {
            this.name = name;
            this.picture = picture;
        }
    }
}