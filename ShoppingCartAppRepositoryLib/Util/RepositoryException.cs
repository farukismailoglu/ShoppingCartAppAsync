﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Microsoft.VisualBasic;

namespace Trendyol.ShoppingCartApp.Repository.Util
{
    public class RepositoryException : Exception
    {

        public RepositoryException()
        {}

        public RepositoryException(string msg) : base(msg)
        { }

        public RepositoryException(string msg, Exception innerException) : base(msg, innerException)
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
