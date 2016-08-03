using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebSGAACF.Model
{
    public partial class ACF_Centro
    {
        [Key]
        public string Id_Centro { get; set; }

        [Required()]
        public string Nombre { get; set; }

        public string UsuarioRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public bool FlagAnulado { get; set; }

        public string Cod_Sociedad { get; set; }

        public string Cod_Centro { get; set; }
    }
}
