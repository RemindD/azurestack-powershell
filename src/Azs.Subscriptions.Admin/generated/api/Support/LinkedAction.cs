// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    /// <summary>The resource type linked action.</summary>
    public partial struct LinkedAction :
        System.IEquatable<LinkedAction>
    {
        /// <summary>The operation is blocked.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedAction Blocked = @"Blocked";

        /// <summary>The operation must be Enabled.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedAction Enabled = @"Enabled";

        /// <summary>The action is not specified.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedAction NotSpecified = @"NotSpecified";

        /// <summary>The operation must be validated.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedAction Validate = @"Validate";

        /// <summary>the value for an instance of the <see cref="LinkedAction" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to LinkedAction</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LinkedAction" />.</param>
        internal static object CreateFrom(object value)
        {
            return new LinkedAction(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type LinkedAction</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedAction e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type LinkedAction (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is LinkedAction && Equals((LinkedAction)obj);
        }

        /// <summary>Returns hashCode for enum LinkedAction</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="LinkedAction" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private LinkedAction(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for LinkedAction</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to LinkedAction</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LinkedAction" />.</param>

        public static implicit operator LinkedAction(string value)
        {
            return new LinkedAction(value);
        }

        /// <summary>Implicit operator to convert LinkedAction to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="LinkedAction" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedAction e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum LinkedAction</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedAction e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedAction e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum LinkedAction</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedAction e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.LinkedAction e2)
        {
            return e2.Equals(e1);
        }
    }
}