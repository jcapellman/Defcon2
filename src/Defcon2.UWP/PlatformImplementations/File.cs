// Copyright (c) 2018 Jarred Capellman
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

using Defcon2.lib.PlatformInterfaces;

namespace Defcon2.UWP.PlatformImplementations
{
    public class File : IFile
    {
        private readonly Windows.Storage.StorageFolder _storageFolder = Windows.Storage.ApplicationData.Current.RoamingFolder;

        public async Task<string> ReadTextFileAsync(string resourceName)
        {
            var file = await _storageFolder.GetFileAsync(resourceName);

            return await Windows.Storage.FileIO.ReadTextAsync(file);
        }

        public async Task<bool> WriteTextFileAsync(string resourceName, string dataString)
        {
            var file = await _storageFolder.CreateFileAsync(resourceName);

            await Windows.Storage.FileIO.WriteTextAsync(file, dataString);

            return true;
        }
    }
}