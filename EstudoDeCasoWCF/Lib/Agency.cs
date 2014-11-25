using System;
using System.Runtime.Serialization;

namespace Lib
{
    [DataContract]
    public class Agency
    {
        [DataMember]
        public String Adress
        {
            get;
            set;
        }

        [DataMember]
        public Int32 Code
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
