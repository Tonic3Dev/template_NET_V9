﻿namespace template_net_9.DTOs
{
    public class ListResponse<T>
    {
        public ListResponse(List<T> items, int totalCount)
        {
            Items = items;
            TotalCount = totalCount;
        }

        public List<T> Items { get; set; }
        public int TotalCount { get; set; }
    }
}
