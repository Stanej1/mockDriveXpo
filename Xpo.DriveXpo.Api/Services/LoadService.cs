using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xpo.DriveXpo.Api.Models;

namespace Xpo.DriveXpo.Api.Services
{
    public static class LoadService
    {
        private static List<Load> loads;

        static LoadService()
        {
            loads = new List<Load>
            {
                new Load {
                    Commodity = "Tissues",
                    Weight = 500,
                    CustomerName = "Tims Tissue Depot",
                    Equipment = "Dry Van",
                    LoadId = 125,
                    Price = 1500.00M,
                    Stops = new Stop[] {  new Stop { City = "Charlotte", State = "NC", ZipCode = "28105" },
                        new Stop { City = "Dallas", State = "TX", ZipCode = "75001"} }
                },
                new Load {
                    Commodity = "XBoxes",
                    Weight = 10000,
                    CustomerName = "Eds Electronics",
                    Equipment = "Dry Van",
                    LoadId = 1343,
                    Price = 2500.00M,
                    Stops = new Stop[] {  new Stop { City = "Phoneix", State = "AZ", ZipCode = "85001" },
                        new Stop { City = "Dallas", State = "TX", ZipCode = "75001"} }
                },
                new Load {
                    Commodity = "Hazmat",
                    Weight = 5000,
                    CustomerName = "Bad Newz Supplies",
                    Equipment = "Refer",
                    LoadId = 12,
                    Price = 3200.00M,
                    Stops = new Stop[] {  new Stop { City = "Boston", State = "MA", ZipCode = "02110" },
                        new Stop { City = "Oxford", State = "CT", ZipCode = "06483"},
                        new Stop { City = "Los Angeles", State = "CA", ZipCode = "90001" } }
                },
                 new Load {
                    Commodity = "Pillows",
                    Weight = 1000,
                    CustomerName = "Sleepsters Inc",
                    Equipment = "Van",
                    LoadId = 1730,
                    Price = 1900.00M,
                    Stops = new Stop[] {  new Stop { City = "Las Vegas", State = "NV", ZipCode = "89182" },
                        new Stop { City = "Nashville", State = "TN", ZipCode = "37011"},
                        new Stop { City = "Orlando", State = "FL", ZipCode = "32789" } }
                },

                new Load {
                    Commodity = "Magic",
                    Weight = 1,
                    CustomerName = "Mikes Mystery Corp",
                    Equipment = "Dry Van",
                    LoadId = 83939,
                    Price = 60000.00M,
                    Stops = new Stop[] {  new Stop { City = "Denver", State = "CO", ZipCode = "80014" },
                        new Stop { City = "Chicago", State = "IL", ZipCode = "60603"} }
                },


            };
        }

        public static List<Load> GetAllLoads()
        {
            return loads;
        }

        public static Load GetLoadByLoadId(int loadId)
        {
            return loads.Where(x => x.LoadId == loadId).FirstOrDefault();
        }

        public static List<Load> GetLoadsByDispatchCarrierId(int carrierId)
        {
            return loads.Where(x => x.DispatchedBy == carrierId).ToList();
        }

        public static void AssignCarrierToLoad(int carrierId, int loadId)
        {
            var load = loads.Where(x => x.LoadId == loadId).FirstOrDefault();
            if (load != null) load.DispatchedBy = carrierId;
        }
    }
}
