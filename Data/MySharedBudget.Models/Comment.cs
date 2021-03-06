﻿namespace MySharedBudget.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        public Comment()
        {
            this.CreatedOn = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(360)]
        [MinLength(3)]
        public string CommentText { get; set; }

        public DateTime CreatedOn { get; private set; }

        public int FundingCampaignId { get; set; }

        public virtual FundingCampaign FundingCampaign { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
