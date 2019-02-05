using Simplic.Cache;
using Simplic.Data.Sql;
using Simplic.Sql;
using System;

namespace Simplic.Exchange
{
    /// <summary>
    /// Credential repository
    /// </summary>
    public class ExchangeCredentialRepository : SqlRepositoryBase<long, ExchangeCredential>, IExchangeCredentiaRepository
    {
        /// <summary>
        /// Initialize repository
        /// </summary>
        /// <param name="sqlService"></param>
        /// <param name="sqlColumnService"></param>
        /// <param name="cacheService"></param>
        public ExchangeCredentialRepository(ISqlService sqlService, ISqlColumnService sqlColumnService, ICacheService cacheService) : base(sqlService, sqlColumnService, cacheService)
        {
        }

        /// <summary>
        /// Gets the object id
        /// </summary>
        /// <param name="obj">Object instance</param>
        /// <returns>Id</returns>
        public override long GetId(ExchangeCredential obj) => obj.Ident;

        /// <summary>
        /// Gets the primary key column name
        /// </summary>
        public override string PrimaryKeyColumn => "Ident";

        /// <summary>
        /// Gets the table name
        /// </summary>
        public override string TableName => "AS_Objects";
    }
}
