using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_MVC.Dtos.Shared
{
    public class BasePaginationParameters
    {
        internal virtual int MaxPageSize { get; } = 20;
        internal virtual int DefaultPageSize { get; set; } = 12;

        public virtual int PageNumber { get; set; } = 1;

        public int PageSize
        {
            get
            {
                return DefaultPageSize;
            }
            set
            {
                DefaultPageSize = value > MaxPageSize ? MaxPageSize : value;
            }
        }
    }
}
