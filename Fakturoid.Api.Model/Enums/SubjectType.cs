using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Fakturoid.Api.Model.Enums
{
    /// <summary>
    /// Typ kontaktu
    /// </summary>
    public enum SubjectType
    {
        [EnumMember(Value = "customer")]
        Customer = 0,

        [EnumMember(Value = "supplier")]
        Supplier = 1,

        [EnumMember(Value = "both")]
        Both = 2
    }
}
