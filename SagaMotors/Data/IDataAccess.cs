using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorSagaMotors.Data
{
	public interface IDataAccess
	{
		Task<List<D>> Data_Load<D, P>(string sql, P parameters, string connectionString);
		Task Data_Save<P>(string sql, P parameters, string connectionString);
	}
}