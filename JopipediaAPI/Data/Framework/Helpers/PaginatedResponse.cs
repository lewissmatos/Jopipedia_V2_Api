using AutoMapper;

namespace JopipediaAPI.Data.Framework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
public class PaginatedResponse<T>
{
    public List<T> Data { get; private set; }

    public MetaResponse Meta { get; private set; }
    public PaginatedResponse(List<T> data, MetaResponse meta)
    {
        Meta = meta;
        Data = data;
    }

    public bool HasPreviousPage => Meta.CurrentPage > 1;
    public bool HasNextPage => Meta.CurrentPage < Meta.TotalPages;

    public static async Task<PaginatedResponse<T>> CreateAsync(IQueryable<T> source, int pageIndex = 1, int pageSize = 10)
    {
        var count = await source.CountAsync();
        var res = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        var meta = new MetaResponse(pageIndex, (int)Math.Ceiling(count / (double)pageSize), count);
        return new PaginatedResponse<T>(res, meta);
    }
}

