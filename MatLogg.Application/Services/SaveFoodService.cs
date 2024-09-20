using MatLogg.Application.DTOs;
using MatLogg.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatLogg.Application.Services
{
    public class SaveFoodService : ISaveFoodService
    {
        // lägg till databas context tillfälligt som ett fält. 
        public void SaveFood(SaveFoodDTO saveFoodDTO)
        {
            // Gör om så att allt i DTOn läggs till i SaveFood entiteten och lägg till dagens datum för det finns i entiteten men inte i dton. 
            // Senare kan jag göra Repos och gå via dessa också. Men testa utan först för att se så att jag får upp kopplingen till databasen. 


            _context.Add(SaveFood);
        }
    }
}
