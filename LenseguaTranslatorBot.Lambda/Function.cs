using System.Net;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using LenseguaTranslatorBot.Engine.Definitions.Dtos;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LenseguaTranslatorBot.Lambda;

public sealed class Function
{
    public async Task<APIGatewayProxyResponse> FunctionHandler(BotRequest request)
    {
        APIGatewayProxyResponse result = new();
        try
        {
            result.StatusCode = (int)HttpStatusCode.OK;
        }
        catch (Exception e)
        {
            result.Body = e.Message;
            result.StatusCode = (int)HttpStatusCode.InternalServerError;
        }
        return result;
    }
}