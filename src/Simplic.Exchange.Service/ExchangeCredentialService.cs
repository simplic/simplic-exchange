using System.Collections.Generic;

namespace Simplic.Exchange
{
    /// <summary>
    /// Credential service
    /// </summary>
    public class ExchangeCredentialService : IExchangeCredentialService
    {
        private readonly IExchangeCredentiaRepository exchangeObjectRepository;

        /// <summary>
        /// Initialize credential service
        /// </summary>
        /// <param name="exchangeObjectRepository"></param>
        public ExchangeCredentialService(IExchangeCredentiaRepository exchangeObjectRepository)
        {
            this.exchangeObjectRepository = exchangeObjectRepository;
        }

        /// <summary>
        /// Delete object instance
        /// </summary>
        /// <param name="obj">Object instance</param>
        /// <returns>True if successfull</returns>
        public bool Delete(ExchangeCredential obj) => exchangeObjectRepository.Delete(obj);

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
        public ExchangeCredential Get(long id) => exchangeObjectRepository.Get(id);

        /// <summary>
        /// Get all objects
        /// </summary>
        /// <returns>Enumerable of objects</returns>
        public IEnumerable<ExchangeCredential> GetAll() => exchangeObjectRepository.GetAll();

        /// <summary>
        /// Save object
        /// </summary>
        /// <param name="obj">Object instance</param>
        /// <returns>True if successfull</returns>
        public bool Save(ExchangeCredential obj) => exchangeObjectRepository.Save(obj);
    }
}
