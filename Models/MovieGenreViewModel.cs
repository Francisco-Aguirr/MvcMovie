using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public SelectList? ReleaseYears { get; set; } // Para mostrar los años en un dropdown
    public int? SelectedReleaseYear { get; set; } // Año seleccionado
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}