using GEBRequestSystem4.Shared;
using System.Net.Http.Json;

namespace GEBRequestSystem4.Client.Services.BussinesAreaServices
{
    public class BussinesAreaService : IBussinesAreaService
    {
        private readonly HttpClient _http;

        public BussinesAreaService(HttpClient http)
        {
            _http = http;
        }

        public List<BussinesArea> BussinesAreas { get; set; } = new List<BussinesArea>();
        public List<BussinesDirection> BussinesDirections { get; set; } = new List<BussinesDirection>();

        public async Task GetBussinesAreas()
        {
            var result = await _http.GetFromJsonAsync<List<BussinesArea>>("api/bussinesarea");
            if (result != null)
            {
                BussinesAreas = result;
            }
        }

        public async Task GetBussinesDirections()
        {
            var result = await _http.GetFromJsonAsync<List<BussinesDirection>>("api/bussinesarea/bussinesDirections");
            if (result != null)
            {
                BussinesDirections = result;
            }
        }

        public async Task<BussinesArea> GetSingleArea(int IdBussinesArea)
        {
            var result = await _http.GetFromJsonAsync<BussinesArea >($"api/bussinesarea/{IdBussinesArea}");
            if (result != null)
                return result;
            throw new Exception("Area no encontrada !!");
        }
    }
}
