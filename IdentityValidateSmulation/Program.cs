﻿using IdenityValidateService;
using IdentityValidateSmulation.Entities;
using IdentityValidateSmulation.Managers;

namespace IdentityValidateSmulation
{

    class Program
    {
        static void Main(string[] args)
        {
            CitizenManager citizenManager = new CitizenManager(new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap));
            Citizen citizen = new Citizen();

            Console.Write("TC No: ");
            citizen.IdentityNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Ad: ");
            citizen.Name = Console.ReadLine();

            Console.Write("Soyad: ");
            citizen.Surname = Console.ReadLine();

            Console.Write("Doğum Yılı: ");
            citizen.BirthYear = Convert.ToInt32(Console.ReadLine());

            citizenManager.Validate(citizen);

            Console.WriteLine("\nDevam etmek için lütfen enter tuşuna basınız...");
            Console.ReadLine();
        }
    }
}
