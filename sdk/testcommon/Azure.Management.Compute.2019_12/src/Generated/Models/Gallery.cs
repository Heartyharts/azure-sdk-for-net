// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.Compute.Models
{
    /// <summary> Specifies information about the Shared Image Gallery that you want to create or update. </summary>
    public partial class Gallery : Resource
    {
        /// <summary> Initializes a new instance of Gallery. </summary>
        /// <param name="location"> Resource location. </param>
        public Gallery(string location) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
        }

        /// <summary> Initializes a new instance of Gallery. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="description"> The description of this Shared Image Gallery resource. This property is updatable. </param>
        /// <param name="identifier"> Describes the gallery unique name. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        internal Gallery(string id, string name, string type, string location, IDictionary<string, string> tags, string description, GalleryIdentifier identifier, GalleryPropertiesProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Description = description;
            Identifier = identifier;
            ProvisioningState = provisioningState;
        }

        /// <summary> The description of this Shared Image Gallery resource. This property is updatable. </summary>
        public string Description { get; set; }
        /// <summary> Describes the gallery unique name. </summary>
        public GalleryIdentifier Identifier { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryPropertiesProvisioningState? ProvisioningState { get; }
    }
}
