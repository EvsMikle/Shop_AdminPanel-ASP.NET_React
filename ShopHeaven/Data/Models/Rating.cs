﻿using System.ComponentModel.DataAnnotations;

namespace ShopHeaven.Data.Models
{
    public class Rating : GuidModel, IBaseModel
    {
        [Required]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Required]
        public int Value { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}