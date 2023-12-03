using Microsoft.AspNetCore.Mvc;

namespace ProjectManagementApi.Dto;

public class PrettyProduct
{
    
    [FromBody]
    public string? Name { get; set; }
    [FromBody]
    public string? Description { get; set; }
}