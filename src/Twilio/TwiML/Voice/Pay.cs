/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Twilio.Converters;
using Twilio.Types;

namespace Twilio.TwiML.Voice 
{

    /// <summary>
    /// Pay Twiml Verb
    /// </summary>
    public class Pay : TwiML 
    {
        public sealed class InputEnum : StringEnum 
        {
            private InputEnum(string value) : base(value) {}
            public InputEnum() {}
            public static implicit operator InputEnum(string value)
            {
                return new InputEnum(value);
            }

            public static readonly InputEnum Dtmf = new InputEnum("dtmf");
        }

        public sealed class StatusCallbackMethodEnum : StringEnum 
        {
            private StatusCallbackMethodEnum(string value) : base(value) {}
            public StatusCallbackMethodEnum() {}
            public static implicit operator StatusCallbackMethodEnum(string value)
            {
                return new StatusCallbackMethodEnum(value);
            }

            public static readonly StatusCallbackMethodEnum Get = new StatusCallbackMethodEnum("GET");
            public static readonly StatusCallbackMethodEnum Post = new StatusCallbackMethodEnum("POST");
        }

        public sealed class TokenTypeEnum : StringEnum 
        {
            private TokenTypeEnum(string value) : base(value) {}
            public TokenTypeEnum() {}
            public static implicit operator TokenTypeEnum(string value)
            {
                return new TokenTypeEnum(value);
            }

            public static readonly TokenTypeEnum OneTime = new TokenTypeEnum("one-time");
            public static readonly TokenTypeEnum Reusable = new TokenTypeEnum("reusable");
        }

        public sealed class CurrencyEnum : StringEnum 
        {
            private CurrencyEnum(string value) : base(value) {}
            public CurrencyEnum() {}
            public static implicit operator CurrencyEnum(string value)
            {
                return new CurrencyEnum(value);
            }

            public static readonly CurrencyEnum Usd = new CurrencyEnum("usd");
            public static readonly CurrencyEnum Eur = new CurrencyEnum("eur");
            public static readonly CurrencyEnum Gbp = new CurrencyEnum("gbp");
        }

        public sealed class ValidCardTypesEnum : StringEnum 
        {
            private ValidCardTypesEnum(string value) : base(value) {}
            public ValidCardTypesEnum() {}
            public static implicit operator ValidCardTypesEnum(string value)
            {
                return new ValidCardTypesEnum(value);
            }

            public static readonly ValidCardTypesEnum Visa = new ValidCardTypesEnum("visa");
            public static readonly ValidCardTypesEnum Mastercard = new ValidCardTypesEnum("mastercard");
            public static readonly ValidCardTypesEnum Amex = new ValidCardTypesEnum("amex");
            public static readonly ValidCardTypesEnum Maestro = new ValidCardTypesEnum("maestro");
            public static readonly ValidCardTypesEnum Discover = new ValidCardTypesEnum("discover");
            public static readonly ValidCardTypesEnum Optima = new ValidCardTypesEnum("optima");
            public static readonly ValidCardTypesEnum Jcb = new ValidCardTypesEnum("jcb");
            public static readonly ValidCardTypesEnum DinersClub = new ValidCardTypesEnum("diners-club");
            public static readonly ValidCardTypesEnum Enroute = new ValidCardTypesEnum("enroute");
        }

        public sealed class LanguageEnum : StringEnum 
        {
            private LanguageEnum(string value) : base(value) {}
            public LanguageEnum() {}
            public static implicit operator LanguageEnum(string value)
            {
                return new LanguageEnum(value);
            }

