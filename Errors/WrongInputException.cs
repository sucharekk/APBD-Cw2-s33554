using System;

namespace APBD_Cw2_s33554.Errors;

public class WrongInputException : Exception
{
    public WrongInputException( ) : base( "Wrong input")
    {
    }
    
    public WrongInputException( string message ) : base( message )
    {}
    
}