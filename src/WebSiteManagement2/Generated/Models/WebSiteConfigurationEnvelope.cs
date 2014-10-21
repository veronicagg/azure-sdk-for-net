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
using Microsoft.Azure.Management.WebSites.Models;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary>
    /// Configuration for the website.
    /// </summary>
    public partial class WebSiteConfigurationEnvelope : ResourceBase
    {
        private WebSiteGetConfigurationResponse _properties;
        
        /// <summary>
        /// Optional. Configuration for a web site.
        /// </summary>
        public WebSiteGetConfigurationResponse Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebSiteConfigurationEnvelope
        /// class.
        /// </summary>
        public WebSiteConfigurationEnvelope()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the WebSiteConfigurationEnvelope
        /// class with required arguments.
        /// </summary>
        public WebSiteConfigurationEnvelope(string location)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.Location = location;
        }
    }
}