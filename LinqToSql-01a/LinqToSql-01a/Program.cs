using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql_01a
{
    class countryContext : DataContext
    {
        public countryContext():
            base (@"Data Source=DESKTOP-QS5GLOC\SQLEXPRESS;Initial Catalog=HRDB;Integrated Security=true")
        {

        }

        public Table<country> countries;
    }

    [Table(Name ="countries")]
    public class country
    {
        private string _country_id;
        [Column(IsPrimaryKey =true,Storage = "_country_id")]

        public string country_id
        {
            get { return this._country_id; }
            set { this._country_id = value; }
        }

        [Column(Name ="country_name")]
        
        public string country_name { get; set; }

        private int _region_id;
        [Column(Storage ="_region_id")]
        public int region_id
        {
            get { return this._region_id; }
            set { this._region_id = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // ReadData();

            insert();
            //edit();

            ReadData();
            Console.ReadKey();
        }

        public static void ReadData()
        {
            countryContext db = new countryContext();

            

           // Table<country> countries = db.GetTable<country>();

            db.Log = Console.Out;

            IQueryable<country> query =
                from c in db.countries
                where c.region_id == 1
                select c;

            foreach (country c in query)
            {
                Console.WriteLine("Id - {0} ----- Country name - {1} ----- Region ID - {2}", c.country_id, c.country_name,c.region_id);
            }
        }

        public static void insert()
        {
            countryContext cou = new countryContext();

            country c = new country();

            c.country_id = 'BD';
            c.country_id = 'Bhutan';
            c.region_id = 2;

            cou.countries.InsertOnSubmit(c);

            cou.SubmitChanges();
        }

        public static void edit()
        {
            countryContext cou = new countryContext();

            country c = cou.countries.Single(ct => ct.country_id == "UK");
            c.country_id = "ukraine";

            cou.SubmitChanges();
        }

        public static void delete()
        {
            countryContext cou = new countryContext();

            country c = cou.countries.Single(ct => ct.country_id == "BD");

            cou.countries.DeleteOnSubmit(c);

            cou.SubmitChanges();
        }
    }
}
