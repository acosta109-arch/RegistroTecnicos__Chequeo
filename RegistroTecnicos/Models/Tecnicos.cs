using System.ComponentModel.DataAnnotations;

namespace RegistroTecnicos.Models;

public class Tecnicos
{
    [Key]
    public int TecnicosId { get; set; }

    [Required(ErrorMessage = "Favor de ingresar el nombre del tecnico.")]
    public string Nombres { get; set; }
    [Required(ErrorMessage = "Favor de ingresar el sueldo por hora del tecnico.")]
    public decimal SueldoHora { get; set; }
}
