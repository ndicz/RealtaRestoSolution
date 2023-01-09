using Microsoft.Extensions.Configuration;
using RealtaVbNetApi;
using System;

namespace RealtaClient // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static IConfigurationRoot Configuration;

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            BuildConfig();

            IRealtaVbApi _realtaVbApi = new RealtaVbApi(Configuration.GetConnectionString("RealtaDS"));

            // _realtaVbApi.SayHello();

            // FIND ALL ITEM

            //var listRestoOrderMenuDetail = _realtaVbApi.RepositoryManager.RestoOrderMenuDetail.FindAllRestoOrderDetail();
            //foreach (var item in listRestoOrderMenuDetail)
            //{
            //    Console.WriteLine($"{item}");
            //}

            // FIND BY ID

            Console.Write("Masukan ID : ");
            var inputID = Convert.ToInt32(Console.ReadLine());
            var ordermenubyid = _realtaVbApi.RepositoryManager.RestoOrderMenuDetail.FindRestoOrderDetailById(inputID);
            Console.WriteLine($"Found region : {ordermenubyid}");

            //CREATE

            //var createmenu = _realtaVbApi.RepositoryManager.RestoOrderMenuDetail.CreateRestoOrderDetail(new RealtaVbNetApi.Model.RestoOrderMenuDetail
            //{

            //    //OrmePrice = 10000,
            //    //OrmeQyt = 2,
            //    //OrmeSubtotal = 2000,
            //    //OrmeDiscount = 0,
            //    //OmdeOrmeId = 1,
            //    //OmdeRemeId = 1
            //});

            //Console.WriteLine($"New Name :  {createmenu}");
        }

        static void BuildConfig()

        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            Console.WriteLine(Configuration.GetConnectionString("RealtaDS"));
        }
    }
}