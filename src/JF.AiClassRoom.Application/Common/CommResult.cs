using System;
using System.Collections.Generic;
using System.Text;

namespace JF.AiClassRoom.Common
{
    public class BaseCommResult
    {
        public ErrorCode Code { get; set; } = ErrorCode.Error;

        /// <summary>
        /// 提示消息
        /// </summary>
        public string Msg { get; set; }
    }
    public class CommResult : BaseCommResult
    {
        public dynamic Data { get; set; }
    }

    public class CommResult<T> : BaseCommResult
    {
        public T Data { get; set; }
    }

    public enum ErrorCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = 10000,
        /// <summary>
        /// 操作失败
        /// </summary>
        Error = 00000,
        /// <summary>
        /// 认证失败
        /// </summary>
        AuthenticationFailed = 10001,
        /// <summary>
        /// 授权过期
        /// </summary>
        AuthenticationTimeOut = 10002,
        /// <summary>
        /// 参数不符合规范
        /// </summary>
        ParamVerificationFailed = 10003,
        /// <summary>
        /// 异常错误
        /// </summary>
        ExceptionError = 50003
    }
}
