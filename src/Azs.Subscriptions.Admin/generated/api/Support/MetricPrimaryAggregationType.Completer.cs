// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    /// <summary>The primary aggregation type for resource metric.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationTypeTypeConverter))]
    public partial struct MetricPrimaryAggregationType :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "None".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("None", "None", global::System.Management.Automation.CompletionResultType.ParameterValue, "None");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Average".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Average", "Average", global::System.Management.Automation.CompletionResultType.ParameterValue, "Average");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Total".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Total", "Total", global::System.Management.Automation.CompletionResultType.ParameterValue, "Total");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Minimum".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Minimum", "Minimum", global::System.Management.Automation.CompletionResultType.ParameterValue, "Minimum");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Maximum".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Maximum", "Maximum", global::System.Management.Automation.CompletionResultType.ParameterValue, "Maximum");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Last".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Last", "Last", global::System.Management.Automation.CompletionResultType.ParameterValue, "Last");
            }
        }
    }
}