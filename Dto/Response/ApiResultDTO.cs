using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploApiRest.Webapi.Config
{
    public class ApiResponseDTO
    {
        public object Data { get; set; }
        public bool FromCache { get; set; }
    }
}
