using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockManagement.Data;

namespace StockManagement.Business
{
    public interface ICustomer:IRepository<Customer>
    {
        List<province> GetProvince();
        province GetProvinceById(string provinceId);
        List<district> GetDistricts();
        district GetDistrictsById(string districtId);
        List<district> GetDistrictsByProvinceId(string provinceId);
        List<ward> GetWards();
        ward GetWardsById(string wardId);
        List<ward> GetWardsByDistrictId(string districtId);

        List<vw_AddressCustomer> GetAddressCustomers(Guid userId);

        List<Customer> GetCustomers();
        //List<Customer> GetCustomersManageBy();
        AddressCustomer TransferAddressCustomer(vw_AddressCustomer vwaddressCustomer);
    }
}
