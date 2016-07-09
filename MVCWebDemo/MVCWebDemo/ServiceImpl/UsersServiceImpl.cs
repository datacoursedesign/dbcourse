using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCWebDemo.Service;
using MVCWebDemo.DAO;
using System.Collections;
namespace MVCWebDemo.ServiceImpl
{
    public class UsersServiceImpl:UsersService
    {
        public UsersDAO usersDAO { set; get; }
        public Boolean register(ArrayList info)
        {
            return usersDAO.insertEntity(info);
           

        }
    }
}