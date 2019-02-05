using Simplic.Cache;
using Simplic.Data.Sql;
using Simplic.Sql;
using System;

namespace Simplic.Exchange.Data.DB
{
    /// <summary>
    /// Object repository
    /// </summary>
    public class ExchangeObjectRepository : SqlRepositoryBase<long, ExchangeObject>, IExchangeObjectRepository
    {
        /// <summary>
        /// Initialize repository
        /// </summary>
        /// <param name="sqlService"></param>
        /// <param name="sqlColumnService"></param>
        /// <param name="cacheService"></param>
        public ExchangeObjectRepository(ISqlService sqlService, ISqlColumnService sqlColumnService, ICacheService cacheService) : base(sqlService, sqlColumnService, cacheService)
        {
        }

        /// <summary>
        /// Gets the object id
        /// </summary>
        /// <param name="obj">Object instance</param>
        /// <returns>Id</returns>
        public override long GetId(ExchangeObject obj) => obj.Ident;

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
