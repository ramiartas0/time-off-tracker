﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Off_Tracker.DAL.Abstract;
using Time_Off_Tracker.DAL.Concrete;
using Time_Off_Tracker.DAL.Repositories;
using Time_Off_Tracker.Entity.Concrete;

namespace Time_Off_Tracker.DAL.Entity
{
    public class EfUserDal:GenericRepository<User>,IUserDal
    {
        public EfUserDal(ApiContext context): base (context)
        {
            
        }
    }
}
