using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
namespace MVCWebDemo.Service
{
    public interface UsersService
    {
        Boolean register(ArrayList info);
    }
}