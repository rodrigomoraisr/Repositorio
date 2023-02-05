using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entitities
{
    public class Base : Notifies
    {
        [Display(Name = "Código")]
        public int id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
