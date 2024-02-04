using IdenityValidateService;
using IdentityValidateSmulation.Abstract;
using IdentityValidateSmulation.Entities;

namespace IdentityValidateSmulation.Managers
{
    internal class CitizenManager : ICitizenService
    {
        private readonly KPSPublicSoapClient _client;
        public CitizenManager(KPSPublicSoapClient client)
        {
            _client = client;
        }

        public void Validate(Citizen citizen)
        {
            try
            {
                Task<TCKimlikNoDogrulaResponse> response = _client.TCKimlikNoDogrulaAsync(citizen.IdentityNumber, citizen.Name, citizen.Surname, citizen.BirthYear);
                var result = response.Result.Body.TCKimlikNoDogrulaResult;
                Console.WriteLine(result
                    ? "\nGirlen kod dogrulandı."
                    : "\nGirilen bilgiler doruğrulanamadı.");


            }
            catch (Exception)
            {

                Console.WriteLine("Sistemde bir sorun oluştu.");
            }
        }
    }
}
