using Dapper.Contrib.Extensions;
using System;

namespace Entities
{
    [Table("Area")]
    public class AreaEntity
    {
        [ExplicitKey]
        public Guid IdCuenta { get; set; } = Guid.Empty;
        [ExplicitKey]
        public int IdArea { get; set; } = 0;
        public string CreadoPor { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; } = DateTime.MinValue;
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public bool Activo { get; set; } = false;
    }
}