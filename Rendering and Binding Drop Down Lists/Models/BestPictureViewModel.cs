using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Rendering_and_Binding_Drop_Down_Lists.Models
{
    public class BestPictureViewModel
    {
         [DisplayName("TOP MOVIES")]
        [UIHint("List")]
        public IEnumerable<SelectListItem> Movies { get; private set; }

        [DisplayName("TOP SONGS")]
        [UIHint("List")]
        public IEnumerable<SelectListItem> TopSongs { get; private set; }

        public BestPictureViewModel()
        {
            //Fill the list will all the potential selections. 
            // This could be a call to a DB server instead...
            Movies = new[] {
                new SelectListItem() { Value = "1", Text = "Slumdog Millionaire" },
                new SelectListItem() { Value = "2", Text = "The Curious Case of Benjamin Button" },
                new SelectListItem() { Value = "3", Text = "Frost/Nixon" },
                new SelectListItem() { Value = "4", Text = "Milk" },
                new SelectListItem() { Value = "5", Text = "The Reader" },
            };


            //Fill the list will all the potential selections. 
            TopSongs = new[] {
                new SelectListItem() { Value = "1", Text = "UPTOWN FUNK --	MARK RONSON FT BRUNO MARS" },
                new SelectListItem() { Value = "2", Text = "CHEERLEADER -- (FELIX JAEHN REMIX)	OMI" },
                new SelectListItem() { Value = "3", Text = "TAKE ME TO CHURCH --  HOZIER" },
                new SelectListItem() { Value = "4", Text = "LOVE ME LIKE YOU DO	--  ELLIE GOULDING" },
                new SelectListItem() { Value = "5", Text = "SEE YOU AGAIN	--  WIZ KHALIFA FT CHARLIE PUTH" },
            };
        }
    }
}
