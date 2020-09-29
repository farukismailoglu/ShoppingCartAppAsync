using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol.ShoppingCartApp.Service.Util
{
    public class ServiceException : Exception
    {
        public ServiceException()
        { }

        public ServiceException(string msg) :base(msg)
        { }

        public ServiceException(string msg, Exception innerExcetion) : base(msg, innerExcetion)
        { }

        public override string Message
        {
            get
            {
                var innerText = InnerException != null ? " ,Inner Message" + InnerException.Message : "";

                return $"Message: {base.Message}{innerText}";

            }
        }
    }
}
