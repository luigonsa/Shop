

namespace Shop.Web.data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {

        public int Id { get; set; }

        public string Name { get; set; }

        /* formato de moneda C2 sig. 2 decimales*/
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        /* Atributo para formatear las palabras*/
        [Display(Name = "Last Purchase")]
        public DateTime LastPurchase { get; set; }

        [Display(Name = "Last Sale")]
        public DateTime LastSale { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }

        /* formato de moneda N2 sig. 2 decimales sin el signo*/
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

    }
}
