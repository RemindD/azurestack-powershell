// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    /// <summary>The resource provider type.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderTypeTypeConverter))]
    public partial struct ResourceProviderType :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "NotSpecified".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("NotSpecified", "NotSpecified", global::System.Management.Automation.CompletionResultType.ParameterValue, "NotSpecified");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Internal".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Internal", "Internal", global::System.Management.Automation.CompletionResultType.ParameterValue, "Internal");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "External".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("External", "External", global::System.Management.Automation.CompletionResultType.ParameterValue, "External");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "RegistrationFree".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("RegistrationFree", "RegistrationFree", global::System.Management.Automation.CompletionResultType.ParameterValue, "RegistrationFree");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "TenantOnly".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("TenantOnly", "TenantOnly", global::System.Management.Automation.CompletionResultType.ParameterValue, "TenantOnly");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AlwaysRoutable".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("AlwaysRoutable", "AlwaysRoutable", global::System.Management.Automation.CompletionResultType.ParameterValue, "AlwaysRoutable");
            }
        }
    }
}