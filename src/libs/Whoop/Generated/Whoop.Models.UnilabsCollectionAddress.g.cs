
#nullable enable

namespace Whoop
{
    /// <summary>
    /// The collection address for this appointment
    /// </summary>
    public sealed partial class UnilabsCollectionAddress
    {
        /// <summary>
        /// Building name or number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("building")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Building { get; set; }

        /// <summary>
        /// Area or district
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("area")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Area { get; set; }

        /// <summary>
        /// Emirate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emirate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Emirate { get; set; }

        /// <summary>
        /// Nearby landmark
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("landmark")]
        public string? Landmark { get; set; }

        /// <summary>
        /// Flat or apartment number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flat_no")]
        public string? FlatNo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnilabsCollectionAddress" /> class.
        /// </summary>
        /// <param name="building">
        /// Building name or number
        /// </param>
        /// <param name="area">
        /// Area or district
        /// </param>
        /// <param name="emirate">
        /// Emirate
        /// </param>
        /// <param name="landmark">
        /// Nearby landmark
        /// </param>
        /// <param name="flatNo">
        /// Flat or apartment number
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnilabsCollectionAddress(
            string building,
            string area,
            string emirate,
            string? landmark,
            string? flatNo)
        {
            this.Building = building ?? throw new global::System.ArgumentNullException(nameof(building));
            this.Area = area ?? throw new global::System.ArgumentNullException(nameof(area));
            this.Emirate = emirate ?? throw new global::System.ArgumentNullException(nameof(emirate));
            this.Landmark = landmark;
            this.FlatNo = flatNo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnilabsCollectionAddress" /> class.
        /// </summary>
        public UnilabsCollectionAddress()
        {
        }

    }
}