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
    }
}
