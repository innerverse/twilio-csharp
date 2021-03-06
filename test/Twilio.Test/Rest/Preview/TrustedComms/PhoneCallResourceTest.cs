/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Preview.TrustedComms;

namespace Twilio.Tests.Rest.Preview.TrustedComms
{

    [TestFixture]
    public class PhoneCallTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Preview,
                "/TrustedComms/Business/PhoneCalls",
                ""
            );
            request.AddPostParam("From", Serialize("from"));
            request.AddPostParam("To", Serialize("to"));
            request.AddPostParam("Url", Serialize("url"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                PhoneCallResource.Create("from", "to", "url", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"from\": \"+15000000000\",\"to\": \"+573000000000\",\"reason\": \"Hello Jhon, your appointment has been confirmed.\",\"created_at\": \"2019-05-01T20:00:00Z\",\"url\": \"https://preview.twilio.com/TrustedComms/Business/PhoneCalls\"}"
                                     ));

            var response = PhoneCallResource.Create("from", "to", "url", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}