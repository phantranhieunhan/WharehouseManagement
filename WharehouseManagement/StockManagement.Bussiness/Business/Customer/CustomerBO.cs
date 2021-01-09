using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockManagement.Data;

namespace StockManagement.Business
{
    public class CustomerBO:Repository<Customer>, ICustomer
    {
        public List<province> GetProvince()
        {
            using (var db = new StockManagementEntities())
            {
                return db.province.ToList();
            }
        }
        public province GetProvinceById(string provinceId)
        {
            using (var db = new StockManagementEntities())
            {
                return db.province.Find(provinceId);
            }
        }
        public List<district> GetDistricts()
        {
            using (var db = new StockManagementEntities())
            {
                return db.district.ToList();
            }
        }
        public district GetDistrictsById(string districtId)
        {
            using (var db = new StockManagementEntities())
            {
                return db.district.Find(districtId);
            }
        }
        public List<district> GetDistrictsByProvinceId(string provinceId)
        {
            using (var db = new StockManagementEntities())
            {
                return db.district.Where(x => x.province_id == provinceId).ToList();
            }
        }
        public List<ward> GetWards()
        {
            using (var db = new StockManagementEntities())
            {
                return db.ward.ToList();
            }
        }
        public ward GetWardsById(string wardId)
        {
            using (var db = new StockManagementEntities())
            {
                return db.ward.Find(wardId);
            }
        }
        public List<ward> GetWardsByDistrictId(string districtId)
        {
            using (var db = new StockManagementEntities())
            {
                return db.ward.Where(x=>x.district_id == districtId).ToList();
            }
        }

        public List<vw_AddressCustomer> GetAddressCustomers(Guid customerId)
        {
            using (var db = new StockManagementEntities())
            {
                return db.vw_AddressCustomer.Where(x => x.CustomerId == customerId).ToList();
            }
        }

        public List<Customer> GetCustomers()
        {
            using (var db = new StockManagementEntities())
            {
                Customer customer = new Customer();
                return db.Customer.ToList();
                
            }
        }
        public AddressCustomer TransferAddressCustomer(vw_AddressCustomer vwaddressCustomer)
        {
            AddressCustomer addressCustomer = new AddressCustomer();

            addressCustomer.AddressCustomerId = vwaddressCustomer.AddressCustomerId;
            addressCustomer.ProvinceCity = vwaddressCustomer.ProvinceId;
            addressCustomer.District = vwaddressCustomer.DistrictId;
            addressCustomer.Ward = vwaddressCustomer.WardId;
            addressCustomer.Detail = vwaddressCustomer.Detail;
            
            return addressCustomer;
        }
        //public bool SaveAddressCustomer(AddressCustomer addressCustomer)
        //{
        //    using (var db = new StockManagementEntities())
        //    {
        //        db.AddressCustomer.Add()
        //    }
        //}
    }

}