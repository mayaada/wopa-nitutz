using System.ComponentModel;

namespace WOPA
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