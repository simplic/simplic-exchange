namespace Simplic.Exchange
{
    /// <summary>
    /// Possible states of an exchange object
    /// </summary>
    public enum ObjectStatus
    {
        /// <summary>
        /// The current object is not inserted in the exchange server
        /// </summary>
        NotInserted = 0,

        /// <summary>
        /// The object is successfully inserted in the exchange server
        /// </summary>
        Inserted = 1,

        /// <summary>
        /// Insertion into the exchange server has failed
        /// </summary>
        InsertFailed = 5,

        /// <summary>
        /// The object has to be udpated
        /// </summary>
        BeforeUpdate = 10,

        /// <summary>
        /// Updating the current object failed
        /// </summary>
        UpdateFailed = 15,

        /// <summary>
        /// The current object has to be deleted
        /// </summary>
        BeforeDelete = 20,

        /// <summary>
        /// The object has be deleted successfully
        /// </summary>
        DeleteFailed = 25
    }
}
