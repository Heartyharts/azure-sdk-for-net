// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ProtectionPolicyOperationResultsOperations.
    /// </summary>
    public static partial class ProtectionPolicyOperationResultsOperationsExtensions
    {
            /// <summary>
            /// Provides the result of an operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='policyName'>
            /// Backup policy name whose operation's result needs to be fetched.
            /// </param>
            /// <param name='operationId'>
            /// Operation ID which represents the operation whose result needs to be
            /// fetched.
            /// </param>
            public static ProtectionPolicyResource Get(this IProtectionPolicyOperationResultsOperations operations, string vaultName, string resourceGroupName, string policyName, string operationId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectionPolicyOperationResultsOperations)s).GetAsync(vaultName, resourceGroupName, policyName, operationId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provides the result of an operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='policyName'>
            /// Backup policy name whose operation's result needs to be fetched.
            /// </param>
            /// <param name='operationId'>
            /// Operation ID which represents the operation whose result needs to be
            /// fetched.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ProtectionPolicyResource> GetAsync(this IProtectionPolicyOperationResultsOperations operations, string vaultName, string resourceGroupName, string policyName, string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(vaultName, resourceGroupName, policyName, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
