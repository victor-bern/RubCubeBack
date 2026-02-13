using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Application.DTOs.Common
{
    public class ListItemsResponse<T> where T : class
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public T Items { get; set; }

    }
}
