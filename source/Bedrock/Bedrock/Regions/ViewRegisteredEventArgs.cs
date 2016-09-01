// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using Bedrock.Views;

namespace Bedrock.Regions
{
    /// <summary>
    /// Argument class used by the <see cref="IRegionViewRegistry.ContentRegistered"/> event when a new content is registered.
    /// </summary>
    public class ViewRegisteredEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes the ViewRegisteredEventArgs class.
        /// </summary>
        /// <param name="regionName">The region name to which the content was registered.</param>
        /// <param name="getViewDelegate">The content which was registered.</param>
        public ViewRegisteredEventArgs(string regionName, Func<IView> getViewDelegate)
        {
            this.GetView = getViewDelegate;
            this.RegionName = regionName;
        }

        /// <summary>
        /// Gets the region name to which the content was registered.
        /// </summary>
        public string RegionName { get; private set; }

        /// <summary>
        /// Gets the content which was registered.
        /// </summary>
        public Func<IView> GetView { get; private set; }
    }
}
