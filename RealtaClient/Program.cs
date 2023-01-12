using Microsoft.Extensions.Configuration;
using RealtaVbNetApi;
using RealtaVbNetApi.Model;
using System;
using System.Net.NetworkInformation;

namespace RealtaClient // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static IConfigurationRoot Configuration;

        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            BuildConfig();

            IRealtaVbApi _realtaVbApi = new RealtaVbApi(Configuration.GetConnectionString("RealtaDS"));

            // _realtaVbApi.SayHello();

            // FIND ALL ITEM ORDER DETAIL

            //var listRestoOrderMenuDetail = _realtaVbApi.RepositoryManager.RestoOrderMenuDetail.FindAllRestoOrderDetail();
            //foreach (var item in listRestoOrderMenuDetail)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //DELETE

            //var detailMenuDelete = _realtaVbApi.RepositoryManager.RestoOrderMenuDetail.DeleteRestoOrderDetail(5);
            //Console.WriteLine($"Delete region row : {detailMenuDelete}");




            //FIND BY ID RESTO MENUS

            //Console.WriteLine("Masukan ID :");
            //var inputIdMenus = Convert.ToInt32(Console.ReadLine());
            //var restomenusbyid = _realtaVbApi.RepositoryManager.RestoMenus.FindRestoMenusById(inputIdMenus);
            //Console.WriteLine($"Found Menu : {restomenusbyid}");

            // FIND BY ID

            //Console.Write("Masukan ID : ");
            //var inputIdOrder = Convert.ToInt32(Console.ReadLine());
            //var ordermenubyid = _realtaVbApi.RepositoryManager.RestoOrderMenuDetail.FindRestoOrderDetailById(inputIdOrder);
            //Console.WriteLine($"Found Menu : {ordermenubyid}");

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
            //var creatrestomenus = _realtaVbApi.RepositoryManager.RestoMenus.CreateRestoMenus(new RealtaVbNetApi.Model.RestoMenus {

            //        RemeFaciId = 2,
            //        RemeName = "Nanas Goreng",
            //        RemeDesc = "Nanas Paling Enak Di Dunia",
            //        RemePrice = 10000,
            //        RemeStatus = "Available",
            //        RemeModDate = DateTime.Now

            //    });

            //Console.WriteLine($"New Name :  {creatrestomenus}");

            // {
            //    RemeFaciId = 2,
            //    RemeName = Nanas Goreng,
            //    RemeDesc = Nanas Paling Enak Di Dunia,
            //    RemePrice = 10000,
            //    RemeStatus = Available,
            //    Reme.Mod = 2023 - 01 - 09 11:14:34.427
            //});

            //ASYNC
            //Console.WriteLine("----------- Async ---------------");

            //var listOmdeAsyn = await _realtaVbApi.RepositoryManager.RestoOrderMenuDetail.FindAllRestoOrderDetailAsync();

            //foreach (var item in listOmdeAsyn)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //var updateomde = _realtaVbApi.RepositoryManager.RestoOrderMenuDetail.UpdateRestoOrderDetailById(2,1000,3,4,0,2,3,false);
            //var omderesult = _realtaVbApi.RepositoryManager.RestoOrderMenuDetail.FindRestoOrderDetailById(2);
            //Console.WriteLine($"{omderesult}");
            //-----------------------------------------RESTO ORDER MENUS--------------------------------------------------------------------


            //FIND BY ID

            //Console.Write("Masukan ID : ");
            //var inputIdOrder = Convert.ToInt32(Console.ReadLine());
            //var ordermenubyid = _realtaVbApi.RepositoryManager.RestoOrderMenu.FindRestoOrderMenusById(inputIdOrder);
            //Console.WriteLine($"Found Menu : {ordermenubyid}");


            //CREATE ORDER MENU

            var createOrderMenu = _realtaVbApi.RepositoryManager.RestoOrderMenu.CreateRestoOrderMenus(new RealtaVbNetApi.Model.RestoOrderMenu
            {

     
                   OrmeOrNum = "MENUS#2022-01-01-000045",
                   OrmeOrDate = DateTime.Now,
                   OrmeTotItem = 3,
                   OrmeTotDIsc = 5000,
                   OrmeTotAmo = 800000,
                   OrmePayType = "CA",
                   OrmeCard = "",
                   OrmeIsPaid = "P",
                   OrmeModDate = DateTime.Today,
                   OrmeUserId = 12

            });

            Console.WriteLine($"New Name :  {createOrderMenu}");

            //-----------------------------------------RESTO MENUS--------------------------------------------------------------------

            //DELETE

            //var detailMenuDelete = _realtaVbApi.RepositoryManager.RestoMenus.DeleteRestoMenus(5);
            //Console.WriteLine($"Delete Menu row : {detailMenuDelete}");



            // FIND ALL 

            //var listRestoMenu = _realtaVbApi.RepositoryManager.RestoMenus.FindAllRestoMenus();
            //foreach (var item in listRestoMenu)
            //{
            //    Console.WriteLine($"{item}");
            //}



            // FIND ALL ASYNC

            //var restoMenusSync = await _realtaVbApi.RepositoryManager.RestoMenus.FindAllRestoMenuslAsync();

            //foreach (var item in restoMenusSync)
            //{
            //    Console.WriteLine($"{item}");
            //}


            //UPDATE 

            //var updaterestom = _realtaVbApi.RepositoryManager.RestoMenus.UpdateRestoMenuslById(1,"Mie Goreng","Mie Goreng enak",10000
            //    ,"Available",DateTime.Now ,false);
            //var omderesult = _realtaVbApi.RepositoryManager.RestoMenus.FindRestoMenusById(1);
            //Console.WriteLine($"{omderesult}");
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