﻿using DataAccesslayer.Abstract;
using DataAccesslayer.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.EntityFramework
{
    public class EFWriterRepository:GenericRepository<Writer>,IWriterDal
    {
    }
}