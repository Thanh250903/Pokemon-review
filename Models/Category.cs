﻿namespace Pokemon_review.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Pokemon> Pokemons { get; set; }

    }
}
