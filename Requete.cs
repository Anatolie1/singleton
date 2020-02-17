using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Requete1
    {
        private DatabaseSingleton database = DatabaseSingleton.GetInstance(); 
    }    
}
