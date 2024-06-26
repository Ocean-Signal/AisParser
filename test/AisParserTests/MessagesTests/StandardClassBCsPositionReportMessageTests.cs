﻿using AisParser;
using AisParser.Messages;
using Shouldly;
using Xunit;

namespace AisParserTests.MessagesTests
{
    public class StandardClassBCsPositionReportMessageTests : MessageTestBase
    {
        [Fact]
        public void Should_parse_message()
        {
            const string sentence = "!AIVDM,1,1,,B,B5NLCa000>fdwc63f?aBKwPUoP06,0*15";

            var message = Parser.Parse(sentence) as StandardClassBCsPositionReportMessage;
            message.ShouldNotBeNull();
            message.MessageType.ShouldBe(AisMessageType.StandardClassBCsPositionReport);
            message.Repeat.ShouldBe(0u);
            message.Mmsi.ShouldBe(367465380u);
            message.SpeedOverGround.ShouldBe(0u);
            message.PositionAccuracy.ShouldBe(PositionAccuracy.High);
            message.Longitude.ShouldBe(-71.03836333333334d, 0.000001d);
            message.Latitude.ShouldBe(42.34964333333333d, 0.000001d);
            message.CourseOverGround.ShouldBe(131.8);
            message.TrueHeading.ShouldBe(511u);
            message.Timestamp.ShouldBe(1u);
            message.IsCsUnit.ShouldBeTrue();
            message.HasDisplay.ShouldBeFalse();
            message.HasDscCapability.ShouldBeTrue();
            message.Band.ShouldBeTrue();
            message.CanAcceptMessage22.ShouldBeTrue();
            message.Assigned.ShouldBeFalse();
            message.Raim.ShouldBe(Raim.InUse);
            message.RadioStatus.ShouldBe(917510u);
        }
    }
}