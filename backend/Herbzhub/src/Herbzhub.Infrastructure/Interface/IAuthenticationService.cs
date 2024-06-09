using Herbzhub.Infrastructure.Helper;
using Herbzhub.Models.Request;
using Herbzhub.Models.Response;
using Microsoft.AspNetCore.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgotPasswordRequest = Herbzhub.Models.Request.ForgotPasswordRequest;

namespace Herbzhub.Infrastructure.Interface
{
    public interface IAuthenticationService
    {
        Task<BaseResponse<AuthResponses>> Login(AuthenticationRequest request);
        Task<BaseResponse<GenericNameResponse>> ForgotPassword(ForgotPasswordRequest request);
        Task<BaseResponse<GenericNameResponse>> ResetPassword(ResentPasswordRequest request);

        Task<BaseResponse<AuthResponses>> RefreshTokenService(UserRefreshTokenRequest request);
    }
}
