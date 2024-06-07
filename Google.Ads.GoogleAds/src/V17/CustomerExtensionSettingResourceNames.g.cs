// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V17.Resources
{
    /// <summary>Resource name for the <c>CustomerExtensionSetting</c> resource.</summary>
    public sealed partial class CustomerExtensionSettingName : gax::IResourceName, sys::IEquatable<CustomerExtensionSettingName>
    {
        /// <summary>The possible contents of <see cref="CustomerExtensionSettingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/customerExtensionSettings/{extension_type}</c>.
            /// </summary>
            CustomerExtensionType = 1,
        }

        private static gax::PathTemplate s_customerExtensionType = new gax::PathTemplate("customers/{customer_id}/customerExtensionSettings/{extension_type}");

        /// <summary>
        /// Creates a <see cref="CustomerExtensionSettingName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerExtensionSettingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomerExtensionSettingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerExtensionSettingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerExtensionSettingName"/> with the pattern
        /// <c>customers/{customer_id}/customerExtensionSettings/{extension_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionTypeId">The <c>ExtensionType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerExtensionSettingName"/> constructed from the provided ids.
        /// </returns>
        public static CustomerExtensionSettingName FromCustomerExtensionType(string customerId, string extensionTypeId) =>
            new CustomerExtensionSettingName(ResourceNameType.CustomerExtensionType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), extensionTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(extensionTypeId, nameof(extensionTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerExtensionSettingName"/> with
        /// pattern <c>customers/{customer_id}/customerExtensionSettings/{extension_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionTypeId">The <c>ExtensionType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerExtensionSettingName"/> with pattern
        /// <c>customers/{customer_id}/customerExtensionSettings/{extension_type}</c>.
        /// </returns>
        public static string Format(string customerId, string extensionTypeId) =>
            FormatCustomerExtensionType(customerId, extensionTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerExtensionSettingName"/> with
        /// pattern <c>customers/{customer_id}/customerExtensionSettings/{extension_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionTypeId">The <c>ExtensionType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerExtensionSettingName"/> with pattern
        /// <c>customers/{customer_id}/customerExtensionSettings/{extension_type}</c>.
        /// </returns>
        public static string FormatCustomerExtensionType(string customerId, string extensionTypeId) =>
            s_customerExtensionType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(extensionTypeId, nameof(extensionTypeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerExtensionSettingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerExtensionSettings/{extension_type}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerExtensionSettingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="CustomerExtensionSettingName"/> if successful.</returns>
        public static CustomerExtensionSettingName Parse(string customerExtensionSettingName) =>
            Parse(customerExtensionSettingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerExtensionSettingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerExtensionSettings/{extension_type}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerExtensionSettingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerExtensionSettingName"/> if successful.</returns>
        public static CustomerExtensionSettingName Parse(string customerExtensionSettingName, bool allowUnparsed) =>
            TryParse(customerExtensionSettingName, allowUnparsed, out CustomerExtensionSettingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerExtensionSettingName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerExtensionSettings/{extension_type}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerExtensionSettingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerExtensionSettingName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerExtensionSettingName, out CustomerExtensionSettingName result) =>
            TryParse(customerExtensionSettingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerExtensionSettingName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerExtensionSettings/{extension_type}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerExtensionSettingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerExtensionSettingName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerExtensionSettingName, bool allowUnparsed, out CustomerExtensionSettingName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerExtensionSettingName, nameof(customerExtensionSettingName));
            gax::TemplatedResourceName resourceName;
            if (s_customerExtensionType.TryParseName(customerExtensionSettingName, out resourceName))
            {
                result = FromCustomerExtensionType(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerExtensionSettingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomerExtensionSettingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string extensionTypeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            ExtensionTypeId = extensionTypeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerExtensionSettingName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/customerExtensionSettings/{extension_type}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionTypeId">The <c>ExtensionType</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomerExtensionSettingName(string customerId, string extensionTypeId) : this(ResourceNameType.CustomerExtensionType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), extensionTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(extensionTypeId, nameof(extensionTypeId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>ExtensionType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ExtensionTypeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerExtensionType: return s_customerExtensionType.Expand(CustomerId, ExtensionTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerExtensionSettingName);

        /// <inheritdoc/>
        public bool Equals(CustomerExtensionSettingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CustomerExtensionSettingName a, CustomerExtensionSettingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CustomerExtensionSettingName a, CustomerExtensionSettingName b) => !(a == b);
    }

    public partial class CustomerExtensionSetting
    {
        /// <summary>
        /// <see cref="CustomerExtensionSettingName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal CustomerExtensionSettingName ResourceNameAsCustomerExtensionSettingName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CustomerExtensionSettingName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ExtensionFeedItemName"/>-typed view over the <see cref="ExtensionFeedItems"/> resource name
        /// property.
        /// </summary>
        internal gax::ResourceNameList<ExtensionFeedItemName> ExtensionFeedItemsAsExtensionFeedItemNames
        {
            get => new gax::ResourceNameList<ExtensionFeedItemName>(ExtensionFeedItems, s => string.IsNullOrEmpty(s) ? null : ExtensionFeedItemName.Parse(s, allowUnparsed: true));
        }
    }
}
