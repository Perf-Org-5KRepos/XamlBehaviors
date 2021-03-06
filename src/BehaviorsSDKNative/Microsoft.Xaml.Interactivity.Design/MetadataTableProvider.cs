﻿// Copyright (c) Microsoft. All rights reserved. 
// Licensed under the MIT license. See LICENSE file in the project root for full license information. 

using System.ComponentModel;

#if SurfaceIsolation
using Microsoft.VisualStudio.DesignTools.Extensibility;
using Microsoft.Xaml.Interactivity.Design.Properties;
using Microsoft.VisualStudio.DesignTools.Extensibility.Metadata;
#else
using Microsoft.Windows.Design;
using Microsoft.Windows.Design.Metadata;
using Microsoft.Xaml.Interactivity.Design.Properties;
#endif

[assembly: ProvideMetadata(typeof(Microsoft.Xaml.Interactivity.Design.MetadataTableProvider))]

// Please note that both the .Design and .DesignTools project
// use the same namespace: Microsoft.Xaml.Interactivity.Design
namespace Microsoft.Xaml.Interactivity.Design
{
    partial class MetadataTableProvider : IProvideAttributeTable
    {
        private AttributeTableBuilder attributeTableBuilder;

        public AttributeTable AttributeTable
        {
            get
            {
                if (attributeTableBuilder == null)
                {
                    attributeTableBuilder = new AttributeTableBuilder();
                }

                AddAttributes(Targets.ActionCollection, new CategoryAttribute(Resources.Category_Name_Actions));
                AddAttributes(Targets.BehaviorCollection, new ToolboxBrowsableAttribute(false));

                return attributeTableBuilder.CreateTable();
            }
        }
    }
}
