using Amazon.Lambda.Core;


namespace SimpleAWSLambdaProject;

public class Function
{
    // Putting Serializer at the method level instead of assembly level. Useful if more than one function.
    [LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
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
