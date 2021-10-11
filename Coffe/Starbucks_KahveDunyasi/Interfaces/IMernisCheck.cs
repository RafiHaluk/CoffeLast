using System;
using System.Threading.Tasks;
using Starbucks_KahveDunyasi.Individuals;

namespace Starbucks_KahveDunyasi.Interfaces
{
    public interface IMernisCheck
    {
         bool CheckIfActualPerson(Customers customers);

    }
}