using System;
 
namespace backend.Models.Request
{
    public class ListaNegraRequest
    { 
            public string nome { get;set; }
            
            public string motivo { get;set;}
            
            public DateTime inclusao { get;set;}
    }
}