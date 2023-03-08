using GEBRequestSystem4.Shared;

namespace GEBRequestSystem4.Client.Services.BussinesAreaServices
{
    public interface IBussinesAreaService
    {
        List<BussinesArea> BussinesAreas { get; set; }
        List<BussinesDirection> BussinesDirections { get; set; }
        Task GetBussinesDirections();
        Task GetBussinesAreas();
        Task<BussinesArea> GetSingleArea(int IdBussinesArea);
    }
}
