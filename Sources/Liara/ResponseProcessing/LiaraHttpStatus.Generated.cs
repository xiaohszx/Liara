﻿// <autogenerated>
// This is Launchark auto-generated code. Any changes made manually will be lost
// the next time this code is regenerated.
// </autogenerated>

using System;
using Liara.ResponseProcessing;

namespace Liara
{
    public sealed partial class LiaraHttpStatus
    {
        
        /// <summary>
        /// Status Code: 100
        /// Status Description: Continue
        /// </summary>
        public static readonly LiaraHttpStatus Continue = new LiaraHttpStatus(100, "Continue", HttpStatusCategory.Informational);
                
        
        /// <summary>
        /// Status Code: 101
        /// Status Description: Switching Protocols
        /// </summary>
        public static readonly LiaraHttpStatus SwitchingProtocols = new LiaraHttpStatus(101, "Switching Protocols", HttpStatusCategory.Informational);
                
        
        /// <summary>
        /// Status Code: 102
        /// Status Description: Processing
        /// </summary>
        public static readonly LiaraHttpStatus Processing = new LiaraHttpStatus(102, "Processing", HttpStatusCategory.Informational);
                
        
        /// <summary>
        /// Status Code: 200
        /// Status Description: OK
        /// </summary>
        public static readonly LiaraHttpStatus OK = new LiaraHttpStatus(200, "OK", HttpStatusCategory.Success);
                
        
        /// <summary>
        /// Status Code: 201
        /// Status Description: Created
        /// </summary>
        public static readonly LiaraHttpStatus Created = new LiaraHttpStatus(201, "Created", HttpStatusCategory.Success);
                
        
        /// <summary>
        /// Status Code: 202
        /// Status Description: Accepted
        /// </summary>
        public static readonly LiaraHttpStatus Accepted = new LiaraHttpStatus(202, "Accepted", HttpStatusCategory.Success);
                
        
        /// <summary>
        /// Status Code: 203
        /// Status Description: Non-Authoritative Information
        /// </summary>
        public static readonly LiaraHttpStatus NonAuthoritativeInformation = new LiaraHttpStatus(203, "Non-Authoritative Information", HttpStatusCategory.Success);
                
        
        /// <summary>
        /// Status Code: 204
        /// Status Description: No Content
        /// </summary>
        public static readonly LiaraHttpStatus NoContent = new LiaraHttpStatus(204, "No Content", HttpStatusCategory.Success);
                
        
        /// <summary>
        /// Status Code: 205
        /// Status Description: Reset Content
        /// </summary>
        public static readonly LiaraHttpStatus ResetContent = new LiaraHttpStatus(205, "Reset Content", HttpStatusCategory.Success);
                
        
        /// <summary>
        /// Status Code: 206
        /// Status Description: Partial Content
        /// </summary>
        public static readonly LiaraHttpStatus PartialContent = new LiaraHttpStatus(206, "Partial Content", HttpStatusCategory.Success);
                
        
        /// <summary>
        /// Status Code: 207
        /// Status Description: Multi-Status
        /// </summary>
        public static readonly LiaraHttpStatus MultiStatus = new LiaraHttpStatus(207, "Multi-Status", HttpStatusCategory.Success);
                
        
        /// <summary>
        /// Status Code: 208
        /// Status Description: Already Reported
        /// </summary>
        public static readonly LiaraHttpStatus AlreadyReported = new LiaraHttpStatus(208, "Already Reported", HttpStatusCategory.Success);
                
        
        /// <summary>
        /// Status Code: 226
        /// Status Description: IM Used
        /// </summary>
        public static readonly LiaraHttpStatus IMUsed = new LiaraHttpStatus(226, "IM Used", HttpStatusCategory.Success);
                
        
        /// <summary>
        /// Status Code: 300
        /// Status Description: Multiple Choices
        /// </summary>
        public static readonly LiaraHttpStatus MultipleChoices = new LiaraHttpStatus(300, "Multiple Choices", HttpStatusCategory.Redirection);
                
        
        /// <summary>
        /// Status Code: 301
        /// Status Description: Moved Permanently
        /// </summary>
        public static readonly LiaraHttpStatus MovedPermanently = new LiaraHttpStatus(301, "Moved Permanently", HttpStatusCategory.Redirection);
                
        
        /// <summary>
        /// Status Code: 302
        /// Status Description: Found
        /// </summary>
        public static readonly LiaraHttpStatus Found = new LiaraHttpStatus(302, "Found", HttpStatusCategory.Redirection);
                
        
        /// <summary>
        /// Status Code: 303
        /// Status Description: See Other
        /// </summary>
        public static readonly LiaraHttpStatus SeeOther = new LiaraHttpStatus(303, "See Other", HttpStatusCategory.Redirection);
                
        
        /// <summary>
        /// Status Code: 304
        /// Status Description: Not Modified
        /// </summary>
        public static readonly LiaraHttpStatus NotModified = new LiaraHttpStatus(304, "Not Modified", HttpStatusCategory.Redirection);
                
        
        /// <summary>
        /// Status Code: 305
        /// Status Description: Use Proxy
        /// </summary>
        public static readonly LiaraHttpStatus UseProxy = new LiaraHttpStatus(305, "Use Proxy", HttpStatusCategory.Redirection);
                
        
        /// <summary>
        /// Status Code: 306
        /// Status Description: Reserved
        /// </summary>
        public static readonly LiaraHttpStatus Reserved = new LiaraHttpStatus(306, "Reserved", HttpStatusCategory.Redirection);
                
        
        /// <summary>
        /// Status Code: 307
        /// Status Description: Temporary Redirect
        /// </summary>
        public static readonly LiaraHttpStatus TemporaryRedirect = new LiaraHttpStatus(307, "Temporary Redirect", HttpStatusCategory.Redirection);
                
        
        /// <summary>
        /// Status Code: 308
        /// Status Description: Permanent Redirect
        /// </summary>
        public static readonly LiaraHttpStatus PermanentRedirect = new LiaraHttpStatus(308, "Permanent Redirect", HttpStatusCategory.Redirection);
                
        
        /// <summary>
        /// Status Code: 400
        /// Status Description: Bad Request
        /// </summary>
        public static readonly LiaraHttpStatus BadRequest = new LiaraHttpStatus(400, "Bad Request", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 401
        /// Status Description: Unauthorized
        /// </summary>
        public static readonly LiaraHttpStatus Unauthorized = new LiaraHttpStatus(401, "Unauthorized", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 402
        /// Status Description: Payment Required
        /// </summary>
        public static readonly LiaraHttpStatus PaymentRequired = new LiaraHttpStatus(402, "Payment Required", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 403
        /// Status Description: Forbidden
        /// </summary>
        public static readonly LiaraHttpStatus Forbidden = new LiaraHttpStatus(403, "Forbidden", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 404
        /// Status Description: Not Found
        /// </summary>
        public static readonly LiaraHttpStatus NotFound = new LiaraHttpStatus(404, "Not Found", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 405
        /// Status Description: Method Not Allowed
        /// </summary>
        public static readonly LiaraHttpStatus MethodNotAllowed = new LiaraHttpStatus(405, "Method Not Allowed", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 406
        /// Status Description: Not Acceptable
        /// </summary>
        public static readonly LiaraHttpStatus NotAcceptable = new LiaraHttpStatus(406, "Not Acceptable", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 407
        /// Status Description: Proxy Authentication Required
        /// </summary>
        public static readonly LiaraHttpStatus ProxyAuthenticationRequired = new LiaraHttpStatus(407, "Proxy Authentication Required", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 408
        /// Status Description: Request Timeout
        /// </summary>
        public static readonly LiaraHttpStatus RequestTimeout = new LiaraHttpStatus(408, "Request Timeout", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 409
        /// Status Description: Conflict
        /// </summary>
        public static readonly LiaraHttpStatus Conflict = new LiaraHttpStatus(409, "Conflict", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 410
        /// Status Description: Gone
        /// </summary>
        public static readonly LiaraHttpStatus Gone = new LiaraHttpStatus(410, "Gone", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 411
        /// Status Description: Length Required
        /// </summary>
        public static readonly LiaraHttpStatus LengthRequired = new LiaraHttpStatus(411, "Length Required", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 412
        /// Status Description: Precondition Failed
        /// </summary>
        public static readonly LiaraHttpStatus PreconditionFailed = new LiaraHttpStatus(412, "Precondition Failed", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 413
        /// Status Description: Request Entity Too Large
        /// </summary>
        public static readonly LiaraHttpStatus RequestEntityTooLarge = new LiaraHttpStatus(413, "Request Entity Too Large", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 414
        /// Status Description: Request-URI Too Long
        /// </summary>
        public static readonly LiaraHttpStatus RequestURITooLong = new LiaraHttpStatus(414, "Request-URI Too Long", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 415
        /// Status Description: Unsupported Media Type
        /// </summary>
        public static readonly LiaraHttpStatus UnsupportedMediaType = new LiaraHttpStatus(415, "Unsupported Media Type", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 416
        /// Status Description: Requested Range Not Satisfiable
        /// </summary>
        public static readonly LiaraHttpStatus RequestedRangeNotSatisfiable = new LiaraHttpStatus(416, "Requested Range Not Satisfiable", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 417
        /// Status Description: Expectation Failed
        /// </summary>
        public static readonly LiaraHttpStatus ExpectationFailed = new LiaraHttpStatus(417, "Expectation Failed", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 422
        /// Status Description: Unprocessable Entity
        /// </summary>
        public static readonly LiaraHttpStatus UnprocessableEntity = new LiaraHttpStatus(422, "Unprocessable Entity", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 423
        /// Status Description: Locked
        /// </summary>
        public static readonly LiaraHttpStatus Locked = new LiaraHttpStatus(423, "Locked", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 424
        /// Status Description: Failed Dependency
        /// </summary>
        public static readonly LiaraHttpStatus FailedDependency = new LiaraHttpStatus(424, "Failed Dependency", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 426
        /// Status Description: Upgrade Required
        /// </summary>
        public static readonly LiaraHttpStatus UpgradeRequired = new LiaraHttpStatus(426, "Upgrade Required", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 428
        /// Status Description: Precondition Required
        /// </summary>
        public static readonly LiaraHttpStatus PreconditionRequired = new LiaraHttpStatus(428, "Precondition Required", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 429
        /// Status Description: Too Many Requests
        /// </summary>
        public static readonly LiaraHttpStatus TooManyRequests = new LiaraHttpStatus(429, "Too Many Requests", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 431
        /// Status Description: Request Header Fields Too Large
        /// </summary>
        public static readonly LiaraHttpStatus RequestHeaderFieldsTooLarge = new LiaraHttpStatus(431, "Request Header Fields Too Large", HttpStatusCategory.ClientError);
                
        
        /// <summary>
        /// Status Code: 500
        /// Status Description: Internal Server Error
        /// </summary>
        public static readonly LiaraHttpStatus InternalServerError = new LiaraHttpStatus(500, "Internal Server Error", HttpStatusCategory.ServerError);
                
        
        /// <summary>
        /// Status Code: 501
        /// Status Description: Not Implemented
        /// </summary>
        public static readonly LiaraHttpStatus NotImplemented = new LiaraHttpStatus(501, "Not Implemented", HttpStatusCategory.ServerError);
                
        
        /// <summary>
        /// Status Code: 502
        /// Status Description: Bad Gateway
        /// </summary>
        public static readonly LiaraHttpStatus BadGateway = new LiaraHttpStatus(502, "Bad Gateway", HttpStatusCategory.ServerError);
                
        
        /// <summary>
        /// Status Code: 503
        /// Status Description: Service Unavailable
        /// </summary>
        public static readonly LiaraHttpStatus ServiceUnavailable = new LiaraHttpStatus(503, "Service Unavailable", HttpStatusCategory.ServerError);
                
        
        /// <summary>
        /// Status Code: 504
        /// Status Description: Gateway Timeout
        /// </summary>
        public static readonly LiaraHttpStatus GatewayTimeout = new LiaraHttpStatus(504, "Gateway Timeout", HttpStatusCategory.ServerError);
                
        
        /// <summary>
        /// Status Code: 505
        /// Status Description: HTTP Version Not Supported
        /// </summary>
        public static readonly LiaraHttpStatus HTTPVersionNotSupported = new LiaraHttpStatus(505, "HTTP Version Not Supported", HttpStatusCategory.ServerError);
                
        
        /// <summary>
        /// Status Code: 506
        /// Status Description: Variant Also Negotiates
        /// </summary>
        public static readonly LiaraHttpStatus VariantAlsoNegotiates = new LiaraHttpStatus(506, "Variant Also Negotiates", HttpStatusCategory.ServerError);
                
        
        /// <summary>
        /// Status Code: 507
        /// Status Description: Insufficient Storage
        /// </summary>
        public static readonly LiaraHttpStatus InsufficientStorage = new LiaraHttpStatus(507, "Insufficient Storage", HttpStatusCategory.ServerError);
                
        
        /// <summary>
        /// Status Code: 508
        /// Status Description: Loop Detected
        /// </summary>
        public static readonly LiaraHttpStatus LoopDetected = new LiaraHttpStatus(508, "Loop Detected", HttpStatusCategory.ServerError);
                
        
        /// <summary>
        /// Status Code: 510
        /// Status Description: Not Extended
        /// </summary>
        public static readonly LiaraHttpStatus NotExtended = new LiaraHttpStatus(510, "Not Extended", HttpStatusCategory.ServerError);
                
        
        /// <summary>
        /// Status Code: 511
        /// Status Description: Network Authentication Required
        /// </summary>
        public static readonly LiaraHttpStatus NetworkAuthenticationRequired = new LiaraHttpStatus(511, "Network Authentication Required", HttpStatusCategory.ServerError);
                
            
    }
}

