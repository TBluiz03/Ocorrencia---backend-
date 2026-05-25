using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SOSBackClean.Application.DTOs
{
    public record ResolveFormularioDTO
    {
        [Required]
        [Range(1, 9999)]
        public int Id {  get; set; }

        [Required]
        [MinLength(15)]
        [MaxLength(300)]
        [JsonPropertyName("Feedback")]
        public string Feedback { get; set; }
    }
}
