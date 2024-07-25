using System.Data;

namespace MyHebrewBible.Database;

public interface IDbConnectionFactory
{
	public Task<IDbConnection> CreateConnectionAsync();
}
