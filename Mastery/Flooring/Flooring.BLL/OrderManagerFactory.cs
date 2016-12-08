﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Data;

namespace Flooring.BLL
{
    public static class OrderManagerFactory
    {
        public static OrderManager Create()
        {

            string mode = ConfigurationManager.AppSettings["Mode"].ToString();

            switch (mode)
            {
                case "Test":
                    return new OrderManager(new OrderTestRepository());
                case "Prod":
                default:
                    throw new Exception("Mode value in app config is not valid");
            }
        }
    }
}
