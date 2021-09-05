/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// ListReturnReasonCodesResult
    /// </summary>
    [DataContract]
    public partial class ListReturnReasonCodesResult : IEquatable<ListReturnReasonCodesResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListReturnReasonCodesResult" /> class.
        /// </summary>
        /// <param name="ReasonCodeDetailsList">ReasonCodeDetailsList.</param>
        public ListReturnReasonCodesResult(ReasonCodeDetailsList ReasonCodeDetailsList = default(ReasonCodeDetailsList))
        {
            this.ReasonCodeDetailsList = ReasonCodeDetailsList;
        }

        /// <summary>
        /// Gets or Sets ReasonCodeDetailsList
        /// </summary>
        [DataMember(Name = "ReasonCodeDetailsList", EmitDefaultValue = false)]
        public ReasonCodeDetailsList ReasonCodeDetailsList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListReturnReasonCodesResult {\n");
            sb.Append("  ReasonCodeDetailsList: ").Append(ReasonCodeDetailsList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListReturnReasonCodesResult);
        }

        /// <summary>
        /// Returns true if ListReturnReasonCodesResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ListReturnReasonCodesResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListReturnReasonCodesResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ReasonCodeDetailsList == input.ReasonCodeDetailsList ||
                    (this.ReasonCodeDetailsList != null &&
                    this.ReasonCodeDetailsList.Equals(input.ReasonCodeDetailsList))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ReasonCodeDetailsList != null)
                    hashCode = hashCode * 59 + this.ReasonCodeDetailsList.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}