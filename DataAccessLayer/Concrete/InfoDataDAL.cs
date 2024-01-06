using DataAccessLayer.Abstracte;
using InfoEntityLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class InfoDataDAL : IInfoData
        {
            private readonly AplicationContext _context;

            public InfoDataDAL(IConfiguration configuration)
            {
         
                _context = new AplicationContext(configuration);
            }

        public InfoData infoDataAdd(InfoData data)
        {
            if (!string.IsNullOrEmpty(data.External))
            {
                _context.InfoDatas.Add(data);
                _context.SaveChanges();
                return data;
            }
            return data;

        }
    }
    }


