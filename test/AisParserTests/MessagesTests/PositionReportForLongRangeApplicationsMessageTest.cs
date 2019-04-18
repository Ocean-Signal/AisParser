﻿using AisParser;
using AisParser.Messages;
using Shouldly;
using Xunit;

namespace AisParserTests.MessagesTests
{
    public class PositionReportForLongRangeApplicationsMessageTest : MessageTestBase
    {
        [Fact]
        public void Should_parse_message()
        {
            const string sentence = "!AIVDM,1,1,,B,K77U@48?vMSdNWh@,0*75";
            
            var message = Parser.Parse(sentence) as PositionReportForLongRangeApplicationsMessage;
            message.ShouldNotBeNull();
            message.MessageType.ShouldBe(AisMessageType.PositionReportForLongRangeApplications);
            message.Repeat.ShouldBe(0u);
            message.Mmsi.ShouldBe(477712400u);
            message.PositionAccuracy.ShouldBe(PositionAccuracy.High);
            message.Raim.ShouldBe(Raim.NotInUse);
            message.NavigationStatus.ShouldBe(NavigationStatus.UnderWayUsingEngine);
            message.Longitude.ShouldBe(-0.656666d, 0.000001d);
            message.Latitude.ShouldBe(50.448334d, 0.000001d);
            message.SpeedOverGround.ShouldBe(15.0);
            message.CourseOverGround.ShouldBe(260);
            message.GnssPositionStatus.ShouldBe(GnssPositionStatus.CurrentGnssPosition);
            message.Spare.ShouldBe(0u);
        }
    }
}