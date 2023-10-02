using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class ClienteTelefono
{

    [Required]
    public int IdCliente { get; set; }

    [Required]
    public string Numero { get; set; }
}