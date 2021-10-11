
using NewTcService;
using Starbucks_KahveDunyasi.Individuals;
using Starbucks_KahveDunyasi.Interfaces;
using System.Threading.Tasks;
using static NewTcService.KPSPublicSoapClient;

namespace Starbucks_KahveDunyasi.MernisAdapter
{
    public class MernisServiceAdapter : IMernisCheck
    {
        public bool CheckIfActualPerson(Customers customers)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);

            var result = client.TCKimlikNoDogrulaAsync(customers.NationalityId, customers.FirstName.ToUpper(),
                customers.LastName.ToUpper(), customers.BirthData.Year).Result;

            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}