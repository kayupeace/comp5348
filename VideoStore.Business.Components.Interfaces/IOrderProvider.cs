﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoStore.Business.Entities;

namespace VideoStore.Business.Components.Interfaces
{
    public interface IOrderProvider
    {
        int SubmitOrder(Order pOrder);
    }
}
