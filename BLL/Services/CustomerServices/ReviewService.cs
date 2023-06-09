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
    public class ReviewService
    {
        public static List<ReviewDTO> Get()
        {
            var data = DataAccessFactory.ReviewData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ReviewDTO>>(data);
            return mapped;
        }
        public static ReviewDTO Get(string id)
        {
            var data = DataAccessFactory.ReviewData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ReviewDTO>(data);
            return mapped;
        }
        public static ReviewDTO Insert(ReviewDTO review)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReviewDTO, Review>();
            });
            var mapper = new Mapper(cfg);

            var reviews = mapper.Map<Review>(review);
            DataAccessFactory.ReviewData().Create(reviews);
            return review;
        }
        public static ReviewDTO Update(ReviewDTO review)
        {

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReviewDTO, Review>();
            });
            var mapper = new Mapper(cfg);

            var reviews = mapper.Map<Review>(review);
            DataAccessFactory.ReviewData().Update(reviews);
            return review;
        }
        public static bool DeleteReview(string id)
        {
            var res = DataAccessFactory.ReviewData().Delete(id);
            return res;
        }
    }
}
