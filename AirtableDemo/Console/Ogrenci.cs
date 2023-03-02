using AirtableApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyApp
{
    public class Ogrenci
    {
        public string Id { get; set; }
        public string YetGenId { get; set; }
        private string YetGenIdKey = "Primary";
        public string Name{ get; set; }
        private string NameKey = "Ad";
        public string Surname { get; set; }
        private string SurnameKey = "Soyad";
        public string Born { get; set; }
        private string BornKey = "Doğum";

        public Ogrenci() { }
        public Ogrenci(AirtableRecord p)
        {
            Id = p.Id;
            YetGenId = ((JsonElement)p.GetField(YetGenIdKey)).ToString();
            Name = ((JsonElement)p.GetField(NameKey)).ToString();
            Surname = ((JsonElement)p.GetField(SurnameKey)).ToString();
            Born = ((JsonElement?)p.GetField(BornKey)).ToString();
        }
        public Fields GetFields()
        {
            Fields fields = new Fields();
            fields.AddField(YetGenIdKey, YetGenId);
            fields.AddField(NameKey, Name);
            fields.AddField(SurnameKey, Surname);
            fields.AddField(BornKey, Born);
            return fields;
        }
    }
}
