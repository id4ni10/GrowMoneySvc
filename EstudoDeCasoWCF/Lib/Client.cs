using System;
using System.Runtime.Serialization;

namespace Lib
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public String Name
        {
            get;
            set;
        }

        [DataMember]
        public DateTime BornDate
        {
            get;
            set;
        }

        [DataMember]
        public Int32 AccountID
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

    }
}
