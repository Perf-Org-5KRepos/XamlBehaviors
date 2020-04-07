﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.UI.Xaml;

namespace Microsoft.Xaml.Interactivity
{
    /// <summary>
    /// Interface implemented by all custom behaviors.
    /// </summary>
    public interface IBehavior
    {
        /// <summary>
        /// Gets the <see cref="Microsoft.UI.Xaml.DependencyObject"/> to which the <seealso cref="IBehavior"/> is attached.
        /// </summary>
        DependencyObject AssociatedObject
        {
            get;
        }

        /// <summary>
        /// Attaches to the specified object.
        /// </summary>
        /// <param name="associatedObject">The <see cref="Microsoft.UI.Xaml.DependencyObject"/> to which the <seealso cref="IBehavior"/> will be attached.</param>
        void Attach(DependencyObject associatedObject);

        /// <summary>
        /// Detaches this instance from its associated object.
        /// </summary>
        void Detach();
    }
}
