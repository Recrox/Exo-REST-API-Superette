﻿namespace Providers.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string SupplierCode { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int EcoScore { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
