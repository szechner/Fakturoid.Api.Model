using System.Runtime.Serialization;

namespace Fakturoid.Api.Model.Enums
{
    public enum InvoiceState
    {
        [EnumMember(Value = "open")]
        Open = 0,

        [EnumMember(Value = "sent")]
        Sent = 1,

        [EnumMember(Value = "overdue")]
        Overdue = 2,

        [EnumMember(Value = "paid")]
        Paid = 3,

        [EnumMember(Value = "cancelled")]
        Cancelled = 4
    }
}
