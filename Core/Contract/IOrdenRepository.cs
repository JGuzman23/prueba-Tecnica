using Ordenes.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ordenes.Core.Contract
{
    public interface IOrdenRepository
    {
        Task<List<OrdenesViewModel>> GetProductos();
        Task<List<OrdenesViewModel>> GetOrdenes(string email);
        Task<OrdenesViewModel> Detalles(int? id);
    }
}
