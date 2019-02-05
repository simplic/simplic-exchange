using System.Collections.Generic;

namespace Simplic.Exchange
{
    /// <summary>
    /// Object service
    /// </summary>
    public class ExchangeObjectService : IExchangeObjectService
    {
        private readonly IExchangeObjectRepository exchangeObjectRepository;

        /// <summary>
        /// Initialize object service
        /// </summary>
        /// <param name="exchangeObjectRepository"></param>
        public ExchangeObjectService(IExchangeObjectRepository exchangeObjectRepository)
        {
            this.exchangeObjectRepository = exchangeObjectRepository;
        }

        /// <summary>
        /// Delete object instance
        /// </summary>
        /// <param name="obj">Object instance</param>
        /// <returns>True if successfull</returns>
        public bool Delete(ExchangeObject obj) => exchangeObjectRepository.Delete(obj);

        /// <summary>
        /// Delete object by id
        /// </summary>
        /// <param name="id">Unique id</param>
        /// <returns>True if successfull</returns>
        public bool Delete(long id) => exchangeObjectRepository.Delete(id);

        /// <summary>
        /// Get object by id
        /// </summary>
        /// <param name="id">Unique id</param>
        /// <returns>Object instance</returns>
        public ExchangeObject Get(long id) => exchangeObjectRepository.Get(id);

        /// <summary>
        /// Get all objects
        /// </summary>
        /// <returns>Enumerable of objects</returns>
        public IEnumerable<ExchangeObject> GetAll() => exchangeObjectRepository.GetAll();

        /// <summary>
        /// Save object
        /// </summary>
        /// <param name="obj">Object instance</param>
        /// <returns>True if successfull</returns>
        public bool Save(ExchangeObject obj) => exchangeObjectRepository.Save(obj);
    }
}
