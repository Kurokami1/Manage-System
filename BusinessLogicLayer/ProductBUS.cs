﻿using DataAccessLayer;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLogicLayer
{
    public class ProductBUS
    {
        ProductDAO dao = new ProductDAO();
        
        public DataTable GetProductsByPriceRange(decimal lowPrice, decimal highPrice)
        {
            return dao.GetProductsByPriceRange(lowPrice, highPrice);
        }
        public DataTable GetDataProduct()
        {
            return dao.GetDataProduct();
        }
        public DataTable GetData()
        {
            return dao.GetData();
        }

        public DataTable SearchProductinOrder(string name)
        {
            return dao.SearchProductinOrder(name);
        }

        public DataTable GetDataProductAvailable()
        {
            return dao.GetDataProductAvailable();
        }

        public DataTable GetDataByID(string id)
        {
            return dao.GetDataByID(id);
        }

        public DataTable GetDataByName(string name)
        {
            return dao.GetDataByName(name);
        }

        public DataTable GetDataProductWarranty(string name)
        {
            return dao.GetDataProductWarranty(name);
        }

        public int Insert(Product obj)
        {
            return dao.Insert(obj);
        }


        public int Update(Product obj)
        {
            return dao.Update(obj);
        }

        public int Delete(string ID)
        {
            return dao.Delete(ID);
        }
    }
}
