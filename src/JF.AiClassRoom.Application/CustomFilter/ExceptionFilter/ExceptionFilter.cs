using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using Abp.Runtime.Validation;
using JF.AiClassRoom.Common;

namespace JF.AiClassRoom.Application.CustomFilter.ExceptionFilter
{
    /// <summary>
    /// 全局异常过滤器
    /// </summary>
    public class HttpGlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            context.ExceptionHandled = true;
            HttpResponse response = context.HttpContext.Response;
            response.ContentType = "application/json";

            if (context.Exception is AbpValidationException)
            {
                response.StatusCode = (int)HttpStatusCode.OK;
                context.Result = new ObjectResult(new CommResult { Code = ErrorCode.Success, Msg = string.Join(";", ((AbpValidationException)context.Exception).ValidationErrors) });
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Result = new ObjectResult(new CommResult { Code = ErrorCode.ExceptionError, Msg = "请求异常,请重试" });
            }

        }
    }
}
