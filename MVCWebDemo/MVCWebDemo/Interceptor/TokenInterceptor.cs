using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Spring.Aop;
using Spring.Aop.Framework;
using Spring.Aop.Support;
using Spring.Aop.Config;
using AopAlliance.Intercept;
using System.Reflection;

namespace MVCWebDemo.Interceptor
{
    public class TokenInterceptor : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            return null;
        }
    }
}