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

namespace UserModule_GSQ_SIP_PANEL_01_V1_4_CF
{
    public class UserModuleClass_GSQ_SIP_PANEL_01_V1_4_CF : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput SYSTEMREADY;
        Crestron.Logos.SplusObjects.AnalogInput APTNUMBER__POUND__;
        Crestron.Logos.SplusObjects.StringOutput USER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput AUTH__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PSW__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIPSRV__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIPPORT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DOMAIN__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput REALM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MODE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput AUTO__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RCONFIG__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DNAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PORT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SRVNAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PAGEGROUP__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PROXYIP__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAMESRV__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput STUNDOM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput STUNIP__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DND__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PANELIP__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIPAUTOMODE__DOLLAR__;
        object SYSTEMREADY_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 34;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 34;
                    MakeString ( USER__DOLLAR__ , "1011") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( AUTH__DOLLAR__ , "1011") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( DNAME__DOLLAR__ , "TH1-1") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( PAGEGROUP__DOLLAR__ , "TH1") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.1.30") ; 
                    __context__.SourceCodeLine = 34;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 35;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 35;
                    MakeString ( USER__DOLLAR__ , "1021") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( AUTH__DOLLAR__ , "1021") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( DNAME__DOLLAR__ , "TH2-1") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( PAGEGROUP__DOLLAR__ , "TH2") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.2.30") ; 
                    __context__.SourceCodeLine = 35;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 36;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 3))  ) ) 
                    { 
                    __context__.SourceCodeLine = 36;
                    MakeString ( USER__DOLLAR__ , "1031") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( AUTH__DOLLAR__ , "1031") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( DNAME__DOLLAR__ , "TH3-1") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( PAGEGROUP__DOLLAR__ , "TH3") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.3.30") ; 
                    __context__.SourceCodeLine = 36;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 37;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 4))  ) ) 
                    { 
                    __context__.SourceCodeLine = 37;
                    MakeString ( USER__DOLLAR__ , "1041") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( AUTH__DOLLAR__ , "1041") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( DNAME__DOLLAR__ , "Duplex4-1") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( PAGEGROUP__DOLLAR__ , "Duplex4") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.4.30") ; 
                    __context__.SourceCodeLine = 37;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 38;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 5))  ) ) 
                    { 
                    __context__.SourceCodeLine = 38;
                    MakeString ( USER__DOLLAR__ , "1051") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( AUTH__DOLLAR__ , "1051") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( DNAME__DOLLAR__ , "Duplex5-1") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( PAGEGROUP__DOLLAR__ , "Duplex5") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.5.30") ; 
                    __context__.SourceCodeLine = 38;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 39;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 6))  ) ) 
                    { 
                    __context__.SourceCodeLine = 39;
                    MakeString ( USER__DOLLAR__ , "1061") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( AUTH__DOLLAR__ , "1061") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( DNAME__DOLLAR__ , "Studio1-1") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( PAGEGROUP__DOLLAR__ , "Studio1") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.6.30") ; 
                    __context__.SourceCodeLine = 39;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 40;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 7))  ) ) 
                    { 
                    __context__.SourceCodeLine = 40;
                    MakeString ( USER__DOLLAR__ , "1071") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( AUTH__DOLLAR__ , "1071") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( DNAME__DOLLAR__ , "Studio2-1") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( PAGEGROUP__DOLLAR__ , "Studio2") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.7.30") ; 
                    __context__.SourceCodeLine = 40;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 41;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 8))  ) ) 
                    { 
                    __context__.SourceCodeLine = 41;
                    MakeString ( USER__DOLLAR__ , "1081") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( AUTH__DOLLAR__ , "1081") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( DNAME__DOLLAR__ , "Studio3-1") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( PAGEGROUP__DOLLAR__ , "Studio3") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.8.30") ; 
                    __context__.SourceCodeLine = 41;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 42;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 9))  ) ) 
                    { 
                    __context__.SourceCodeLine = 42;
                    MakeString ( USER__DOLLAR__ , "1091") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( AUTH__DOLLAR__ , "1091") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( DNAME__DOLLAR__ , "Studio4-1") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( PAGEGROUP__DOLLAR__ , "Studio4") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.9.30") ; 
                    __context__.SourceCodeLine = 42;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 43;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 10))  ) ) 
                    { 
                    __context__.SourceCodeLine = 43;
                    MakeString ( USER__DOLLAR__ , "0") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( AUTH__DOLLAR__ , "0") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( DNAME__DOLLAR__ , "APT1-2-1") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT1-2") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.10.30") ; 
                    __context__.SourceCodeLine = 43;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 44;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 11))  ) ) 
                    { 
                    __context__.SourceCodeLine = 44;
                    MakeString ( USER__DOLLAR__ , "0") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( AUTH__DOLLAR__ , "0") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( DNAME__DOLLAR__ , "APT1-3-1") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT1-3") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.11.30") ; 
                    __context__.SourceCodeLine = 44;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 45;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 12))  ) ) 
                    { 
                    __context__.SourceCodeLine = 45;
                    MakeString ( USER__DOLLAR__ , "1141") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( AUTH__DOLLAR__ , "1141") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( DNAME__DOLLAR__ , "APT1-4-1") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT1-4") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.12.30") ; 
                    __context__.SourceCodeLine = 45;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 46;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 13))  ) ) 
                    { 
                    __context__.SourceCodeLine = 46;
                    MakeString ( USER__DOLLAR__ , "1151") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( AUTH__DOLLAR__ , "1151") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( DNAME__DOLLAR__ , "APT1-5-1") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT1-5") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.13.30") ; 
                    __context__.SourceCodeLine = 46;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 47;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 14))  ) ) 
                    { 
                    __context__.SourceCodeLine = 47;
                    MakeString ( USER__DOLLAR__ , "1161") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( AUTH__DOLLAR__ , "1161") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( DNAME__DOLLAR__ , "APT1-6-1") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT1-6") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.14.30") ; 
                    __context__.SourceCodeLine = 47;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 48;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 15))  ) ) 
                    { 
                    __context__.SourceCodeLine = 48;
                    MakeString ( USER__DOLLAR__ , "1171") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( AUTH__DOLLAR__ , "1171") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( DNAME__DOLLAR__ , "APT1-7-1") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT1-7") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.15.30") ; 
                    __context__.SourceCodeLine = 48;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 49;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 16))  ) ) 
                    { 
                    __context__.SourceCodeLine = 49;
                    MakeString ( USER__DOLLAR__ , "1211") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( AUTH__DOLLAR__ , "1211") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( DNAME__DOLLAR__ , "APT2-1-1") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT2-1") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.16.30") ; 
                    __context__.SourceCodeLine = 49;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 50;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 17))  ) ) 
                    { 
                    __context__.SourceCodeLine = 50;
                    MakeString ( USER__DOLLAR__ , "1221") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( AUTH__DOLLAR__ , "1221") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( DNAME__DOLLAR__ , "APT2-2-1") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT2-2") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.17.30") ; 
                    __context__.SourceCodeLine = 50;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 51;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 18))  ) ) 
                    { 
                    __context__.SourceCodeLine = 51;
                    MakeString ( USER__DOLLAR__ , "1231") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( AUTH__DOLLAR__ , "1231") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( DNAME__DOLLAR__ , "APT2-3-1") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT2-3") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.18.30") ; 
                    __context__.SourceCodeLine = 51;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 52;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 19))  ) ) 
                    { 
                    __context__.SourceCodeLine = 52;
                    MakeString ( USER__DOLLAR__ , "1241") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( AUTH__DOLLAR__ , "1241") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( DNAME__DOLLAR__ , "APT2-4-1") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT2-4") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.19.30") ; 
                    __context__.SourceCodeLine = 52;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 53;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 20))  ) ) 
                    { 
                    __context__.SourceCodeLine = 53;
                    MakeString ( USER__DOLLAR__ , "1251") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( AUTH__DOLLAR__ , "1251") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( DNAME__DOLLAR__ , "APT2-5-1") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT2-5") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.20.30") ; 
                    __context__.SourceCodeLine = 53;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 54;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 21))  ) ) 
                    { 
                    __context__.SourceCodeLine = 54;
                    MakeString ( USER__DOLLAR__ , "1261") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( AUTH__DOLLAR__ , "1261") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( DNAME__DOLLAR__ , "APT2-6-1") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT2-6") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.21.30") ; 
                    __context__.SourceCodeLine = 54;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 55;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 22))  ) ) 
                    { 
                    __context__.SourceCodeLine = 55;
                    MakeString ( USER__DOLLAR__ , "1271") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( AUTH__DOLLAR__ , "1271") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( DNAME__DOLLAR__ , "APT2-7-1") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT2-7") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.22.30") ; 
                    __context__.SourceCodeLine = 55;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 56;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 23))  ) ) 
                    { 
                    __context__.SourceCodeLine = 56;
                    MakeString ( USER__DOLLAR__ , "1311") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( AUTH__DOLLAR__ , "1311") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( DNAME__DOLLAR__ , "APT3-1-1") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT3-1") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.23.30") ; 
                    __context__.SourceCodeLine = 56;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 57;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 24))  ) ) 
                    { 
                    __context__.SourceCodeLine = 57;
                    MakeString ( USER__DOLLAR__ , "1321") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( AUTH__DOLLAR__ , "1321") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( DNAME__DOLLAR__ , "APT3-2-1") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT3-2") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.24.30") ; 
                    __context__.SourceCodeLine = 57;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 58;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 25))  ) ) 
                    { 
                    __context__.SourceCodeLine = 58;
                    MakeString ( USER__DOLLAR__ , "1331") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( AUTH__DOLLAR__ , "1331") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( DNAME__DOLLAR__ , "APT3-3-1") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT3-3") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.25.30") ; 
                    __context__.SourceCodeLine = 58;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 59;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 26))  ) ) 
                    { 
                    __context__.SourceCodeLine = 59;
                    MakeString ( USER__DOLLAR__ , "1341") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( AUTH__DOLLAR__ , "1341") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( DNAME__DOLLAR__ , "APT3-4-1") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT3-4") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.26.30") ; 
                    __context__.SourceCodeLine = 59;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 60;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 27))  ) ) 
                    { 
                    __context__.SourceCodeLine = 60;
                    MakeString ( USER__DOLLAR__ , "1351") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( AUTH__DOLLAR__ , "1351") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( DNAME__DOLLAR__ , "APT3-5-1") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT3-5") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.27.30") ; 
                    __context__.SourceCodeLine = 60;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 61;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 28))  ) ) 
                    { 
                    __context__.SourceCodeLine = 61;
                    MakeString ( USER__DOLLAR__ , "1361") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( AUTH__DOLLAR__ , "1361") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( DNAME__DOLLAR__ , "APT3-6-1") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT3-6") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.28.30") ; 
                    __context__.SourceCodeLine = 61;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 62;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 29))  ) ) 
                    { 
                    __context__.SourceCodeLine = 62;
                    MakeString ( USER__DOLLAR__ , "1371") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( AUTH__DOLLAR__ , "1371") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( DNAME__DOLLAR__ , "APT3-7-1") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT3-7") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.29.30") ; 
                    __context__.SourceCodeLine = 62;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 63;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 30))  ) ) 
                    { 
                    __context__.SourceCodeLine = 63;
                    MakeString ( USER__DOLLAR__ , "1381") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( AUTH__DOLLAR__ , "1381") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( DNAME__DOLLAR__ , "APT3-8-1") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT3-8") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.30.30") ; 
                    __context__.SourceCodeLine = 63;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 64;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 31))  ) ) 
                    { 
                    __context__.SourceCodeLine = 64;
                    MakeString ( USER__DOLLAR__ , "1411") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( AUTH__DOLLAR__ , "1411") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( DNAME__DOLLAR__ , "APT4-1-1") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT4-1") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.31.30") ; 
                    __context__.SourceCodeLine = 64;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 65;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 32))  ) ) 
                    { 
                    __context__.SourceCodeLine = 65;
                    MakeString ( USER__DOLLAR__ , "1421") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( AUTH__DOLLAR__ , "1421") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( DNAME__DOLLAR__ , "APT4-2-1") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT4-2") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.32.30") ; 
                    __context__.SourceCodeLine = 65;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 66;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 33))  ) ) 
                    { 
                    __context__.SourceCodeLine = 66;
                    MakeString ( USER__DOLLAR__ , "1431") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( AUTH__DOLLAR__ , "1431") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( DNAME__DOLLAR__ , "APT4-3-1") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT4-3") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.33.30") ; 
                    __context__.SourceCodeLine = 66;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 67;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 34))  ) ) 
                    { 
                    __context__.SourceCodeLine = 67;
                    MakeString ( USER__DOLLAR__ , "1441") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( AUTH__DOLLAR__ , "1441") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( DNAME__DOLLAR__ , "APT4-4-1") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT4-4") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.34.30") ; 
                    __context__.SourceCodeLine = 67;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 68;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 35))  ) ) 
                    { 
                    __context__.SourceCodeLine = 68;
                    MakeString ( USER__DOLLAR__ , "1451") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( AUTH__DOLLAR__ , "1451") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( DNAME__DOLLAR__ , "APT4-5-1") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT4-5") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.35.30") ; 
                    __context__.SourceCodeLine = 68;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 69;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 36))  ) ) 
                    { 
                    __context__.SourceCodeLine = 69;
                    MakeString ( USER__DOLLAR__ , "1461") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( AUTH__DOLLAR__ , "1461") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( DNAME__DOLLAR__ , "APT4-6-1") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT4-6") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.36.30") ; 
                    __context__.SourceCodeLine = 69;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 70;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 37))  ) ) 
                    { 
                    __context__.SourceCodeLine = 70;
                    MakeString ( USER__DOLLAR__ , "1471") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( AUTH__DOLLAR__ , "1471") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( DNAME__DOLLAR__ , "APT4-7-1") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT4-7") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.37.30") ; 
                    __context__.SourceCodeLine = 70;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 71;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 38))  ) ) 
                    { 
                    __context__.SourceCodeLine = 71;
                    MakeString ( USER__DOLLAR__ , "1511") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( AUTH__DOLLAR__ , "1511") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( DNAME__DOLLAR__ , "APT5-1-1") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT5-1") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.38.30") ; 
                    __context__.SourceCodeLine = 71;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 72;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 39))  ) ) 
                    { 
                    __context__.SourceCodeLine = 72;
                    MakeString ( USER__DOLLAR__ , "1521") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( AUTH__DOLLAR__ , "1521") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( DNAME__DOLLAR__ , "APT5-2-1") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT5-2") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.39.30") ; 
                    __context__.SourceCodeLine = 72;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 73;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 40))  ) ) 
                    { 
                    __context__.SourceCodeLine = 73;
                    MakeString ( USER__DOLLAR__ , "1531") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( AUTH__DOLLAR__ , "1531") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( DNAME__DOLLAR__ , "APT5-3-1") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT5-3") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.40.30") ; 
                    __context__.SourceCodeLine = 73;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 74;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 41))  ) ) 
                    { 
                    __context__.SourceCodeLine = 74;
                    MakeString ( USER__DOLLAR__ , "1541") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( AUTH__DOLLAR__ , "1541") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( DNAME__DOLLAR__ , "APT5-4-1") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT5-4") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.41.30") ; 
                    __context__.SourceCodeLine = 74;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 75;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 42))  ) ) 
                    { 
                    __context__.SourceCodeLine = 75;
                    MakeString ( USER__DOLLAR__ , "1551") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( AUTH__DOLLAR__ , "1551") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( DNAME__DOLLAR__ , "APT5-5-1") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT5-5") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.42.30") ; 
                    __context__.SourceCodeLine = 75;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 76;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 43))  ) ) 
                    { 
                    __context__.SourceCodeLine = 76;
                    MakeString ( USER__DOLLAR__ , "0") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( AUTH__DOLLAR__ , "0") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( DNAME__DOLLAR__ , "APT6-1-1") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT6-1") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.43.30") ; 
                    __context__.SourceCodeLine = 76;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 77;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 44))  ) ) 
                    { 
                    __context__.SourceCodeLine = 77;
                    MakeString ( USER__DOLLAR__ , "0") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( AUTH__DOLLAR__ , "0") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( DNAME__DOLLAR__ , "APT6-2-1") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT6-2") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.44.30") ; 
                    __context__.SourceCodeLine = 77;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 78;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 45))  ) ) 
                    { 
                    __context__.SourceCodeLine = 78;
                    MakeString ( USER__DOLLAR__ , "0") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( AUTH__DOLLAR__ , "0") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( DNAME__DOLLAR__ , "APT6-3-1") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT6-3") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.45.30") ; 
                    __context__.SourceCodeLine = 78;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 79;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 46))  ) ) 
                    { 
                    __context__.SourceCodeLine = 79;
                    MakeString ( USER__DOLLAR__ , "1641") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( AUTH__DOLLAR__ , "1641") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( DNAME__DOLLAR__ , "APT6-4-1") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT6-4") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.46.30") ; 
                    __context__.SourceCodeLine = 79;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 80;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 47))  ) ) 
                    { 
                    __context__.SourceCodeLine = 80;
                    MakeString ( USER__DOLLAR__ , "1651") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( AUTH__DOLLAR__ , "1651") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( DNAME__DOLLAR__ , "APT6-5-1") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( PAGEGROUP__DOLLAR__ , "APT6-5") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.47.30") ; 
                    __context__.SourceCodeLine = 80;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 81;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 48))  ) ) 
                    { 
                    __context__.SourceCodeLine = 81;
                    MakeString ( USER__DOLLAR__ , "1711") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( AUTH__DOLLAR__ , "1711") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( DNAME__DOLLAR__ , "PH-1") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( PAGEGROUP__DOLLAR__ , "PH") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( PANELIP__DOLLAR__ , "10.1.48.30") ; 
                    __context__.SourceCodeLine = 81;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
                    } 
                
                __context__.SourceCodeLine = 82;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (APTNUMBER__POUND__  .UshortValue == 999))  ) ) 
                    { 
                    __context__.SourceCodeLine = 82;
                    MakeString ( USER__DOLLAR__ , "120100999") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( AUTH__DOLLAR__ , "120100999") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( PSW__DOLLAR__ , "DIR01") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( SIPSRV__DOLLAR__ , "10.2.112.2") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( SIPPORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( DOMAIN__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( REALM__DOLLAR__ , "*") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( MODE__DOLLAR__ , "SERVER") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( AUTO__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( RCONFIG__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( DNAME__DOLLAR__ , "DD099-1") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( PORT__DOLLAR__ , "5060") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( SRVNAME__DOLLAR__ , "GSSECDIR01") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( PAGEGROUP__DOLLAR__ , "DD099") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( PROXYIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( NAMESRV__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( STUNDOM__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( STUNIP__DOLLAR__ , "NONE") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( DND__DOLLAR__ , "YES") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( PANELIP__DOLLAR__ , "192.168.0.30") ; 
                    __context__.SourceCodeLine = 82;
                    MakeString ( SIPAUTOMODE__DOLLAR__ , "NONE") ; 
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
            
            __context__.SourceCodeLine = 87;
            WaitForInitializationComplete ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        SYSTEMREADY = new Crestron.Logos.SplusObjects.DigitalInput( SYSTEMREADY__DigitalInput__, this );
        m_DigitalInputList.Add( SYSTEMREADY__DigitalInput__, SYSTEMREADY );
        
        APTNUMBER__POUND__ = new Crestron.Logos.SplusObjects.AnalogInput( APTNUMBER__POUND____AnalogSerialInput__, this );
        m_AnalogInputList.Add( APTNUMBER__POUND____AnalogSerialInput__, APTNUMBER__POUND__ );
        
        USER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USER__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( USER__DOLLAR____AnalogSerialOutput__, USER__DOLLAR__ );
        
        AUTH__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AUTH__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( AUTH__DOLLAR____AnalogSerialOutput__, AUTH__DOLLAR__ );
        
        PSW__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PSW__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( PSW__DOLLAR____AnalogSerialOutput__, PSW__DOLLAR__ );
        
        SIPSRV__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIPSRV__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SIPSRV__DOLLAR____AnalogSerialOutput__, SIPSRV__DOLLAR__ );
        
        SIPPORT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIPPORT__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SIPPORT__DOLLAR____AnalogSerialOutput__, SIPPORT__DOLLAR__ );
        
        DOMAIN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DOMAIN__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( DOMAIN__DOLLAR____AnalogSerialOutput__, DOMAIN__DOLLAR__ );
        
        REALM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( REALM__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( REALM__DOLLAR____AnalogSerialOutput__, REALM__DOLLAR__ );
        
        MODE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MODE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( MODE__DOLLAR____AnalogSerialOutput__, MODE__DOLLAR__ );
        
        AUTO__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AUTO__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( AUTO__DOLLAR____AnalogSerialOutput__, AUTO__DOLLAR__ );
        
        RCONFIG__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RCONFIG__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( RCONFIG__DOLLAR____AnalogSerialOutput__, RCONFIG__DOLLAR__ );
        
        DNAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DNAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( DNAME__DOLLAR____AnalogSerialOutput__, DNAME__DOLLAR__ );
        
        PORT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PORT__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( PORT__DOLLAR____AnalogSerialOutput__, PORT__DOLLAR__ );
        
        SRVNAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SRVNAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SRVNAME__DOLLAR____AnalogSerialOutput__, SRVNAME__DOLLAR__ );
        
        PAGEGROUP__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PAGEGROUP__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( PAGEGROUP__DOLLAR____AnalogSerialOutput__, PAGEGROUP__DOLLAR__ );
        
        PROXYIP__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PROXYIP__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( PROXYIP__DOLLAR____AnalogSerialOutput__, PROXYIP__DOLLAR__ );
        
        NAMESRV__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAMESRV__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( NAMESRV__DOLLAR____AnalogSerialOutput__, NAMESRV__DOLLAR__ );
        
        STUNDOM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( STUNDOM__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( STUNDOM__DOLLAR____AnalogSerialOutput__, STUNDOM__DOLLAR__ );
        
        STUNIP__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( STUNIP__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( STUNIP__DOLLAR____AnalogSerialOutput__, STUNIP__DOLLAR__ );
        
        DND__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DND__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( DND__DOLLAR____AnalogSerialOutput__, DND__DOLLAR__ );
        
        PANELIP__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PANELIP__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( PANELIP__DOLLAR____AnalogSerialOutput__, PANELIP__DOLLAR__ );
        
        SIPAUTOMODE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIPAUTOMODE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SIPAUTOMODE__DOLLAR____AnalogSerialOutput__, SIPAUTOMODE__DOLLAR__ );
        
        
        SYSTEMREADY.OnDigitalPush.Add( new InputChangeHandlerWrapper( SYSTEMREADY_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_GSQ_SIP_PANEL_01_V1_4_CF ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SYSTEMREADY__DigitalInput__ = 0;
    const uint APTNUMBER__POUND____AnalogSerialInput__ = 0;
    const uint USER__DOLLAR____AnalogSerialOutput__ = 0;
    const uint AUTH__DOLLAR____AnalogSerialOutput__ = 1;
    const uint PSW__DOLLAR____AnalogSerialOutput__ = 2;
    const uint SIPSRV__DOLLAR____AnalogSerialOutput__ = 3;
    const uint SIPPORT__DOLLAR____AnalogSerialOutput__ = 4;
    const uint DOMAIN__DOLLAR____AnalogSerialOutput__ = 5;
    const uint REALM__DOLLAR____AnalogSerialOutput__ = 6;
    const uint MODE__DOLLAR____AnalogSerialOutput__ = 7;
    const uint AUTO__DOLLAR____AnalogSerialOutput__ = 8;
    const uint RCONFIG__DOLLAR____AnalogSerialOutput__ = 9;
    const uint DNAME__DOLLAR____AnalogSerialOutput__ = 10;
    const uint PORT__DOLLAR____AnalogSerialOutput__ = 11;
    const uint SRVNAME__DOLLAR____AnalogSerialOutput__ = 12;
    const uint PAGEGROUP__DOLLAR____AnalogSerialOutput__ = 13;
    const uint PROXYIP__DOLLAR____AnalogSerialOutput__ = 14;
    const uint NAMESRV__DOLLAR____AnalogSerialOutput__ = 15;
    const uint STUNDOM__DOLLAR____AnalogSerialOutput__ = 16;
    const uint STUNIP__DOLLAR____AnalogSerialOutput__ = 17;
    const uint DND__DOLLAR____AnalogSerialOutput__ = 18;
    const uint PANELIP__DOLLAR____AnalogSerialOutput__ = 19;
    const uint SIPAUTOMODE__DOLLAR____AnalogSerialOutput__ = 20;
    
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
