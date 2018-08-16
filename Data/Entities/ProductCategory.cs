using Data.Enums;
using Data.Interfaces;
using Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("CategoryProducts")]
    public class ProductCategory : DomainEntity<int>, IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }

        [StringLength(255)]
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
        public string SepPageTitle { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(255)]
        public string SeoAlias { get; set; }

        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public Status Status { get; set; }
        public int SortOrder { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}