﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstract
{
    public interface IMessage
    {
        Task<HelloWorldModel> GetMessage();
    }
}
