﻿using Core.Security.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.Extensions
{
    public static class CustomValidationResponseExtension
    {
        public static void AddCustomValidationResponseService(this IServiceCollection serviceCollection)
        {
            serviceCollection.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = context =>
                {
                    var errors = context.ModelState.Values.Where(c => c.Errors.Count > 0).SelectMany(c => c.Errors).Select(e => e.ErrorMessage).ToList();

                    var response = ResponseDto<ErrorDto>.Fail(new ErrorDto(errors, true), 400);

                    return new BadRequestObjectResult(response);
                };
            });
        }
    }
}
