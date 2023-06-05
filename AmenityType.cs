using System.ComponentModel;

namespace nitutz
{

    public enum AmenityType
    {

        [Description(" Video Camera")]
        VideoCamera,
        SmartTV,
        [Description("Microphone/Speaker")]
        MicrophoneOrSpeaker,
        HDMI,
        WiFi

    }
}