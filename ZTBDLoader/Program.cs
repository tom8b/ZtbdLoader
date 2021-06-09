using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using LumenWorks.Framework.IO.Csv;
using ZTBDLoader.model;

namespace ZTBDLoader
{
    class Program
    {
        static void Main(string[] args)
        {

            // load checkouts

            //var csvTable = new DataTable();
            //using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"F:\SourceCode\ZTBDLoader\ZTBDLoader\archive\Checkouts_By_Title_Data_Lens_2005.csv")), true))
            //{
            //    csvTable.Load(csvReader);
            //}

            //List<Checkouts> searchParameters = new List<Checkouts>();

            //for (int i = 0; i < csvTable.Rows.Count; i++)
            //{
            //    var dateAsString = ((string) (csvTable.Rows[i][5])).Remove(19, 3);
            //    var parsed = DateTime.ParseExact(dateAsString, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            //    try
            //    {
            //        searchParameters.Add(new Checkouts
            //        {
            //            BibNumber = int.Parse((string)(csvTable.Rows[i][0])),
            //            ItemBarcode = long.Parse((string)(csvTable.Rows[i][1])),
            //            ItemType = (string)(csvTable.Rows[i][2]),
            //            Collection = (string)(csvTable.Rows[i][3]),
            //            CallNumber = (string)(csvTable.Rows[i][4]),
            //            CheckoutDateTime = DateTime.ParseExact(((string)(csvTable.Rows[i][5])).Remove(19, 3), "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
            //        });
            //    }
            //    catch (Exception e)
            //    {
            //    }
            //}

            // load CollectionInventory

            //var csvTable = new DataTable();
            //using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(@"F:\SourceCode\ZTBDLoader\ZTBDLoader\archive\Library_Collection_Inventory.csv")), true))
            //{
            //    csvTable.Load(csvReader);
            //}
            //List<CollectionInventory> searchParameters = new List<CollectionInventory>();

            //var count = csvTable.Rows.Count ;
            //for (int i = 0; i < count; i++)
            //{
            //    try
            //    {
            //        searchParameters.Add(new CollectionInventory
            //        {
            //            BibNum = int.Parse((string)(csvTable.Rows[i][0])),
            //            Title = (string)(csvTable.Rows[i][1]),
            //            Author = (string)(csvTable.Rows[i][2]),
            //            ISBN = (string)(csvTable.Rows[i][3]),
            //            PublicationYear = ((string)(csvTable.Rows[i][4])),
            //            Publisher = (string)(csvTable.Rows[i][5]),
            //            Subjects = (string)(csvTable.Rows[i][6]),
            //            ItemType = (string)(csvTable.Rows[i][7]),
            //            ItemCollection = (string)(csvTable.Rows[i][8]),
            //            FloatingItem = (string)(csvTable.Rows[i][9]),
            //            ItemLocation = (string)(csvTable.Rows[i][10]),
            //            ReportDate = DateTime.ParseExact(((string)(csvTable.Rows[i][11])), "MM/dd/yyyy", CultureInfo.InvariantCulture),
            //            ItemCount = int.Parse((string)(csvTable.Rows[i][12])),
            //        });
            //    }
            //    catch (Exception e)
            //    {
            //    }
            //}

            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(@"F:\SourceCode\ZTBDLoader\ZTBDLoader\archive\Integrated_Library_System__ILS__Data_Dictionary.csv")), true))
            {
                csvTable.Load(csvReader);
            }
            List<DataDictionary> searchParameters = new List<DataDictionary>();

            var count = csvTable.Rows.Count;
            using (var db = new EFContext())
                for (int i = 0; i < count; i++)
            {
                try
                {
                    db.Add(new DataDictionary
                    {
                        Code = (string) (csvTable.Rows[i][0]),
                        Description = (string) (csvTable.Rows[i][1]),
                        CodeType = (string) (csvTable.Rows[i][2]),
                        FormatGroup = (string) (csvTable.Rows[i][3]),
                        FormatSubgroup = (string) (csvTable.Rows[i][4])
                    });
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                }
            }

            Console.WriteLine("ss");
        }
    }
}
