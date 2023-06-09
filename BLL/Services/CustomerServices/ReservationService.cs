﻿using AutoMapper;
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
    public class ReservationService
    {
        public static List<ReservationDTO> Get()
        {
            var data = DataAccessFactory.ReservationData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Reservation, ReservationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ReservationDTO>>(data);
            return mapped;
        }
        public static ReservationDTO Get(string id)
        {
            var data = DataAccessFactory.ReservationData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Reservation, ReservationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ReservationDTO>(data);
            return mapped;
        }
        public static ReservationDTO Insert(ReservationDTO reservation)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReservationDTO, Reservation>();
                //  c.CreateMap<CustomerDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var reservations = mapper.Map<Reservation>(reservation);
            DataAccessFactory.ReservationData().Create(reservations);
            return reservation;
        }
        public static ReservationDTO Update(ReservationDTO reservation)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReservationDTO, Reservation>();
            });
            var mapper = new Mapper(cfg);
            var reservations = mapper.Map<Reservation>(reservation);
            DataAccessFactory.ReservationData().Update(reservations);
            return reservation;
        }

    }
}