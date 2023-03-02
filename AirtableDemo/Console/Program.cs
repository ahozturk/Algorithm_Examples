using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AirtableApiClient;
using MyApp;

namespace AirtableConsole
{
    static class MyApp
    {
        static async Task Main(string[] args)
        {
            MyAirtable myAirtable = new MyAirtable();
            //Ogrenci ogrenci = new Ogrenci()
            //{
            //    Born = "2004",
            //    Name = "Hakan",
            //    YetGenId = "100",
            //    Id = "10",

            //};
            //await myAirtable.CreateRecord(ogrenci);

            var a = await myAirtable.GetRecords();
            foreach (var item in a)
            {
                Console.WriteLine(item.Id + " - " + item.Name + " " + item.Surname + " - " + item.Born);
            }
        }
    }

    public class MyAirtable
    {
        private AirtableBase airtableBase;
        private string tableName;
        public MyAirtable()
        {
            airtableBase = new AirtableBase("pateGJgILYVNK23qK.ce70a8ec62f9fb379f8cb7b0a5a31e537bc5e7fc700d77a1d1532bbbe036a2f2", "appWYeK0E41xZYrvU");
            tableName = "tblSXKejdrefKRXtS";
        }

        public async Task CreateRecord(Ogrenci p)
        {
            await airtableBase.CreateRecord(tableName, p.GetFields(), true);
        }
        public async Task<List<Ogrenci>> GetRecords()
        {
            var a = await airtableBase.ListRecords(tableName, maxRecords: 100);
            List<Ogrenci> result = new List<Ogrenci>();
            foreach (var item in a.Records)
            {
                result.Add(new Ogrenci(item));
            }
            return result;
        }
    }
}