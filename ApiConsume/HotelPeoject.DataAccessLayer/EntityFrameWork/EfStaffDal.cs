﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFrameWork
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
        }

        public int GetStaffCount()
        {
           using var context=new Context();
            var value = context.Staffs.Count();
            return value;
        }

        public List<Staff> Last4Staff()
        {
            using var context = new Context();
            var values = context.Staffs.OrderByDescending(x=>x.StaffID).Take(4).ToList();
            return values;
        }
    }
}
