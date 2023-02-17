﻿namespace Technocite.Auchan.Superette.Site.ViewModels
{
    public class Supplier
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string Country { get; set; }
        public int EcoScore { get; set; }


        public IEnumerable<Article> Articles { get; set; }
    }
}
