using System.Globalization;

namespace IdentityValidateSmulation.Entities
{
    internal class Citizen
    {
        private string _name;
        private string _surmane;
        public long IdentityNumber { get; set; }

        public string Name
        {
            get => _name.ToUpper(CultureInfo.InvariantCulture);

            set => _name = value;

        }
        public string Surname
        {
            get => _surmane.ToUpper(CultureInfo.InvariantCulture);
            set => _surmane = value;
        }
        public int BirthYear { get; set; }
    }
}
