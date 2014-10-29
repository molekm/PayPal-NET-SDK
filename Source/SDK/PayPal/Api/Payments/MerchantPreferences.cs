using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PayPal.Api.Validation;

namespace PayPal.Api.Payments
{
    public class MerchantPreferences
    {
        /// <summary>
        /// Identifier of the merchant_preferences. 128 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string id { get; set; }

        /// <summary>
        /// Setup fee amount. Default is 0.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "setup_fee")]
        public Currency setup_fee { get; set; }

        /// <summary>
        /// Redirect URL on cancellation of agreement request. 1000 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cancel_url")]
        public string cancel_url { get; set; }

        /// <summary>
        /// Redirect URL on creation of agreement request. 1000 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "return_url")]
        public string return_url { get; set; }

        /// <summary>
        /// Notify URL on agreement creation. 1000 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notify_url")]
        public string notify_url { get; set; }

        /// <summary>
        /// Total number of failed attempts allowed. Default is 0, representing an infinite number of failed attempts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "max_fail_attempts")]
        public string max_fail_attempts { get; set; }

        /// <summary>
        /// Allow auto billing for the outstanding amount of the agreement in the next cycle. Allowed values: `YES`, `NO`. Default is `NO`.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "auto_bill_amount")]
        public string auto_bill_amount { get; set; }

        /// <summary>
        /// Action to take if a failure occurs during initial payment. Allowed values: `CONTINUE`, `CANCEL`. Default is continue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "initial_fail_amount_action")]
        public string initial_fail_amount_action { get; set; }

        /// <summary>
        /// Payment types that are accepted for this plan.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accepted_payment_type")]
        public string accepted_payment_type { get; set; }

        /// <summary>
        /// char_set for this plan.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "char_set")]
        public string char_set { get; set; }

        /// <summary>
        /// Converts the object to JSON string
        /// </summary>
        public virtual string ConvertToJson()
        {
            return JsonFormatter.ConvertToJson(this);
        }
    }
}
