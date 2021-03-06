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
using Twilio.Rest.Wireless.V1;

namespace Twilio.Tests.Rest.Wireless.V1
{

    [TestFixture]
    public class SimTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Wireless,
                "/v1/Sims/DEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SimResource.Fetch("DEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"unique_name\",\"commands_callback_method\": \"http_method\",\"commands_callback_url\": \"http://www.example.com\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"friendly_name\": \"friendly_name\",\"sms_fallback_method\": \"http_method\",\"sms_fallback_url\": \"http://www.example.com\",\"sms_method\": \"http_method\",\"sms_url\": \"http://www.example.com\",\"voice_fallback_method\": \"http_method\",\"voice_fallback_url\": \"http://www.example.com\",\"voice_method\": \"http_method\",\"voice_url\": \"http://www.example.com\",\"links\": {\"data_sessions\": \"https://wireless.twilio.com/v1/Sims/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/DataSessions\",\"rate_plan\": \"https://wireless.twilio.com/v1/RatePlans/WPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"usage_records\": \"https://wireless.twilio.com/v1/Sims/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/UsageRecords\"},\"rate_plan_sid\": \"WPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"iccid\": \"iccid\",\"e_id\": \"e_id\",\"status\": \"new\",\"reset_status\": null,\"url\": \"https://wireless.twilio.com/v1/Sims/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"ip_address\": \"192.168.1.1\"}"
                                     ));

            var response = SimResource.Fetch("DEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Wireless,
                "/v1/Sims",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SimResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sims\": [],\"meta\": {\"first_page_url\": \"https://wireless.twilio.com/v1/Sims?PageSize=50&Page=0\",\"key\": \"sims\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://wireless.twilio.com/v1/Sims?PageSize=50&Page=0\"}}"
                                     ));

            var response = SimResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sims\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"unique_name\",\"commands_callback_method\": \"http_method\",\"commands_callback_url\": \"http://www.example.com\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"friendly_name\": \"friendly_name\",\"links\": {\"data_sessions\": \"https://wireless.twilio.com/v1/Sims/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/DataSessions\",\"rate_plan\": \"https://wireless.twilio.com/v1/RatePlans/WPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"usage_records\": \"https://wireless.twilio.com/v1/Sims/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/UsageRecords\"},\"rate_plan_sid\": \"WPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"iccid\": \"iccid\",\"e_id\": \"e_id\",\"status\": \"new\",\"reset_status\": \"resetting\",\"sms_fallback_method\": \"http_method\",\"sms_fallback_url\": \"http://www.example.com\",\"sms_method\": \"http_method\",\"sms_url\": \"http://www.example.com\",\"voice_fallback_method\": \"http_method\",\"voice_fallback_url\": \"http://www.example.com\",\"voice_method\": \"http_method\",\"voice_url\": \"http://www.example.com\",\"url\": \"https://wireless.twilio.com/v1/Sims/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"ip_address\": \"192.168.1.30\"}],\"meta\": {\"first_page_url\": \"https://wireless.twilio.com/v1/Sims?PageSize=50&Page=0\",\"key\": \"sims\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://wireless.twilio.com/v1/Sims?PageSize=50&Page=0\"}}"
                                     ));

            var response = SimResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Wireless,
                "/v1/Sims/DEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SimResource.Update("DEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"unique_name\",\"commands_callback_method\": \"http_method\",\"commands_callback_url\": \"http://www.example.com\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"friendly_name\": \"friendly_name\",\"links\": {\"data_sessions\": \"https://wireless.twilio.com/v1/Sims/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/DataSessions\",\"rate_plan\": \"https://wireless.twilio.com/v1/RatePlans/WPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"usage_records\": \"https://wireless.twilio.com/v1/Sims/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/UsageRecords\"},\"rate_plan_sid\": \"WPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"iccid\": \"iccid\",\"e_id\": \"e_id\",\"status\": \"new\",\"reset_status\": \"resetting\",\"sms_fallback_method\": \"http_method\",\"sms_fallback_url\": \"http://www.example.com\",\"sms_method\": \"http_method\",\"sms_url\": \"http://www.example.com\",\"voice_fallback_method\": \"http_method\",\"voice_fallback_url\": \"http://www.example.com\",\"voice_method\": \"http_method\",\"voice_url\": \"http://www.example.com\",\"url\": \"https://wireless.twilio.com/v1/Sims/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"ip_address\": \"192.168.1.30\"}"
                                     ));

            var response = SimResource.Update("DEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Wireless,
                "/v1/Sims/DEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SimResource.Delete("DEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = SimResource.Delete("DEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}