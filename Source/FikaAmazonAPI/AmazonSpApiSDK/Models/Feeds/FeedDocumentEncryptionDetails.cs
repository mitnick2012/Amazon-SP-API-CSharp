/* 
 * Selling Partner API for Feeds
 *
 * The Selling Partner API for Feeds lets you upload data to Amazon on behalf of a selling partner.
 *
 * OpenAPI spec version: 2020-09-04
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Feeds
{
    /// <summary>
    /// Encryption details for required client-side encryption and decryption of document contents.
    /// </summary>
    [DataContract]
    public partial class FeedDocumentEncryptionDetails : IEquatable<FeedDocumentEncryptionDetails>, IValidatableObject
    {
        /// <summary>
        /// The encryption standard required to encrypt or decrypt the document contents.
        /// </summary>
        /// <value>The encryption standard required to encrypt or decrypt the document contents.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StandardEnum
        {

            /// <summary>
            /// Enum AES for value: AES
            /// </summary>
            [EnumMember(Value = "AES")]
            AES = 1
        }

        /// <summary>
        /// The encryption standard required to encrypt or decrypt the document contents.
        /// </summary>
        /// <value>The encryption standard required to encrypt or decrypt the document contents.</value>
        [DataMember(Name = "standard", EmitDefaultValue = false)]
        public StandardEnum Standard { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedDocumentEncryptionDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeedDocumentEncryptionDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedDocumentEncryptionDetails" /> class.
        /// </summary>
        /// <param name="Standard">The encryption standard required to encrypt or decrypt the document contents. (required).</param>
        /// <param name="InitializationVector">The vector to encrypt or decrypt the document contents using Cipher Block Chaining (CBC). (required).</param>
        /// <param name="Key">The encryption key used to encrypt or decrypt the document contents. (required).</param>
        public FeedDocumentEncryptionDetails(StandardEnum Standard = default(StandardEnum), string InitializationVector = default(string), string Key = default(string))
        {
            // to ensure "Standard" is required (not null)
            if (Standard == null)
            {
                throw new InvalidDataException("Standard is a required property for FeedDocumentEncryptionDetails and cannot be null");
            }
            else
            {
                this.Standard = Standard;
            }
            // to ensure "InitializationVector" is required (not null)
            if (InitializationVector == null)
            {
                throw new InvalidDataException("InitializationVector is a required property for FeedDocumentEncryptionDetails and cannot be null");
            }
            else
            {
                this.InitializationVector = InitializationVector;
            }
            // to ensure "Key" is required (not null)
            if (Key == null)
            {
                throw new InvalidDataException("Key is a required property for FeedDocumentEncryptionDetails and cannot be null");
            }
            else
            {
                this.Key = Key;
            }
        }


        /// <summary>
        /// The vector to encrypt or decrypt the document contents using Cipher Block Chaining (CBC).
        /// </summary>
        /// <value>The vector to encrypt or decrypt the document contents using Cipher Block Chaining (CBC).</value>
        [DataMember(Name = "initializationVector", EmitDefaultValue = false)]
        public string InitializationVector { get; set; }

        /// <summary>
        /// The encryption key used to encrypt or decrypt the document contents.
        /// </summary>
        /// <value>The encryption key used to encrypt or decrypt the document contents.</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeedDocumentEncryptionDetails {\n");
            sb.Append("  Standard: ").Append(Standard).Append("\n");
            sb.Append("  InitializationVector: ").Append(InitializationVector).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as FeedDocumentEncryptionDetails);
        }

        /// <summary>
        /// Returns true if FeedDocumentEncryptionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of FeedDocumentEncryptionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeedDocumentEncryptionDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Standard == input.Standard ||
                    (this.Standard != null &&
                    this.Standard.Equals(input.Standard))
                ) &&
                (
                    this.InitializationVector == input.InitializationVector ||
                    (this.InitializationVector != null &&
                    this.InitializationVector.Equals(input.InitializationVector))
                ) &&
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.Standard != null)
                    hashCode = hashCode * 59 + this.Standard.GetHashCode();
                if (this.InitializationVector != null)
                    hashCode = hashCode * 59 + this.InitializationVector.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
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