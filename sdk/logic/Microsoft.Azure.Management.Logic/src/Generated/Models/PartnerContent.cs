// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The integration account partner content.
    /// </summary>
    public partial class PartnerContent
    {
        /// <summary>
        /// Initializes a new instance of the PartnerContent class.
        /// </summary>
        public PartnerContent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PartnerContent class.
        /// </summary>
        /// <param name="b2b">The B2B partner content.</param>
        public PartnerContent(B2BPartnerContent b2b = default(B2BPartnerContent))
        {
            B2b = b2b;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the B2B partner content.
        /// </summary>
        [JsonProperty(PropertyName = "b2b")]
        public B2BPartnerContent B2b { get; set; }

    }
}