using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodingCodingTest.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateUpdated { get; set; }
    }
}