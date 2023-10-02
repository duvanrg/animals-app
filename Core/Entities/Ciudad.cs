using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Ciudad : BaseEntity
{
    public string NombreCiudad { get; set; }
    public int IdDepartamento { get; set; }
    public Departamento Departamento { get; set; }
    public ICollection<ClienteDireccion> ClienteDirecciones { get; set; }
    
    
    
}
