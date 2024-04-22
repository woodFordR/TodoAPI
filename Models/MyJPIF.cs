using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace JsonPatchSample;

public static class MyJPIF
{
    public static NewtonsoftJsonPatchInputFormatter GetJsonPatchInputFormatter()
    {
        var builder = new ServiceCollection()
            .AddLogging()
            .AddMvc(options =>
            {
              options.ModelMetadataDetailsProviders.Add(
                new NewtonsoftJsonValidationMetadataProvider());
            })
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings
                    .ContractResolver = new DefaultContractResolver();
            })
            .Services.BuildServiceProvider();

        return builder
            .GetRequiredService<IOptions<MvcOptions>>()
            .Value
            .InputFormatters
            .OfType<NewtonsoftJsonPatchInputFormatter>()
            .First();
    }
}
