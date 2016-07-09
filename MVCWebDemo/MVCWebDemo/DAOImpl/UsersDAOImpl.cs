using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCWebDemo.Models;
using MVCWebDemo.DAO;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using System.Collections;

namespace MVCWebDemo.DAOImpl
{
    public class UsersDAOImpl:UsersDAO
    {
        public ISessionFactory factory { set; get; } 
        public IList<Users> getEntity(string hsql)
        {
            return null;
        }

        public Boolean updateEntity() 
        {
            return false;
        }
        public Boolean deleteEntity() 
        {
            return false;
        }
        public Boolean insertEntity(ArrayList info)
        {
            Users users = new Users();
            users.name=(string)info[0];
            users.pwd=(string)info[1];
            users.phone=(string)info[2];
            users.role=(int)info[3];
            
            return true;
        }

    }
}