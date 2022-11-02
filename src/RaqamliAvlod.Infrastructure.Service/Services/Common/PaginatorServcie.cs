using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RaqamliAvlod.Infrastructure.Service.Services.Common;

public class PaginatorServcie : IPaginatorService
{
    private readonly IHttpContextAccessor _accessor;

    public PaginatorServcie(IHttpContextAccessor accessor)
    {
        _accessor = accessor;
    }
    public void ToPagenator(PaginationMetaData metaData)
    {
        _accessor.HttpContext.Response.Headers.Add("X-Pagination", 
            JsonConvert.SerializeObject(metaData));
    }
}
