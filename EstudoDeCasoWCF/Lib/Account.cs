using System;
using System.Runtime.Serialization;

namespace Lib
{
    [DataContract]
    public class Account
    {
        [DataMember]
        public Double Balance
        {
            get;
            set;
        }

        [DataMember]
        public String Code
        {
            get;
            set;
        }

        [DataMember]
        public Int32 ID
        {
            get;
            set;
        }

        [DataMember]
        public Int32 AgencyID
        {
            get;
            set;
        }
    }
}
