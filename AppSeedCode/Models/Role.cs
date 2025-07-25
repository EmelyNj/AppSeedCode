using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppSeedCode.Models;

public partial class Role
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El dato es requerido.")]
    [Display(Name = "Nombre del Rol")]
    public string Name { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
