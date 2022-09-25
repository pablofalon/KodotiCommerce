﻿using Microsoft.EntityFrameworkCore;
using Services.Common.Collection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Common.Paging
{
    public static class PagingExtension
    {
        public static async Task<DataCollection<T>> GetPagedAsync<T>(
            this IQueryable<T> query,
            int page,
            int take) 
        {
            var originalPages = page;

            page--;

            if (page > 0)
            {
                page = page * take;
            }

            var results = new DataCollection<T>
            {
                Items = await query.Skip(page).Take(take).ToListAsync(),
                Total = await query.CountAsync(),
                Page = originalPages
            };

            if (results.Total > 0)
            {
                results.Pages = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(results.Total) / take));
            }

            return results;

        }
    }
}
