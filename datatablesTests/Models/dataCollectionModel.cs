using datatablesTests.interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace datatablesTests.Models
{
    public class dataCollectionModel : ISelfBindableModel
    {
        public dataCollectionModel()
        {
            dataItems = new List<dataModel>();
        }

        public List<dataModel> dataItems { get; set; }

        public void generateData()
        {            
            Random rnd = new Random();

            for (int i = 0; i <= 100; i++)
            {
                dataItems.Add(new dataModel()
                {
                    id = i,
                    guid = Guid.NewGuid().ToString(),
                    decimalData = rnd.Next(1, 100),
                    enumData = (enumData)rnd.Next(1, 3),
                    boleanData = i % 2 == 0,
                    dateTimeData = randomDay(rnd)
                });
            }
        }      

        DateTime randomDay(Random rnd)
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        public void rebuildFromForm(NameValueCollection form)
        {
            List<Tuple<string, string>> keyValuePairs = new List<Tuple<string, string>>();

            foreach (var key in form.AllKeys)
            {
                keyValuePairs.Add(new Tuple<string, string>(key, form.GetValues(key)[0]));
            }

            string s = string.Empty;
        }
    }
}