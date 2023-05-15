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
    public class PaymentService
    {
        public static List<PaymentDTO> Get()
        {
            var data = DataAccessFactory.PaymentData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PaymentDTO>>(data);
            return mapped;
        }
        public static PaymentDTO Get(int id)
        {
            var data = DataAccessFactory.PaymentData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PaymentDTO>(data);
            return mapped;
        }
        public static PaymentDTO Insert(PaymentDTO payment)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PaymentDTO, Payment>();
                //  c.CreateMap<CustomerDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var payments = mapper.Map<Payment>(payment );
            DataAccessFactory.PaymentData().Create(payments);
            return payment;
        }

        public static PaymentDTO Update(PaymentDTO payment)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PaymentDTO, Payment>();
                //  c.CreateMap<CustomerDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var payments = mapper.Map<Payment>(payment);
            DataAccessFactory.PaymentData().Update(payments);
            return payment;
        }
    }
}
