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
using Microsoft.WindowsAzure.Scheduler.Models;

namespace Microsoft.WindowsAzure.Scheduler
{
    public partial interface IJobOperations
    {
        /// <summary>
        /// Creates a new Job, allowing the service to generate a job id. Use
        /// CreateOrUpdate if a user-chosen job id is required.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters specifying the job definition for a Create Job operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Create Job operation response.
        /// </returns>
        Task<JobCreateResponse> CreateAsync(JobCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a new Job with a user-provided job id, or updates an
        /// existing job, replacing its definition with that specified.
        /// </summary>
        /// <param name='jobId'>
        /// Id of the job to create or update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters specifying the job definition for a CreateOrUpdate Job
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate Job operation response.
        /// </returns>
        Task<JobCreateOrUpdateResponse> CreateOrUpdateAsync(string jobId, JobCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name='jobId'>
        /// Id of the job to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> DeleteAsync(string jobId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the definition and status of a job.
        /// </summary>
        /// <param name='jobId'>
        /// Id of the job to get.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Job operation response.
        /// </returns>
        Task<JobGetResponse> GetAsync(string jobId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the execution history of a Job.
        /// </summary>
        /// <param name='jobId'>
        /// Id of the job to get the history of.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Get Job History operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Job History operation response.
        /// </returns>
        Task<JobGetHistoryResponse> GetHistoryAsync(string jobId, JobGetHistoryParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the execution history of a Job with a filter on the job Status.
        /// </summary>
        /// <param name='jobId'>
        /// Id of the job to get the history of.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Get Job History With Filter operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Job History operation response.
        /// </returns>
        Task<JobGetHistoryResponse> GetHistoryWithFilterAsync(string jobId, JobGetHistoryWithFilterParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list of all jobs in a job collection.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the List Jobs operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Jobs operation response.
        /// </returns>
        Task<JobListResponse> ListAsync(JobListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list of jobs in a job collection matching a filter on job
        /// state.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the List Jobs with filter operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Jobs operation response.
        /// </returns>
        Task<JobListResponse> ListWithFilterAsync(JobListWithFilterParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Update the state of all jobs in a job collections.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Jobs State operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Update Jobs State operation response.
        /// </returns>
        Task<JobCollectionJobsUpdateStateResponse> UpdateJobCollectionStateAsync(PatchJobCollectionJobsUpdateStateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Update the state of a job.
        /// </summary>
        /// <param name='jobId'>
        /// Id of the job to update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Job State operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Update Job State operation response.
        /// </returns>
        Task<JobUpdateStateResponse> UpdateStateAsync(string jobId, JobUpdateStateParameters parameters, CancellationToken cancellationToken);
    }
}
