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
using gagvr = Google.Ads.GoogleAds.V17.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V17.Resources
{
    /// <summary>Resource name for the <c>AccessibleBiddingStrategy</c> resource.</summary>
    public sealed partial class AccessibleBiddingStrategyName : gax::IResourceName, sys::IEquatable<AccessibleBiddingStrategyName>
    {
        /// <summary>The possible contents of <see cref="AccessibleBiddingStrategyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}</c>.
            /// </summary>
            CustomerBiddingStrategy = 1,
        }

        private static gax::PathTemplate s_customerBiddingStrategy = new gax::PathTemplate("customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}");

        /// <summary>
        /// Creates a <see cref="AccessibleBiddingStrategyName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccessibleBiddingStrategyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccessibleBiddingStrategyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccessibleBiddingStrategyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccessibleBiddingStrategyName"/> with the pattern
        /// <c>customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="biddingStrategyId">The <c>BiddingStrategy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="AccessibleBiddingStrategyName"/> constructed from the provided ids.
        /// </returns>
        public static AccessibleBiddingStrategyName FromCustomerBiddingStrategy(string customerId, string biddingStrategyId) =>
            new AccessibleBiddingStrategyName(ResourceNameType.CustomerBiddingStrategy, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), biddingStrategyId: gax::GaxPreconditions.CheckNotNullOrEmpty(biddingStrategyId, nameof(biddingStrategyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessibleBiddingStrategyName"/> with
        /// pattern <c>customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="biddingStrategyId">The <c>BiddingStrategy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessibleBiddingStrategyName"/> with pattern
        /// <c>customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}</c>.
        /// </returns>
        public static string Format(string customerId, string biddingStrategyId) =>
            FormatCustomerBiddingStrategy(customerId, biddingStrategyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessibleBiddingStrategyName"/> with
        /// pattern <c>customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="biddingStrategyId">The <c>BiddingStrategy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessibleBiddingStrategyName"/> with pattern
        /// <c>customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}</c>.
        /// </returns>
        public static string FormatCustomerBiddingStrategy(string customerId, string biddingStrategyId) =>
            s_customerBiddingStrategy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(biddingStrategyId, nameof(biddingStrategyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccessibleBiddingStrategyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="accessibleBiddingStrategyName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="AccessibleBiddingStrategyName"/> if successful.</returns>
        public static AccessibleBiddingStrategyName Parse(string accessibleBiddingStrategyName) =>
            Parse(accessibleBiddingStrategyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccessibleBiddingStrategyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accessibleBiddingStrategyName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccessibleBiddingStrategyName"/> if successful.</returns>
        public static AccessibleBiddingStrategyName Parse(string accessibleBiddingStrategyName, bool allowUnparsed) =>
            TryParse(accessibleBiddingStrategyName, allowUnparsed, out AccessibleBiddingStrategyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccessibleBiddingStrategyName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="accessibleBiddingStrategyName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccessibleBiddingStrategyName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accessibleBiddingStrategyName, out AccessibleBiddingStrategyName result) =>
            TryParse(accessibleBiddingStrategyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccessibleBiddingStrategyName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accessibleBiddingStrategyName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccessibleBiddingStrategyName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accessibleBiddingStrategyName, bool allowUnparsed, out AccessibleBiddingStrategyName result)
        {
            gax::GaxPreconditions.CheckNotNull(accessibleBiddingStrategyName, nameof(accessibleBiddingStrategyName));
            gax::TemplatedResourceName resourceName;
            if (s_customerBiddingStrategy.TryParseName(accessibleBiddingStrategyName, out resourceName))
            {
                result = FromCustomerBiddingStrategy(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accessibleBiddingStrategyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccessibleBiddingStrategyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string biddingStrategyId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BiddingStrategyId = biddingStrategyId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccessibleBiddingStrategyName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="biddingStrategyId">The <c>BiddingStrategy</c> ID. Must not be <c>null</c> or empty.</param>
        public AccessibleBiddingStrategyName(string customerId, string biddingStrategyId) : this(ResourceNameType.CustomerBiddingStrategy, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), biddingStrategyId: gax::GaxPreconditions.CheckNotNullOrEmpty(biddingStrategyId, nameof(biddingStrategyId)))
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
        /// The <c>BiddingStrategy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string BiddingStrategyId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerBiddingStrategy: return s_customerBiddingStrategy.Expand(CustomerId, BiddingStrategyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccessibleBiddingStrategyName);

        /// <inheritdoc/>
        public bool Equals(AccessibleBiddingStrategyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AccessibleBiddingStrategyName a, AccessibleBiddingStrategyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AccessibleBiddingStrategyName a, AccessibleBiddingStrategyName b) => !(a == b);
    }

    public partial class AccessibleBiddingStrategy
    {
        /// <summary>
        /// <see cref="gagvr::AccessibleBiddingStrategyName"/>-typed view over the <see cref="ResourceName"/> resource
        /// name property.
        /// </summary>
        internal gagvr::AccessibleBiddingStrategyName ResourceNameAsAccessibleBiddingStrategyName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::AccessibleBiddingStrategyName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::AccessibleBiddingStrategyName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        internal gagvr::AccessibleBiddingStrategyName AccessibleBiddingStrategyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::AccessibleBiddingStrategyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
