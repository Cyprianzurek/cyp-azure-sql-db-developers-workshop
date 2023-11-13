
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace Company.Function
{
    public static class SqlTriggerBinding
    {
    [FunctionName("SqlTriggerBindingCSharp1")]
    public static void Run(
        [SqlTrigger("[dbo].[person]", "connection-string")] IReadOnlyList changes, ILogger log)log.LogInformation("SQL Changes: + JsonConvert.SerializeObject(changes))
{

[SqlTrigger("[dbo].[person]", "connection-string")] IReadOnlyList changes, ILogger log)
log.LogInformation("SQL Changes: + JsonConvert.SerializeObject(changes));

public class ToDoItem
public string Id { get; set; }
        O references
    public int Priority { get; set; }
        O references
    public string Description { get; set; }
    }
}