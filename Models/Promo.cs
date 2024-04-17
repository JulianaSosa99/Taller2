namespace Practica_Kami_Sosa.Models
{
    public class Promo
    {
        public int PromoID { get; set; }

        public string? Descripcion { get; set; }
        public DateTime FechaPromo { get; set; }
        
        //Declaracion de clave foranea
        public int BurgerID { get; set; }
        //Definimos la primera propiedad
        //Model Validation sabe si el objeto se esta creando o no
        public Burger? Burger { get; set; }


    }
}
