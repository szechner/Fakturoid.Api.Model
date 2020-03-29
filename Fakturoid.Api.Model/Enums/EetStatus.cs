using System.Runtime.Serialization;

namespace Fakturoid.Api.Model.Enums
{
    /// <summary>
    /// Stav zaevidování EET
    /// </summary>
    public enum EetStatus
    {
        /// <summary>
        /// Čeká se na první odpověď serveru EET
        /// </summary>
        [EnumMember(Value = "waiting")]
        Waiting = 0,

        /// <summary>
        /// Na faktuře se zobrazí PKP kód
        /// </summary>
        [EnumMember(Value = "pkp")]
        Pkp = 1,

        /// <summary>
        /// Na faktuře se zobrazí FIK kód
        /// </summary>
        [EnumMember(Value = "fik")]
        Fik = 2
    }
}
