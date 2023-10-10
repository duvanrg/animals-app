using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAnimals.Helpers;

public class Pager<T>
    where T : class
{

    public string Search { get; set; }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public int Total { get; set; }
    public List<T> Registers { get; private set; }
    public Pager(string search, int pageIndex, int pageSize, int total, List<T> registers)
    {
        Search = search;
        PageIndex = pageIndex;
        PageSize = pageSize;
        Total = total;
        Registers = registers;
    }

    public int TotalPages
    {
        get { return (int)Math.Ceiling(Total / (double)PageSize); }
        set { this.TotalPages = value; }
    }

    public bool HasPreviousPage
    {
        get { return (PageIndex > 1); }
        set { this.HasPreviousPage = value; }
    }

    public bool HasNexxtPage
    {
        get { return (PageIndex < TotalPages); }
        set { this.HasNexxtPage = value; }
    }

}
