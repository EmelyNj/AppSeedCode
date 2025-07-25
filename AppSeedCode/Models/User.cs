using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppSeedCode.Models;

public partial class User
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El dato es requerido.")] //DATOS OBLIGATORIOS
    [Display(Name = "Nombre del Usuario")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "El dato es requerido.")] 
    [EmailAddress(ErrorMessage = "El correo electrónico no tiene formato valido.")] //VALIDAR COMO EMAIL
    [Display(Name = "Correo electrónico")]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)] //VALIDAR / HACERLA DE TIPO PASSWORD
    [Display(Name = "Contraseña")]
    [Required(ErrorMessage = "El dato es requerido.")]
    public string Passwordd { get; set; } = null!;

    [Display(Name = "Rol")]
    public int? RoleId { get; set; }

    public virtual Role? Roles { get; set; } = null!;
}
