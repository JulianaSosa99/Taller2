using System.ComponentModel.DataAnnotations;

namespace Practica_Kami_Sosa.Models
{
    public class Burger 
    {
        //creacion clase burger
     public int BurgerID { get; set; }

        //Data annotation, nos ayudan a especificar validaciones adicionales a los datos 
     [Required]
     public string? Nombre { get; set; }
     public bool WithCheese{get; set; }

     [Range(0.01, 9999.99)]
     public decimal precio { get; set; }

    }
}