            public static readonly LanguageEnum DeDe = new LanguageEnum("de-DE");
            public static readonly LanguageEnum EnAu = new LanguageEnum("en-AU");
            public static readonly LanguageEnum EnCa = new LanguageEnum("en-CA");
            public static readonly LanguageEnum EnGb = new LanguageEnum("en-GB");
            public static readonly LanguageEnum EnIn = new LanguageEnum("en-IN");
            public static readonly LanguageEnum EnIe = new LanguageEnum("en-IE");
            public static readonly LanguageEnum EnNz = new LanguageEnum("en-NZ");
            public static readonly LanguageEnum EnPh = new LanguageEnum("en-PH");
            public static readonly LanguageEnum EnZa = new LanguageEnum("en-ZA");
            public static readonly LanguageEnum EnUs = new LanguageEnum("en-US");
            public static readonly LanguageEnum EsEs = new LanguageEnum("es-ES");
            public static readonly LanguageEnum EsUs = new LanguageEnum("es-US");
            public static readonly LanguageEnum FrCa = new LanguageEnum("fr-CA");
            public static readonly LanguageEnum FrFr = new LanguageEnum("fr-FR");
            public static readonly LanguageEnum ItIt = new LanguageEnum("it-IT");
        }

        /// <summary>
        /// Input type Twilio should accept
        /// </summary>
        public Pay.InputEnum Input { get; set; }
        /// <summary>
        /// Action URL
        /// </summary>
        public Uri Action { get; set; }
        /// <summary>
        /// Status callback URL
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// Status callback method
        /// </summary>
        public Pay.StatusCallbackMethodEnum StatusCallbackMethod { get; set; }
        /// <summary>
        /// Time to wait to gather input
        /// </summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// Maximum number of allowed retries when gathering input
        /// </summary>
        public int? MaxAttempts { get; set; }
        /// <summary>
        /// Prompt for security code
        /// </summary>
        public bool? SecurityCode { get; set; }
        /// <summary>
        /// Prompt for postal code and it should be true/false or default postal code
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// Unique name for payment connector
        /// </summary>
        public string PaymentConnector { get; set; }
        /// <summary>
        /// Type of token
        /// </summary>
        public Pay.TokenTypeEnum TokenType { get; set; }
        /// <summary>
        /// Amount to process. If value is greater than 0 then make the payment else create a payment token
        /// </summary>
        public string ChargeAmount { get; set; }
        /// <summary>
        /// Currency of the amount attribute
        /// </summary>
        public Pay.CurrencyEnum Currency { get; set; }
        /// <summary>
        /// Details regarding the payment
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Comma separated accepted card types
        /// </summary>
        public List<Pay.ValidCardTypesEnum> ValidCardTypes { get; set; }
        /// <summary>
        /// Language to use
        /// </summary>
        public Pay.LanguageEnum Language { get; set; }

