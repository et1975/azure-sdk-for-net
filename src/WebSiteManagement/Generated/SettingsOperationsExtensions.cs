// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.WebSitesExtensions;
using Microsoft.WindowsAzure.WebSitesExtensions.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The websites extensions client manages the web sites deployments, web
    /// jobs and other extensions.
    /// </summary>
    public static partial class SettingsOperationsExtensions
    {
        /// <summary>
        /// Gets a setting.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ISettingsOperations.
        /// </param>
        /// <param name='settingId'>
        /// The setting identifier.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this ISettingsOperations operations, string settingId)
        {
            try
            {
                return operations.DeleteAsync(settingId).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Gets a setting.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ISettingsOperations.
        /// </param>
        /// <param name='settingId'>
        /// The setting identifier.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this ISettingsOperations operations, string settingId)
        {
            return operations.DeleteAsync(settingId, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a setting.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ISettingsOperations.
        /// </param>
        /// <param name='settingId'>
        /// The setting identifier.
        /// </param>
        /// <returns>
        /// The get setting operation response.
        /// </returns>
        public static SettingsGetResponse Get(this ISettingsOperations operations, string settingId)
        {
            try
            {
                return operations.GetAsync(settingId).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Gets a setting.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ISettingsOperations.
        /// </param>
        /// <param name='settingId'>
        /// The setting identifier.
        /// </param>
        /// <returns>
        /// The get setting operation response.
        /// </returns>
        public static Task<SettingsGetResponse> GetAsync(this ISettingsOperations operations, string settingId)
        {
            return operations.GetAsync(settingId, CancellationToken.None);
        }
        
        /// <summary>
        /// Lists the settings.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ISettingsOperations.
        /// </param>
        /// <returns>
        /// The list settings operation response.
        /// </returns>
        public static SettingsListResponse List(this ISettingsOperations operations)
        {
            try
            {
                return operations.ListAsync().Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Lists the settings.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ISettingsOperations.
        /// </param>
        /// <returns>
        /// The list settings operation response.
        /// </returns>
        public static Task<SettingsListResponse> ListAsync(this ISettingsOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Updates a setting.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ISettingsOperations.
        /// </param>
        /// <param name='parameters'>
        /// The setting value.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Update(this ISettingsOperations operations, SettingsUpdateParameters parameters)
        {
            try
            {
                return operations.UpdateAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Updates a setting.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.ISettingsOperations.
        /// </param>
        /// <param name='parameters'>
        /// The setting value.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> UpdateAsync(this ISettingsOperations operations, SettingsUpdateParameters parameters)
        {
            return operations.UpdateAsync(parameters, CancellationToken.None);
        }
    }
}
