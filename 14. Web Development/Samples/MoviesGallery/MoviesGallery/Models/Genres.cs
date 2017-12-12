using System;

namespace MoviesGallery.Models
{
    [Flags]
    public enum Genre
    {
        Drama = 1,
        Mystery = 2,
        Thriller = 4,
        Crime = 8
    }
}
