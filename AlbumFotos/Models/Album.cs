using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumFotos.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        [Required(ErrorMessage="Campo obrigátorio")]
        [StringLength(50, ErrorMessage ="Use menos caracteres")]
        public string Destino { get; set; }

        [Required(ErrorMessage = "Campo obrigátorio")]
        public string FotoTopo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Campo obrigátorio")]
        public DateTime Inicio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Campo obrigátorio")]
        public DateTime Fim { get; set; }

        public ICollection<Imagem> Imagens { get; set; }

    }
}
