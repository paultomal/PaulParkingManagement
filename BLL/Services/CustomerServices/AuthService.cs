using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.CustomerServices
{
    public class AuthService
    {
        public static TokenDTO Authenticate(string username, string password)
        {
            var res = DataAccessFactory.AuthData().Authenticate(username, password);
            if (res)
            {
                var token = new Token();
                token.CustomerID = username;
                token.CreatedAt = DateTime.Now;
                token.TKey = Guid.NewGuid().ToString();

                var data = DataAccessFactory.TokenData().Create(token);
                if (data != null)
                {
                    var cfg = new MapperConfiguration(c =>
                    {
                        c.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenDTO>(data);
                }
            }
            return null;
        }
    }
}
