using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_GSQ_APT_PICKER_V1_1
{
    public class UserModuleClass_GSQ_APT_PICKER_V1_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput SENDAPTINFO;
        Crestron.Logos.SplusObjects.AnalogOutput APTNUMBER__POUND__;
        Crestron.Logos.SplusObjects.StringOutput APTTYPE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput APTLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput APTNUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput APTNAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HVAC_URL__DOLLAR__;
        UShortParameter APARTMENT;
        object SENDAPTINFO_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 91;
                APTNUMBER__POUND__  .Value = (ushort) ( APARTMENT  .Value ) ; 
                __context__.SourceCodeLine = 94;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 94;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 01") ; 
                    __context__.SourceCodeLine = 94;
                    MakeString ( APTLEVEL__DOLLAR__ , "Town House") ; 
                    __context__.SourceCodeLine = 94;
                    MakeString ( APTNUMBER__DOLLAR__ , "1") ; 
                    __context__.SourceCodeLine = 94;
                    MakeString ( APTNAME__DOLLAR__ , "TH1") ; 
                    __context__.SourceCodeLine = 94;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.1.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 95;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 95;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 02") ; 
                    __context__.SourceCodeLine = 95;
                    MakeString ( APTLEVEL__DOLLAR__ , "Town House") ; 
                    __context__.SourceCodeLine = 95;
                    MakeString ( APTNUMBER__DOLLAR__ , "2") ; 
                    __context__.SourceCodeLine = 95;
                    MakeString ( APTNAME__DOLLAR__ , "TH2") ; 
                    __context__.SourceCodeLine = 95;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.2.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 96;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 3))  ) ) 
                    { 
                    __context__.SourceCodeLine = 96;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 03") ; 
                    __context__.SourceCodeLine = 96;
                    MakeString ( APTLEVEL__DOLLAR__ , "Town House") ; 
                    __context__.SourceCodeLine = 96;
                    MakeString ( APTNUMBER__DOLLAR__ , "3") ; 
                    __context__.SourceCodeLine = 96;
                    MakeString ( APTNAME__DOLLAR__ , "TH3") ; 
                    __context__.SourceCodeLine = 96;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.3.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 97;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 4))  ) ) 
                    { 
                    __context__.SourceCodeLine = 97;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 08") ; 
                    __context__.SourceCodeLine = 97;
                    MakeString ( APTLEVEL__DOLLAR__ , "Duplex") ; 
                    __context__.SourceCodeLine = 97;
                    MakeString ( APTNUMBER__DOLLAR__ , "4") ; 
                    __context__.SourceCodeLine = 97;
                    MakeString ( APTNAME__DOLLAR__ , "Duplex4") ; 
                    __context__.SourceCodeLine = 97;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.4.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 98;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 5))  ) ) 
                    { 
                    __context__.SourceCodeLine = 98;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 09") ; 
                    __context__.SourceCodeLine = 98;
                    MakeString ( APTLEVEL__DOLLAR__ , "Duplex") ; 
                    __context__.SourceCodeLine = 98;
                    MakeString ( APTNUMBER__DOLLAR__ , "5") ; 
                    __context__.SourceCodeLine = 98;
                    MakeString ( APTNAME__DOLLAR__ , "Duplex5") ; 
                    __context__.SourceCodeLine = 98;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.5.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 99;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 6))  ) ) 
                    { 
                    __context__.SourceCodeLine = 99;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 04") ; 
                    __context__.SourceCodeLine = 99;
                    MakeString ( APTLEVEL__DOLLAR__ , "Studio") ; 
                    __context__.SourceCodeLine = 99;
                    MakeString ( APTNUMBER__DOLLAR__ , "6") ; 
                    __context__.SourceCodeLine = 99;
                    MakeString ( APTNAME__DOLLAR__ , "Studio1") ; 
                    __context__.SourceCodeLine = 99;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.6.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 100;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 7))  ) ) 
                    { 
                    __context__.SourceCodeLine = 100;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 05") ; 
                    __context__.SourceCodeLine = 100;
                    MakeString ( APTLEVEL__DOLLAR__ , "Studio") ; 
                    __context__.SourceCodeLine = 100;
                    MakeString ( APTNUMBER__DOLLAR__ , "7") ; 
                    __context__.SourceCodeLine = 100;
                    MakeString ( APTNAME__DOLLAR__ , "Studio2") ; 
                    __context__.SourceCodeLine = 100;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.7.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 101;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 8))  ) ) 
                    { 
                    __context__.SourceCodeLine = 101;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 06") ; 
                    __context__.SourceCodeLine = 101;
                    MakeString ( APTLEVEL__DOLLAR__ , "Studio") ; 
                    __context__.SourceCodeLine = 101;
                    MakeString ( APTNUMBER__DOLLAR__ , "8") ; 
                    __context__.SourceCodeLine = 101;
                    MakeString ( APTNAME__DOLLAR__ , "Studio3") ; 
                    __context__.SourceCodeLine = 101;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.8.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 102;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 9))  ) ) 
                    { 
                    __context__.SourceCodeLine = 102;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 07") ; 
                    __context__.SourceCodeLine = 102;
                    MakeString ( APTLEVEL__DOLLAR__ , "Studio") ; 
                    __context__.SourceCodeLine = 102;
                    MakeString ( APTNUMBER__DOLLAR__ , "9") ; 
                    __context__.SourceCodeLine = 102;
                    MakeString ( APTNAME__DOLLAR__ , "Studio4") ; 
                    __context__.SourceCodeLine = 102;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.9.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 103;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 10))  ) ) 
                    { 
                    __context__.SourceCodeLine = 103;
                    MakeString ( APTTYPE__DOLLAR__ , "Grey Box") ; 
                    __context__.SourceCodeLine = 103;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 01") ; 
                    __context__.SourceCodeLine = 103;
                    MakeString ( APTNUMBER__DOLLAR__ , "10") ; 
                    __context__.SourceCodeLine = 103;
                    MakeString ( APTNAME__DOLLAR__ , "APT1-2") ; 
                    __context__.SourceCodeLine = 103;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.10.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 104;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 11))  ) ) 
                    { 
                    __context__.SourceCodeLine = 104;
                    MakeString ( APTTYPE__DOLLAR__ , "Grey Box") ; 
                    __context__.SourceCodeLine = 104;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 01") ; 
                    __context__.SourceCodeLine = 104;
                    MakeString ( APTNUMBER__DOLLAR__ , "11") ; 
                    __context__.SourceCodeLine = 104;
                    MakeString ( APTNAME__DOLLAR__ , "APT1-3") ; 
                    __context__.SourceCodeLine = 104;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.11.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 105;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 12))  ) ) 
                    { 
                    __context__.SourceCodeLine = 105;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 12") ; 
                    __context__.SourceCodeLine = 105;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 01") ; 
                    __context__.SourceCodeLine = 105;
                    MakeString ( APTNUMBER__DOLLAR__ , "12") ; 
                    __context__.SourceCodeLine = 105;
                    MakeString ( APTNAME__DOLLAR__ , "APT1-4") ; 
                    __context__.SourceCodeLine = 105;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.12.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 106;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 13))  ) ) 
                    { 
                    __context__.SourceCodeLine = 106;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 13") ; 
                    __context__.SourceCodeLine = 106;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 01") ; 
                    __context__.SourceCodeLine = 106;
                    MakeString ( APTNUMBER__DOLLAR__ , "13") ; 
                    __context__.SourceCodeLine = 106;
                    MakeString ( APTNAME__DOLLAR__ , "APT1-5") ; 
                    __context__.SourceCodeLine = 106;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.13.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 107;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 14))  ) ) 
                    { 
                    __context__.SourceCodeLine = 107;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 14") ; 
                    __context__.SourceCodeLine = 107;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 01") ; 
                    __context__.SourceCodeLine = 107;
                    MakeString ( APTNUMBER__DOLLAR__ , "14") ; 
                    __context__.SourceCodeLine = 107;
                    MakeString ( APTNAME__DOLLAR__ , "APT1-6") ; 
                    __context__.SourceCodeLine = 107;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.14.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 108;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 15))  ) ) 
                    { 
                    __context__.SourceCodeLine = 108;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 15") ; 
                    __context__.SourceCodeLine = 108;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 01") ; 
                    __context__.SourceCodeLine = 108;
                    MakeString ( APTNUMBER__DOLLAR__ , "15") ; 
                    __context__.SourceCodeLine = 108;
                    MakeString ( APTNAME__DOLLAR__ , "APT1-7") ; 
                    __context__.SourceCodeLine = 108;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.15.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 109;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 16))  ) ) 
                    { 
                    __context__.SourceCodeLine = 109;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 10") ; 
                    __context__.SourceCodeLine = 109;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 02") ; 
                    __context__.SourceCodeLine = 109;
                    MakeString ( APTNUMBER__DOLLAR__ , "16") ; 
                    __context__.SourceCodeLine = 109;
                    MakeString ( APTNAME__DOLLAR__ , "APT2-1") ; 
                    __context__.SourceCodeLine = 109;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.16.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 110;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 17))  ) ) 
                    { 
                    __context__.SourceCodeLine = 110;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 29") ; 
                    __context__.SourceCodeLine = 110;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 02") ; 
                    __context__.SourceCodeLine = 110;
                    MakeString ( APTNUMBER__DOLLAR__ , "17") ; 
                    __context__.SourceCodeLine = 110;
                    MakeString ( APTNAME__DOLLAR__ , "APT2-2") ; 
                    __context__.SourceCodeLine = 110;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.17.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 111;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 18))  ) ) 
                    { 
                    __context__.SourceCodeLine = 111;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 16") ; 
                    __context__.SourceCodeLine = 111;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 02") ; 
                    __context__.SourceCodeLine = 111;
                    MakeString ( APTNUMBER__DOLLAR__ , "18") ; 
                    __context__.SourceCodeLine = 111;
                    MakeString ( APTNAME__DOLLAR__ , "APT2-3") ; 
                    __context__.SourceCodeLine = 111;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.18.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 112;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 19))  ) ) 
                    { 
                    __context__.SourceCodeLine = 112;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 17") ; 
                    __context__.SourceCodeLine = 112;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 02") ; 
                    __context__.SourceCodeLine = 112;
                    MakeString ( APTNUMBER__DOLLAR__ , "19") ; 
                    __context__.SourceCodeLine = 112;
                    MakeString ( APTNAME__DOLLAR__ , "APT2-4") ; 
                    __context__.SourceCodeLine = 112;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.19.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 113;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 20))  ) ) 
                    { 
                    __context__.SourceCodeLine = 113;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 13") ; 
                    __context__.SourceCodeLine = 113;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 02") ; 
                    __context__.SourceCodeLine = 113;
                    MakeString ( APTNUMBER__DOLLAR__ , "20") ; 
                    __context__.SourceCodeLine = 113;
                    MakeString ( APTNAME__DOLLAR__ , "APT2-5") ; 
                    __context__.SourceCodeLine = 113;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.20.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 114;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 21))  ) ) 
                    { 
                    __context__.SourceCodeLine = 114;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 14") ; 
                    __context__.SourceCodeLine = 114;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 02") ; 
                    __context__.SourceCodeLine = 114;
                    MakeString ( APTNUMBER__DOLLAR__ , "21") ; 
                    __context__.SourceCodeLine = 114;
                    MakeString ( APTNAME__DOLLAR__ , "APT2-6") ; 
                    __context__.SourceCodeLine = 114;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.21.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 115;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 22))  ) ) 
                    { 
                    __context__.SourceCodeLine = 115;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 15") ; 
                    __context__.SourceCodeLine = 115;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 02") ; 
                    __context__.SourceCodeLine = 115;
                    MakeString ( APTNUMBER__DOLLAR__ , "22") ; 
                    __context__.SourceCodeLine = 115;
                    MakeString ( APTNAME__DOLLAR__ , "APT2-7") ; 
                    __context__.SourceCodeLine = 115;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.22.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 116;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 23))  ) ) 
                    { 
                    __context__.SourceCodeLine = 116;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 10") ; 
                    __context__.SourceCodeLine = 116;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 03") ; 
                    __context__.SourceCodeLine = 116;
                    MakeString ( APTNUMBER__DOLLAR__ , "23") ; 
                    __context__.SourceCodeLine = 116;
                    MakeString ( APTNAME__DOLLAR__ , "APT3-1") ; 
                    __context__.SourceCodeLine = 116;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.23.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 117;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 24))  ) ) 
                    { 
                    __context__.SourceCodeLine = 117;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 29") ; 
                    __context__.SourceCodeLine = 117;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 03") ; 
                    __context__.SourceCodeLine = 117;
                    MakeString ( APTNUMBER__DOLLAR__ , "24") ; 
                    __context__.SourceCodeLine = 117;
                    MakeString ( APTNAME__DOLLAR__ , "APT3-2") ; 
                    __context__.SourceCodeLine = 117;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.24.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 118;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 25))  ) ) 
                    { 
                    __context__.SourceCodeLine = 118;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 16") ; 
                    __context__.SourceCodeLine = 118;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 03") ; 
                    __context__.SourceCodeLine = 118;
                    MakeString ( APTNUMBER__DOLLAR__ , "25") ; 
                    __context__.SourceCodeLine = 118;
                    MakeString ( APTNAME__DOLLAR__ , "APT3-3") ; 
                    __context__.SourceCodeLine = 118;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.25.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 119;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 26))  ) ) 
                    { 
                    __context__.SourceCodeLine = 119;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 17") ; 
                    __context__.SourceCodeLine = 119;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 03") ; 
                    __context__.SourceCodeLine = 119;
                    MakeString ( APTNUMBER__DOLLAR__ , "26") ; 
                    __context__.SourceCodeLine = 119;
                    MakeString ( APTNAME__DOLLAR__ , "APT3-4") ; 
                    __context__.SourceCodeLine = 119;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.26.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 120;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 27))  ) ) 
                    { 
                    __context__.SourceCodeLine = 120;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 13") ; 
                    __context__.SourceCodeLine = 120;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 03") ; 
                    __context__.SourceCodeLine = 120;
                    MakeString ( APTNUMBER__DOLLAR__ , "27") ; 
                    __context__.SourceCodeLine = 120;
                    MakeString ( APTNAME__DOLLAR__ , "APT3-5") ; 
                    __context__.SourceCodeLine = 120;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.27.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 121;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 28))  ) ) 
                    { 
                    __context__.SourceCodeLine = 121;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 14") ; 
                    __context__.SourceCodeLine = 121;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 03") ; 
                    __context__.SourceCodeLine = 121;
                    MakeString ( APTNUMBER__DOLLAR__ , "28") ; 
                    __context__.SourceCodeLine = 121;
                    MakeString ( APTNAME__DOLLAR__ , "APT3-6") ; 
                    __context__.SourceCodeLine = 121;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.28.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 122;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 29))  ) ) 
                    { 
                    __context__.SourceCodeLine = 122;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 30") ; 
                    __context__.SourceCodeLine = 122;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 03") ; 
                    __context__.SourceCodeLine = 122;
                    MakeString ( APTNUMBER__DOLLAR__ , "29") ; 
                    __context__.SourceCodeLine = 122;
                    MakeString ( APTNAME__DOLLAR__ , "APT3-7") ; 
                    __context__.SourceCodeLine = 122;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.29.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 123;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 30))  ) ) 
                    { 
                    __context__.SourceCodeLine = 123;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 31") ; 
                    __context__.SourceCodeLine = 123;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 03") ; 
                    __context__.SourceCodeLine = 123;
                    MakeString ( APTNUMBER__DOLLAR__ , "30") ; 
                    __context__.SourceCodeLine = 123;
                    MakeString ( APTNAME__DOLLAR__ , "APT3-8") ; 
                    __context__.SourceCodeLine = 123;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.30.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 124;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 31))  ) ) 
                    { 
                    __context__.SourceCodeLine = 124;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 10") ; 
                    __context__.SourceCodeLine = 124;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 04") ; 
                    __context__.SourceCodeLine = 124;
                    MakeString ( APTNUMBER__DOLLAR__ , "31") ; 
                    __context__.SourceCodeLine = 124;
                    MakeString ( APTNAME__DOLLAR__ , "APT4-1") ; 
                    __context__.SourceCodeLine = 124;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.31.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 125;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 32))  ) ) 
                    { 
                    __context__.SourceCodeLine = 125;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 29") ; 
                    __context__.SourceCodeLine = 125;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 04") ; 
                    __context__.SourceCodeLine = 125;
                    MakeString ( APTNUMBER__DOLLAR__ , "32") ; 
                    __context__.SourceCodeLine = 125;
                    MakeString ( APTNAME__DOLLAR__ , "APT4-2") ; 
                    __context__.SourceCodeLine = 125;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.32.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 126;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 33))  ) ) 
                    { 
                    __context__.SourceCodeLine = 126;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 16") ; 
                    __context__.SourceCodeLine = 126;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 04") ; 
                    __context__.SourceCodeLine = 126;
                    MakeString ( APTNUMBER__DOLLAR__ , "33") ; 
                    __context__.SourceCodeLine = 126;
                    MakeString ( APTNAME__DOLLAR__ , "APT4-3") ; 
                    __context__.SourceCodeLine = 126;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.33.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 127;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 34))  ) ) 
                    { 
                    __context__.SourceCodeLine = 127;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 17") ; 
                    __context__.SourceCodeLine = 127;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 04") ; 
                    __context__.SourceCodeLine = 127;
                    MakeString ( APTNUMBER__DOLLAR__ , "34") ; 
                    __context__.SourceCodeLine = 127;
                    MakeString ( APTNAME__DOLLAR__ , "APT4-4") ; 
                    __context__.SourceCodeLine = 127;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.34.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 128;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 35))  ) ) 
                    { 
                    __context__.SourceCodeLine = 128;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 13") ; 
                    __context__.SourceCodeLine = 128;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 04") ; 
                    __context__.SourceCodeLine = 128;
                    MakeString ( APTNUMBER__DOLLAR__ , "35") ; 
                    __context__.SourceCodeLine = 128;
                    MakeString ( APTNAME__DOLLAR__ , "APT4-5") ; 
                    __context__.SourceCodeLine = 128;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.35.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 129;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 36))  ) ) 
                    { 
                    __context__.SourceCodeLine = 129;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 14") ; 
                    __context__.SourceCodeLine = 129;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 04") ; 
                    __context__.SourceCodeLine = 129;
                    MakeString ( APTNUMBER__DOLLAR__ , "36") ; 
                    __context__.SourceCodeLine = 129;
                    MakeString ( APTNAME__DOLLAR__ , "APT4-6") ; 
                    __context__.SourceCodeLine = 129;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.36.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 130;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 37))  ) ) 
                    { 
                    __context__.SourceCodeLine = 130;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 28") ; 
                    __context__.SourceCodeLine = 130;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 04") ; 
                    __context__.SourceCodeLine = 130;
                    MakeString ( APTNUMBER__DOLLAR__ , "37") ; 
                    __context__.SourceCodeLine = 130;
                    MakeString ( APTNAME__DOLLAR__ , "APT4-7") ; 
                    __context__.SourceCodeLine = 130;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.37.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 131;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 38))  ) ) 
                    { 
                    __context__.SourceCodeLine = 131;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 18") ; 
                    __context__.SourceCodeLine = 131;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 05") ; 
                    __context__.SourceCodeLine = 131;
                    MakeString ( APTNUMBER__DOLLAR__ , "38") ; 
                    __context__.SourceCodeLine = 131;
                    MakeString ( APTNAME__DOLLAR__ , "APT5-1") ; 
                    __context__.SourceCodeLine = 131;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.38.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 132;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 39))  ) ) 
                    { 
                    __context__.SourceCodeLine = 132;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 19") ; 
                    __context__.SourceCodeLine = 132;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 05") ; 
                    __context__.SourceCodeLine = 132;
                    MakeString ( APTNUMBER__DOLLAR__ , "39") ; 
                    __context__.SourceCodeLine = 132;
                    MakeString ( APTNAME__DOLLAR__ , "APT5-2") ; 
                    __context__.SourceCodeLine = 132;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.39.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 133;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 40))  ) ) 
                    { 
                    __context__.SourceCodeLine = 133;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 20") ; 
                    __context__.SourceCodeLine = 133;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 05") ; 
                    __context__.SourceCodeLine = 133;
                    MakeString ( APTNUMBER__DOLLAR__ , "40") ; 
                    __context__.SourceCodeLine = 133;
                    MakeString ( APTNAME__DOLLAR__ , "APT5-3") ; 
                    __context__.SourceCodeLine = 133;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.40.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 134;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 41))  ) ) 
                    { 
                    __context__.SourceCodeLine = 134;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 21") ; 
                    __context__.SourceCodeLine = 134;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 05") ; 
                    __context__.SourceCodeLine = 134;
                    MakeString ( APTNUMBER__DOLLAR__ , "41") ; 
                    __context__.SourceCodeLine = 134;
                    MakeString ( APTNAME__DOLLAR__ , "APT5-4") ; 
                    __context__.SourceCodeLine = 134;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.41.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 135;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 42))  ) ) 
                    { 
                    __context__.SourceCodeLine = 135;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 22") ; 
                    __context__.SourceCodeLine = 135;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 05") ; 
                    __context__.SourceCodeLine = 135;
                    MakeString ( APTNUMBER__DOLLAR__ , "42") ; 
                    __context__.SourceCodeLine = 135;
                    MakeString ( APTNAME__DOLLAR__ , "APT5-5") ; 
                    __context__.SourceCodeLine = 135;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.42.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 136;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 43))  ) ) 
                    { 
                    __context__.SourceCodeLine = 136;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 23") ; 
                    __context__.SourceCodeLine = 136;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 06") ; 
                    __context__.SourceCodeLine = 136;
                    MakeString ( APTNUMBER__DOLLAR__ , "43") ; 
                    __context__.SourceCodeLine = 136;
                    MakeString ( APTNAME__DOLLAR__ , "APT6-1") ; 
                    __context__.SourceCodeLine = 136;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.43.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 137;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 44))  ) ) 
                    { 
                    __context__.SourceCodeLine = 137;
                    MakeString ( APTTYPE__DOLLAR__ , "Grey Box") ; 
                    __context__.SourceCodeLine = 137;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 06") ; 
                    __context__.SourceCodeLine = 137;
                    MakeString ( APTNUMBER__DOLLAR__ , "44") ; 
                    __context__.SourceCodeLine = 137;
                    MakeString ( APTNAME__DOLLAR__ , "APT6-2") ; 
                    __context__.SourceCodeLine = 137;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.44.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 138;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 45))  ) ) 
                    { 
                    __context__.SourceCodeLine = 138;
                    MakeString ( APTTYPE__DOLLAR__ , "Grey Box") ; 
                    __context__.SourceCodeLine = 138;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 06") ; 
                    __context__.SourceCodeLine = 138;
                    MakeString ( APTNUMBER__DOLLAR__ , "45") ; 
                    __context__.SourceCodeLine = 138;
                    MakeString ( APTNAME__DOLLAR__ , "APT6-3") ; 
                    __context__.SourceCodeLine = 138;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.45.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 139;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 46))  ) ) 
                    { 
                    __context__.SourceCodeLine = 139;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 26") ; 
                    __context__.SourceCodeLine = 139;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 06") ; 
                    __context__.SourceCodeLine = 139;
                    MakeString ( APTNUMBER__DOLLAR__ , "46") ; 
                    __context__.SourceCodeLine = 139;
                    MakeString ( APTNAME__DOLLAR__ , "APT6-4") ; 
                    __context__.SourceCodeLine = 139;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.46.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 140;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 47))  ) ) 
                    { 
                    __context__.SourceCodeLine = 140;
                    MakeString ( APTTYPE__DOLLAR__ , "Type 22") ; 
                    __context__.SourceCodeLine = 140;
                    MakeString ( APTLEVEL__DOLLAR__ , "Level 06") ; 
                    __context__.SourceCodeLine = 140;
                    MakeString ( APTNUMBER__DOLLAR__ , "47") ; 
                    __context__.SourceCodeLine = 140;
                    MakeString ( APTNAME__DOLLAR__ , "APT6-5") ; 
                    __context__.SourceCodeLine = 140;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.47.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 141;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 48))  ) ) 
                    { 
                    __context__.SourceCodeLine = 141;
                    MakeString ( APTTYPE__DOLLAR__ , "Grey Box") ; 
                    __context__.SourceCodeLine = 141;
                    MakeString ( APTLEVEL__DOLLAR__ , "Penthouse") ; 
                    __context__.SourceCodeLine = 141;
                    MakeString ( APTNUMBER__DOLLAR__ , "48") ; 
                    __context__.SourceCodeLine = 141;
                    MakeString ( APTNAME__DOLLAR__ , "PH") ; 
                    __context__.SourceCodeLine = 141;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://10.1.48.15:8080") ; 
                    } 
                
                __context__.SourceCodeLine = 142;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .Value == 999))  ) ) 
                    { 
                    __context__.SourceCodeLine = 142;
                    MakeString ( APTTYPE__DOLLAR__ , "Debug-AptType") ; 
                    __context__.SourceCodeLine = 142;
                    MakeString ( APTLEVEL__DOLLAR__ , "Debug-Level") ; 
                    __context__.SourceCodeLine = 142;
                    MakeString ( APTNUMBER__DOLLAR__ , "999") ; 
                    __context__.SourceCodeLine = 142;
                    MakeString ( APTNAME__DOLLAR__ , "DD099") ; 
                    __context__.SourceCodeLine = 142;
                    MakeString ( HVAC_URL__DOLLAR__ , "http://192.168.0.15/setup") ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    public override object FunctionMain (  object __obj__ ) 
        { 
        try
        {
            SplusExecutionContext __context__ = SplusFunctionMainStartCode();
            
            __context__.SourceCodeLine = 148;
            WaitForInitializationComplete ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        SENDAPTINFO = new Crestron.Logos.SplusObjects.DigitalInput( SENDAPTINFO__DigitalInput__, this );
        m_DigitalInputList.Add( SENDAPTINFO__DigitalInput__, SENDAPTINFO );
        
        APTNUMBER__POUND__ = new Crestron.Logos.SplusObjects.AnalogOutput( APTNUMBER__POUND____AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( APTNUMBER__POUND____AnalogSerialOutput__, APTNUMBER__POUND__ );
        
        APTTYPE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( APTTYPE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( APTTYPE__DOLLAR____AnalogSerialOutput__, APTTYPE__DOLLAR__ );
        
        APTLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( APTLEVEL__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( APTLEVEL__DOLLAR____AnalogSerialOutput__, APTLEVEL__DOLLAR__ );
        
        APTNUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( APTNUMBER__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( APTNUMBER__DOLLAR____AnalogSerialOutput__, APTNUMBER__DOLLAR__ );
        
        APTNAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( APTNAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( APTNAME__DOLLAR____AnalogSerialOutput__, APTNAME__DOLLAR__ );
        
        HVAC_URL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HVAC_URL__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( HVAC_URL__DOLLAR____AnalogSerialOutput__, HVAC_URL__DOLLAR__ );
        
        APARTMENT = new UShortParameter( APARTMENT__Parameter__, this );
        m_ParameterList.Add( APARTMENT__Parameter__, APARTMENT );
        
        
        SENDAPTINFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( SENDAPTINFO_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_GSQ_APT_PICKER_V1_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SENDAPTINFO__DigitalInput__ = 0;
    const uint APTNUMBER__POUND____AnalogSerialOutput__ = 0;
    const uint APTTYPE__DOLLAR____AnalogSerialOutput__ = 1;
    const uint APTLEVEL__DOLLAR____AnalogSerialOutput__ = 2;
    const uint APTNUMBER__DOLLAR____AnalogSerialOutput__ = 3;
    const uint APTNAME__DOLLAR____AnalogSerialOutput__ = 4;
    const uint HVAC_URL__DOLLAR____AnalogSerialOutput__ = 5;
    const uint APARTMENT__Parameter__ = 10;
    
    [SplusStructAttribute(-1, true, false)]
    public class SplusNVRAM : SplusStructureBase
    {
    
        public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
        
        
    }
    
    SplusNVRAM _SplusNVRAM = null;
    
    public class __CEvent__ : CEvent
    {
        public __CEvent__() {}
        public void Close() { base.Close(); }
        public int Reset() { return base.Reset() ? 1 : 0; }
        public int Set() { return base.Set() ? 1 : 0; }
        public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
    }
    public class __CMutex__ : CMutex
    {
        public __CMutex__() {}
        public void Close() { base.Close(); }
        public void ReleaseMutex() { base.ReleaseMutex(); }
        public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
    }
     public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
