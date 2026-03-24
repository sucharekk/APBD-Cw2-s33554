using System;

namespace APBD_Cw2_s33554.Errors;

public class UnkownTypeException: Exception

{
    public UnkownTypeException(string type) :  base( "Unkown "+type+ " type" )
    {
    }
}