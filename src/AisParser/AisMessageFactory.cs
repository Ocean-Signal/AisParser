using AisParser.Messages;

namespace AisParser
{
    public class AisMessageFactory
    {
        public AisMessage Create(Payload payload)
        {
            switch (payload.MessageType)
            {
                case AisMessageType.PositionReportClassA:
                    return new PositionReportClassAMessage(payload);
                case AisMessageType.PositionReportClassAAssignedSchedule:
                    return new PositionReportClassAAssignedScheduleMessage(payload);
                case AisMessageType.PositionReportClassAResponseToInterrogation:
                    return new PositionReportClassAResponseToInterrogationMessage(payload);
                case AisMessageType.BaseStationReport:
                    return new BaseStationReportMessage(payload);
                case AisMessageType.StaticAndVoyageRelatedData:
                    return new StaticAndVoyageRelatedDataMessage(payload);
                //TODO: case AisMessageType.BinaryAddressedMessage:
                //TODO: case AisMessageType.BinaryAcknowledge:
                case AisMessageType.BinaryBroadcastMessage:
                    return new BinaryBroadcastMessage(payload);
                case AisMessageType.StandardSarAircraftPositionReport:
                    return new StandardSarAircraftPositionReportMessage(payload);
                //TODO: case AisMessageType.UtcAndDateInquiry:
                //TODO: case AisMessageType.UtcAndDateResponse:
                //case AisMessageType.AddressedSafetyRelatedMessage:
                //case AisMessageType.SafetyRelatedAcknowledgement:
                //case AisMessageType.SafetyRelatedBroadcastMessage:
                //TODO: case AisMessageType.Interrogation:
                //case AisMessageType.AssignmentModeCommand:
                //case AisMessageType.DgnssBinaryBroadcastMessage:
                case AisMessageType.StandardClassBCsPositionReport:
                    return new StandardClassBCsPositionReportMessage(payload);
                //case AisMessageType.ExtendedClassBEquipmentPositionReport:
                case AisMessageType.DataLinkManagement:
                    return new DataLinkManagementMessage(payload);
                case AisMessageType.AidToNavigationReport:
                    return new AidToNavigationReportMessage(payload);
                //case AisMessageType.ChannelManagement:
                //case AisMessageType.GroupAssignmentCommand:
                case AisMessageType.StaticDataReport:
                    return StaticDataReportMessage.Create(payload);
                //case AisMessageType.SingleSlotBinaryMessage:
                //case AisMessageType.MultipleSlotBinaryMessageWithCommunicationsState:
                case AisMessageType.PositionReportForLongRangeApplications:
                    return new PositionReportForLongRangeApplicationsMessage(payload);
                //TODO: 30
                //TODO: 31
                //TODO: 32
                //TODO: 40
                //TODO: 47
                //TODO: 51
                //TODO: 57
                default:
                    throw new AisMessageException($"Unrecognised message type: {payload.MessageType}");
            }
        }
    }
}