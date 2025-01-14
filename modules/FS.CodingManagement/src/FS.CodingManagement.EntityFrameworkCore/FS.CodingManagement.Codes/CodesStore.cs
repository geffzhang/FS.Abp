﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace FS.CodingManagement.Codes
{
    public partial class CodesStore : DomainService, ICodesStore
    {
        public async Task<T> GetCodeValueAsync<T>(string codeNo)
        {
            try
            {
                var result = await this.Coding.FindByNoAsync(codeNo);
                var methodInfo = FS.Abp.Shared.TypeHelper.GetConverMethod(Type.GetTypeCode(typeof(T)));
                return (T)methodInfo.Invoke(null, new[] { result.Value });
            }
            catch
            {
                return default(T);
            }
        }
        public async Task SetCodeValueAsync<T>(string codeNo, T value)
        {
            var code = await this.Coding.FindByNoAsync(codeNo);
            code.Value = value.ToString();

            await this.Coding.UpdateAsync(code);
        }
    }
}
