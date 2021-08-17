// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Support
{

    /// <summary>The unit of the metric.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Support.MetricsUnitTypeConverter))]
    public partial struct MetricsUnit :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "One".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("One", "One", global::System.Management.Automation.CompletionResultType.ParameterValue, "One");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Percentage".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Percentage", "Percentage", global::System.Management.Automation.CompletionResultType.ParameterValue, "Percentage");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "B".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("B", "B", global::System.Management.Automation.CompletionResultType.ParameterValue, "B");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "KB".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("KB", "KB", global::System.Management.Automation.CompletionResultType.ParameterValue, "KB");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "MB".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("MB", "MB", global::System.Management.Automation.CompletionResultType.ParameterValue, "MB");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "GB".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("GB", "GB", global::System.Management.Automation.CompletionResultType.ParameterValue, "GB");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "TB".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("TB", "TB", global::System.Management.Automation.CompletionResultType.ParameterValue, "TB");
            }
        }
    }
}