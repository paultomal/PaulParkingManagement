using AutoMapper;
using BLL.DTOs.CustomerDTOs;
using BLL.DTOs.ServiceProviderDTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL.Services.ServiceProviderServices
{
    public class ParkingSpotsService
    {
        public static List<ParkingSpotSPDTO> Get()
        {
            var data = DataAccessFactory.ParkingSpotsData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ParkingSpot, ParkingSpotSPDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ParkingSpotSPDTO>>(data);
            return mapped;
        }
        public static ParkingSpotSPDTO Get(string id)
        {
            var data = DataAccessFactory.ParkingSpotsData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ParkingSpot, ParkingSpotSPDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ParkingSpotSPDTO>(data);
            return mapped;
        }
        public static ParkingSpotSPDTO InsertParkingSpot(ParkingSpot parkingSpot)
        {
            var data = DataAccessFactory.ParkingSpotsData().Create(parkingSpot);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ParkingSpot, ParkingSpotSPDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ParkingSpotSPDTO>(data);
            return mapped;
        }
        public static   ParkingSpotSPDTO UpdateParkingSpot(ParkingSpot parkingSpot)
        {
            var data = DataAccessFactory.ParkingSpotsData().Update(parkingSpot);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ParkingSpot, ParkingSpotSPDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ParkingSpotSPDTO>(data);
            return mapped;
        }
        public static bool DeleteSpot(string id)
        {
            var res = DataAccessFactory.ParkingSpotsData().Delete(id);
            return res;
        }
        //Reviews
        public static SpotReviewDTO GetwithReviews(string id)
        {
            var data = DataAccessFactory.ParkingSpotsData().Read(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ParkingSpot, ParkingSpotSPDTO>();
                c.CreateMap<Review, ReviewSPDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SpotReviewDTO>(data);
            return mapped;

        }
       
        //Payment
        public static SpotPaymentDTO GetwithPayments(string id)
        {
            var data = DataAccessFactory.ParkingSpotsData().Read(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ParkingSpot, ParkingSpotSPDTO>();
                c.CreateMap<Payment, PaymentSPDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SpotPaymentDTO>(data);
            return mapped;

        }
        //Reservation
        public static SpotReservationDTO GetwithReservations(string id)
        {
            var data = DataAccessFactory.ParkingSpotsData().Read(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ParkingSpot, ParkingSpotSPDTO>();
                c.CreateMap<Reservation, ReservationSPDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SpotReservationDTO>(data);
            return mapped;

        }
    }
}
