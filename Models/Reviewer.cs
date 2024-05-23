﻿namespace Pokemon_review.Models
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Reviewer> Reviewers { get; set; }
    }
}
