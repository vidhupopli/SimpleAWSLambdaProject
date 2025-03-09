using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace SimpleAWSLambdaProject;

public class Function
{
    // Run Mock Lambda Test Tool profile and pass a string like this "Vidhu"
    public string FunctionHandler(string input, ILambdaContext context)
    {
        return input.ToUpper();
    }
}
