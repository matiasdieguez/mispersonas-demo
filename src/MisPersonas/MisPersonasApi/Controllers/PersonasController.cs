using ArgenSearch;
using System.Threading.Tasks;
using System.Web.Http;
using System.Net.Http;
using System.Net;

namespace MisPersonasApi.Controllers
{
    public class PersonasController : ApiController
    {
        [Route("api/search")]
        [HttpGet]
        public async Task<HttpResponseMessage> Search(int id)
        {
            var persona = await ArgenSearchClient.Search(id);

            var response = await ArgenSearchClient.Detail(persona.Data[0]);

            return Request.CreateResponse(HttpStatusCode.OK, new
            {
                Nombre = response.Data.Nombre,
                Direccion = response.Data.DomicilioFiscal.Direccion,
                Localidad = response.Data.DomicilioFiscal.Localidad
            });
        }
    }
}
