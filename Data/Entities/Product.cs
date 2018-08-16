using Data.Enums;
using Data.Interfaces;
using Infrastructure.SharedKernel;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("Products")]
    public class Product : DomainEntity<int>, ISwitchable, IDateTracking, IHasSeoMetaData
    {
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public string Image { get; set; }

        [Required]
        [DefaultValue(0)]
        public string Price { get; set; }

        public string PromotionPrice { get; set; }

        [Required]
        public string OriginalPrice { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public string Content { get; set; }
        public bool HomeFlag { get; set; }
        public bool HotFloag { get; set; }
        public int? ViewCount { get; set; }

        [StringLength(255)]
        public string Tags { get; set; }

        public string Unit { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }

        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string SepPageTitle { get; set; }

        [StringLength(255)]
        public string SeoAlias { get; set; }

        [StringLength(255)]
        public string SeoKeywords { get; set; }

        [StringLength(255)]
        public string SeoDescription { get; set; }
    }
}