        /// <summary>
        /// Create a new Pay
        /// </summary>
        /// <param name="input"> Input type Twilio should accept </param>
        /// <param name="action"> Action URL </param>
        /// <param name="statusCallback"> Status callback URL </param>
        /// <param name="statusCallbackMethod"> Status callback method </param>
        /// <param name="timeout"> Time to wait to gather input </param>
        /// <param name="maxAttempts"> Maximum number of allowed retries when gathering input </param>
        /// <param name="securityCode"> Prompt for security code </param>
        /// <param name="postalCode"> Prompt for postal code and it should be true/false or default postal code </param>
        /// <param name="paymentConnector"> Unique name for payment connector </param>
        /// <param name="tokenType"> Type of token </param>
        /// <param name="chargeAmount"> Amount to process. If value is greater than 0 then make the payment else create a
        ///                    payment token </param>
        /// <param name="currency"> Currency of the amount attribute </param>
        /// <param name="description"> Details regarding the payment </param>
        /// <param name="validCardTypes"> Comma separated accepted card types </param>
        /// <param name="language"> Language to use </param>
        public Pay(Pay.InputEnum input = null, 
                   Uri action = null, 
                   Uri statusCallback = null, 
                   Pay.StatusCallbackMethodEnum statusCallbackMethod = null, 
                   int? timeout = null, 
                   int? maxAttempts = null, 
                   bool? securityCode = null, 
                   string postalCode = null, 
                   string paymentConnector = null, 
                   Pay.TokenTypeEnum tokenType = null, 
                   string chargeAmount = null, 
                   Pay.CurrencyEnum currency = null, 
                   string description = null, 
                   List<Pay.ValidCardTypesEnum> validCardTypes = null, 
                   Pay.LanguageEnum language = null) : base("Pay")
        {
            this.Input = input;
            this.Action = action;
            this.StatusCallback = statusCallback;
            this.StatusCallbackMethod = statusCallbackMethod;
            this.Timeout = timeout;
            this.MaxAttempts = maxAttempts;
            this.SecurityCode = securityCode;
            this.PostalCode = postalCode;
            this.PaymentConnector = paymentConnector;
            this.TokenType = tokenType;
            this.ChargeAmount = chargeAmount;
            this.Currency = currency;
            this.Description = description;
            this.ValidCardTypes = validCardTypes;
            this.Language = language;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Input != null)
            {
                attributes.Add(new XAttribute("input", this.Input.ToString()));
            }
            if (this.Action != null)
            {
                attributes.Add(new XAttribute("action", Serializers.Url(this.Action)));
            }
            if (this.StatusCallback != null)
            {
                attributes.Add(new XAttribute("statusCallback", Serializers.Url(this.StatusCallback)));
            }
            if (this.StatusCallbackMethod != null)
            {
                attributes.Add(new XAttribute("statusCallbackMethod", this.StatusCallbackMethod.ToString()));
            }
            if (this.Timeout != null)
            {
                attributes.Add(new XAttribute("timeout", this.Timeout.ToString()));
            }
            if (this.MaxAttempts != null)
            {
                attributes.Add(new XAttribute("maxAttempts", this.MaxAttempts.ToString()));
            }
            if (this.SecurityCode != null)
            {
                attributes.Add(new XAttribute("securityCode", this.SecurityCode.Value.ToString().ToLower()));
            }
            if (this.PostalCode != null)
            {
                attributes.Add(new XAttribute("postalCode", this.PostalCode));
            }
            if (this.PaymentConnector != null)
            {
                attributes.Add(new XAttribute("paymentConnector", this.PaymentConnector));
            }
            if (this.TokenType != null)
            {
                attributes.Add(new XAttribute("tokenType", this.TokenType.ToString()));
            }
            if (this.ChargeAmount != null)
            {
                attributes.Add(new XAttribute("chargeAmount", this.ChargeAmount));
            }
            if (this.Currency != null)
            {
                attributes.Add(new XAttribute("currency", this.Currency.ToString()));
            }
            if (this.Description != null)
            {
                attributes.Add(new XAttribute("description", this.Description));
            }
            if (this.ValidCardTypes != null)
            {
                attributes.Add(new XAttribute("validCardTypes", String.Join(" ", this.ValidCardTypes.Select(e => e.ToString()).ToArray())));
            }
            if (this.Language != null)
            {
                attributes.Add(new XAttribute("language", this.Language.ToString()));
            }
            return attributes;
        }

        /// <summary>
        /// Append a <Prompt/> element as a child of this element
        /// </summary>
        /// <param name="prompt"> A Prompt instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Pay Prompt(Prompt prompt)
        {
            this.Append(prompt);
            return this;
        }

        /// <summary>
        /// Create a new <Prompt/> element and append it as a child of this element.
        /// </summary>
        /// <param name="for_"> Name of the credit card data element </param>
        /// <param name="errorType"> Type of error </param>
        /// <param name="cardType"> Type of the credit card </param>
        /// <param name="attempt"> Current attempt count </param>
        public Pay Prompt(Prompt.ForEnum for_ = null, 
                          List<Prompt.ErrorTypeEnum> errorType = null, 
                          List<Prompt.CardTypeEnum> cardType = null, 
                          List<int> attempt = null)
        {
            var newChild = new Prompt(for_, errorType, cardType, attempt);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Pay Append(TwiML childElem)
        {
            return (Pay) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Pay SetOption(string key, object value)
        {
            return (Pay) base.SetOption(key, value);
        }
    }

}