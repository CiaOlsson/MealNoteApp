using MatLogg.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatLogg.Application.Interfaces
{
    public interface ISaveFoodService
    {
        void SaveFood(SaveFoodDTO saveFoodDTO);
    }
}
