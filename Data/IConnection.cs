using Microsoft.Data.SqlClient;

namespace BASEBALLBIBICOWEB.Data
{
    public interface IConnection
    {
        SqlConnection GetConnection();
    }
}
