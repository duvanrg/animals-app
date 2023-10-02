using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class Departamento : BaseEntity
{
    public string NombreDepartamento { get; set; }
    public int IdPais { get; set; }
    public Pais pais { get; set; }
    public ICollection<Ciudad> Ciudades  { get; set; }
    
}
