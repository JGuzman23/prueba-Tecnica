using BASEBALLBIBICOWEB.Data;
using Dapper;
using Microsoft.Extensions.Configuration;
using Ordenes.Core.Contract;
using Ordenes.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordenes.Core.Repository
{
    public class OrdenRepository: IOrdenRepository
    {
        private readonly IConnection _connection;
        readonly IConfiguration _configuration;

        public OrdenRepository(IConnection connection, IConfiguration configuration)
        {
            _connection = connection;
            _configuration = configuration;
        }

        public async Task<List<OrdenesViewModel>> GetProductos()
        {



            using (var conn = _connection.GetConnection())
            {


                var query = $"  select Nombre,Categoria,Stock from  Productos ";
                var reades = await conn.QueryAsync<OrdenesViewModel>(
                    sql: query,
                    commandType: System.Data.CommandType.Text
                    );


                return reades.ToList();
            }
        }
        public async Task<List<OrdenesViewModel>> GetOrdenes(string email)
        {


       
            using (var conn = _connection.GetConnection())
            {
                

                var query = $"  select p.Nombre,p.Categoria,p.Stock,o.Fecha,o.Id from Ordenes as o inner join Productos as p on o.IdProductosId = p.Id inner join AspNetUsers as u on o.idClientes = u.Id where u.Email ='{email}'";
                var reades = await conn.QueryAsync<OrdenesViewModel>(
                    sql: query,
                    commandType: System.Data.CommandType.Text
                    );


                return reades.ToList();
            }
        }
        public async Task<OrdenesViewModel> Detalles(int? id)
        {



            using (var conn = _connection.GetConnection())
            {


                var query = $"  select p.Nombre,p.Categoria,p.Stock,o.Fecha,o.Id from Ordenes as o inner join Productos as p on o.IdProductosId = p.Id where o.Id={id}";
                var reades = await conn.QueryFirstOrDefaultAsync<OrdenesViewModel>(
                    sql: query,
                    commandType: System.Data.CommandType.Text
                    );


                return reades;
            }
        }

    }
}
