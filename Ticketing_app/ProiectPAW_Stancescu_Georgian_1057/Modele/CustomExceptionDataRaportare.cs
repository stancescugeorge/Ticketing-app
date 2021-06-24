using System;
using System.Runtime.Serialization;

namespace ProiectPAW_Stancescu_Georgian_1057.Clase
{
    class CustomExceptionDataRaportare : Exception
    {
        public override string Message
        {
            get
            {
                return "Data raportarii este cel mult data curenta si cel putin o data de anul trecut!";
            }
        }
    }
}