using ApiProject01.Models;
using ApiProject01.Models.Dto;

namespace ApiProject01.Datos
{
    static public class Tienda
    {
        public static List<DepartamentoDto> DtoDepartamentos { get; set; }
        static Tienda()
        {
            DtoDepartamentos = new List<DepartamentoDto> {
                new DepartamentoDto { Id = 1, Nombre = "Primer dep" },
                new DepartamentoDto { Id = 2, Nombre = "Segundo dep" }
            };
        }

        internal static DepartamentoDto? GetDtoDepartamentos(int id)
        {
            foreach(var dto in DtoDepartamentos)
            {
                if (dto.Id == id)
                {
                    return dto;
                }
            }
            return null;
        }
    }
}
