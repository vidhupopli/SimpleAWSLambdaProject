using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace SimpleAWSLambdaProject;

public class Function
{
    // Run Mock Lambda Test Tool profile and pass a JSON Object.
    public string FunctionHandler(InvokedWithData input, ILambdaContext context)
    {
        return $"Namaste, {input.FirstName} {input.LastName}!";
    }
}

public class InvokedWithData
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}
