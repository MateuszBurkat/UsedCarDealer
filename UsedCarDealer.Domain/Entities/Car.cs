using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace UsedCarDealer.Domain.Entities
{
    public class Car
    {
        [HiddenInput(DisplayValue=false)]
        public int CarID { get; set; }


        [Required(ErrorMessage ="Proszę podać markę samochodu")]
        [Display(Name="Marka")]
        public string CarBrand { get; set; }


        [Required(ErrorMessage = "Proszę podać model samochodu")]
        [Display(Name = "Model")]
        public string CarModel { get; set; }


        [Required(ErrorMessage = "Proszę podać rodzaj paliwa")]
        [Display(Name = "Rodzaj paliwa")]
        public string FuelType { get; set; }


        [Required(ErrorMessage = "Proszę podać rok produkcji")]
        [Display(Name = "Rok produkcji")]
        public int YearProduction { get; set; }


        [Required(ErrorMessage = "Proszę podać typ nadwozia")]
        [Display(Name = "Typ nadwozia")]
        public string TypeCar { get; set; }



        [Required(ErrorMessage = "Proszę podać przebieg w kilometrach")]
        [Display(Name = "Przebieg w km")]
        public int Milage { get; set; }



        [Required(ErrorMessage = "Proszę podać cenę")]
        [Display(Name = "Cena")]
        public int Price { get; set; }

        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }

    }
    
}
