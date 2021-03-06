﻿// Copyright (c) 2018 Jarred Capellman
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Threading.Tasks;

using Defcon2.lib.DAL.Base;
using Defcon2.lib.PlatformInterfaces;

using Newtonsoft.Json;

using Xamarin.Forms;

namespace Defcon2.lib.DAL
{
    public class JSONDAL : BaseDAL
    {
        public override async Task<T> GetDataAsync<T>(string resourceName)
        {
            if (string.IsNullOrEmpty(resourceName))
            {
                throw new ArgumentNullException();
            }

            var textString = await DependencyService.Get<IFile>().ReadTextFileAsync(resourceName);

            return JsonConvert.DeserializeObject<T>(textString);
        }

        public override async Task<bool> SetDataAsync<T>(T data, string resourceName)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (string.IsNullOrEmpty(resourceName))
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            return await DependencyService.Get<IFile>()
                .WriteTextFileAsync(resourceName, JsonConvert.SerializeObject(data));
        }
    }
}