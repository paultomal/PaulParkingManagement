using AutoMapper;
using BLL.DTOs.CustomerDTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.CustomerServices
{
    public class CustomerServices
    {
        public static List<CustomerDTO> Get()
        {
            var data = DataAccessFactory.CustomerData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer,CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<CustomerDTO>>(data);
            return mapped;
        }
        public static CustomerDTO Get(string id)
        {
            var data = DataAccessFactory.CustomerData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CustomerDTO>(data);
            return mapped;
        }
        public static CustomerDTO Insert(CustomerDTO customer)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerDTO, Customer>();
            });
            var mapper = new Mapper(cfg);
            
            var customers = mapper.Map<Customer>(customer);
            DataAccessFactory.CustomerData().Create(customers);
            return customer;
        }
        public static CustomerDTO Update(CustomerDTO customer)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CustomerDTO, Customer>();
            });
            var mapper = new Mapper(cfg);

            var customers = mapper.Map<Customer>(customer);
            DataAccessFactory.CustomerData().Update(customers);
            return customer;
        }
        public static bool DeleteCustomer(string id)
        {
            var res = DataAccessFactory.CustomerData().Delete(id);
            return res;
        }
    }
}
