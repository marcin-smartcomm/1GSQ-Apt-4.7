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

namespace UserModule_SIP_MAKE_STRING_V1_3
{
    public class UserModuleClass_SIP_MAKE_STRING_V1_3 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput SIPMAKE;
        Crestron.Logos.SplusObjects.StringInput USER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput AUTH__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput PSW__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SIPSRV__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SIPPORT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput DOMAIN__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput REALM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput MODE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput AUTO__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput RCONFIG__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput DNAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput PORT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SRVNAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput PAGEGROUP__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput PROXYIP__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput NAMESRV__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput STUNDOM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput STUNIP__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput DND__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput APTNAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SIPAUTOMODE;
        Crestron.Logos.SplusObjects.DigitalOutput SIPSETUPINPROGRESS_FB;
        Crestron.Logos.SplusObjects.StringOutput SIPINT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIPTELNET__DOLLAR__;
        object SIPMAKE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 39;
                SIPSETUPINPROGRESS_FB  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 40;
                Functions.Delay (  (int) ( 500 ) ) ; 
                __context__.SourceCodeLine = 43;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPMODE " + MODE__DOLLAR__ + "\r\n"  ) ; 
                __context__.SourceCodeLine = 44;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 47;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPLOCALPORT " + SIPPORT__DOLLAR__ + "\r\n"  ) ; 
                __context__.SourceCodeLine = 48;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 51;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPSRVREALM " + REALM__DOLLAR__ + "\r\n"  ) ; 
                __context__.SourceCodeLine = 52;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 55;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPREMOTECONFIG " + RCONFIG__DOLLAR__ + "\r\n"  ) ; 
                __context__.SourceCodeLine = 56;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 59;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPAUDIOMODE FD\r\n"  ) ; 
                __context__.SourceCodeLine = 60;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 63;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPAUDIOMODE RFC2833 ON\r\n"  ) ; 
                __context__.SourceCodeLine = 64;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 67;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPSRVUSER " + USER__DOLLAR__ + "\r\n"  ) ; 
                __context__.SourceCodeLine = 68;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 70;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPSRVPASS " + PSW__DOLLAR__ + "\r\n"  ) ; 
                __context__.SourceCodeLine = 71;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 73;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPLOCALEXT " + USER__DOLLAR__ + "\r\n"  ) ; 
                __context__.SourceCodeLine = 74;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 76;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPAUTOMODE " + SIPAUTOMODE + "\r\n"  ) ; 
                __context__.SourceCodeLine = 77;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 79;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPLOCALNAME " + DNAME__DOLLAR__ + "\r\n"  ) ; 
                __context__.SourceCodeLine = 80;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 82;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPSRVNAME " + SRVNAME__DOLLAR__ + "\r\n"  ) ; 
                __context__.SourceCodeLine = 83;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 85;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPPAGEGROUP " + PAGEGROUP__DOLLAR__ + "\r\n"  ) ; 
                __context__.SourceCodeLine = 86;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 88;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPPROXYSRV " + PROXYIP__DOLLAR__ + "\r\n"  ) ; 
                __context__.SourceCodeLine = 89;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 91;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPNAMESRV " + NAMESRV__DOLLAR__ + "\r\n"  ) ; 
                __context__.SourceCodeLine = 92;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 94;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPSTUNDOMAIN " + STUNDOM__DOLLAR__ + "\r\n"  ) ; 
                __context__.SourceCodeLine = 95;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 97;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPSTUNSRV " + STUNIP__DOLLAR__ + "\r\n"  ) ; 
                __context__.SourceCodeLine = 98;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 100;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPSRVIPADDRESS " + SIPSRV__DOLLAR__ + "\r\n"  ) ; 
                __context__.SourceCodeLine = 101;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 110;
                SIPTELNET__DOLLAR__  .UpdateValue ( "MEDIAVOLUME 100%\r\n"  ) ; 
                __context__.SourceCodeLine = 111;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 113;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPDEFAULTRING AUTO\r\n"  ) ; 
                __context__.SourceCodeLine = 114;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 116;
                SIPTELNET__DOLLAR__  .UpdateValue ( "MASTERSTATE ON\r\n"  ) ; 
                __context__.SourceCodeLine = 117;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 119;
                SIPTELNET__DOLLAR__  .UpdateValue ( "MEDIAMUTE OFF\r\n"  ) ; 
                __context__.SourceCodeLine = 120;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 122;
                SIPTELNET__DOLLAR__  .UpdateValue ( "MASTERVOL 100%\r\n"  ) ; 
                __context__.SourceCodeLine = 123;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 125;
                SIPTELNET__DOLLAR__  .UpdateValue ( "AUTIME 01:00\r\n"  ) ; 
                __context__.SourceCodeLine = 126;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 128;
                SIPTELNET__DOLLAR__  .UpdateValue ( "STBYTO 5\r\n"  ) ; 
                __context__.SourceCodeLine = 129;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 131;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SYSMSG ON\r\n"  ) ; 
                __context__.SourceCodeLine = 132;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 134;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SCREENSAVER DISABLE\r\n"  ) ; 
                __context__.SourceCodeLine = 135;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 137;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPENABLE ON\r\n"  ) ; 
                __context__.SourceCodeLine = 138;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 140;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPVIDEO ON\r\n"  ) ; 
                __context__.SourceCodeLine = 141;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 143;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPEARLYMEDIA AUTO\r\n"  ) ; 
                __context__.SourceCodeLine = 144;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 146;
                SIPTELNET__DOLLAR__  .UpdateValue ( "AUENABLE ON\r\n"  ) ; 
                __context__.SourceCodeLine = 147;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 149;
                SIPTELNET__DOLLAR__  .UpdateValue ( "MICSTATE ON\r\n"  ) ; 
                __context__.SourceCodeLine = 150;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 152;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPRESTART\r\n"  ) ; 
                __context__.SourceCodeLine = 153;
                Functions.Delay (  (int) ( 500 ) ) ; 
                __context__.SourceCodeLine = 155;
                SIPTELNET__DOLLAR__  .UpdateValue ( "SIPINFO\r\n"  ) ; 
                __context__.SourceCodeLine = 156;
                Functions.Delay (  (int) ( 500 ) ) ; 
                __context__.SourceCodeLine = 159;
                SIPSETUPINPROGRESS_FB  .Value = (ushort) ( 0 ) ; 
                
                
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
            
            __context__.SourceCodeLine = 165;
            WaitForInitializationComplete ( ) ; 
            __context__.SourceCodeLine = 166;
            SIPSETUPINPROGRESS_FB  .Value = (ushort) ( 0 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        SIPMAKE = new Crestron.Logos.SplusObjects.DigitalInput( SIPMAKE__DigitalInput__, this );
        m_DigitalInputList.Add( SIPMAKE__DigitalInput__, SIPMAKE );
        
        SIPSETUPINPROGRESS_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SIPSETUPINPROGRESS_FB__DigitalOutput__, this );
        m_DigitalOutputList.Add( SIPSETUPINPROGRESS_FB__DigitalOutput__, SIPSETUPINPROGRESS_FB );
        
        USER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( USER__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( USER__DOLLAR____AnalogSerialInput__, USER__DOLLAR__ );
        
        AUTH__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( AUTH__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( AUTH__DOLLAR____AnalogSerialInput__, AUTH__DOLLAR__ );
        
        PSW__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( PSW__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( PSW__DOLLAR____AnalogSerialInput__, PSW__DOLLAR__ );
        
        SIPSRV__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SIPSRV__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( SIPSRV__DOLLAR____AnalogSerialInput__, SIPSRV__DOLLAR__ );
        
        SIPPORT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SIPPORT__DOLLAR____AnalogSerialInput__, 10, this );
        m_StringInputList.Add( SIPPORT__DOLLAR____AnalogSerialInput__, SIPPORT__DOLLAR__ );
        
        DOMAIN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DOMAIN__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( DOMAIN__DOLLAR____AnalogSerialInput__, DOMAIN__DOLLAR__ );
        
        REALM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( REALM__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( REALM__DOLLAR____AnalogSerialInput__, REALM__DOLLAR__ );
        
        MODE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( MODE__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( MODE__DOLLAR____AnalogSerialInput__, MODE__DOLLAR__ );
        
        AUTO__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( AUTO__DOLLAR____AnalogSerialInput__, 10, this );
        m_StringInputList.Add( AUTO__DOLLAR____AnalogSerialInput__, AUTO__DOLLAR__ );
        
        RCONFIG__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( RCONFIG__DOLLAR____AnalogSerialInput__, 500, this );
        m_StringInputList.Add( RCONFIG__DOLLAR____AnalogSerialInput__, RCONFIG__DOLLAR__ );
        
        DNAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DNAME__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( DNAME__DOLLAR____AnalogSerialInput__, DNAME__DOLLAR__ );
        
        PORT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( PORT__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( PORT__DOLLAR____AnalogSerialInput__, PORT__DOLLAR__ );
        
        SRVNAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SRVNAME__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( SRVNAME__DOLLAR____AnalogSerialInput__, SRVNAME__DOLLAR__ );
        
        PAGEGROUP__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( PAGEGROUP__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( PAGEGROUP__DOLLAR____AnalogSerialInput__, PAGEGROUP__DOLLAR__ );
        
        PROXYIP__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( PROXYIP__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( PROXYIP__DOLLAR____AnalogSerialInput__, PROXYIP__DOLLAR__ );
        
        NAMESRV__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( NAMESRV__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( NAMESRV__DOLLAR____AnalogSerialInput__, NAMESRV__DOLLAR__ );
        
        STUNDOM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( STUNDOM__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( STUNDOM__DOLLAR____AnalogSerialInput__, STUNDOM__DOLLAR__ );
        
        STUNIP__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( STUNIP__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( STUNIP__DOLLAR____AnalogSerialInput__, STUNIP__DOLLAR__ );
        
        DND__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DND__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( DND__DOLLAR____AnalogSerialInput__, DND__DOLLAR__ );
        
        APTNAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( APTNAME__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( APTNAME__DOLLAR____AnalogSerialInput__, APTNAME__DOLLAR__ );
        
        SIPAUTOMODE = new Crestron.Logos.SplusObjects.StringInput( SIPAUTOMODE__AnalogSerialInput__, 50, this );
        m_StringInputList.Add( SIPAUTOMODE__AnalogSerialInput__, SIPAUTOMODE );
        
        SIPINT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIPINT__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SIPINT__DOLLAR____AnalogSerialOutput__, SIPINT__DOLLAR__ );
        
        SIPTELNET__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIPTELNET__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SIPTELNET__DOLLAR____AnalogSerialOutput__, SIPTELNET__DOLLAR__ );
        
        
        SIPMAKE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SIPMAKE_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_SIP_MAKE_STRING_V1_3 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SIPMAKE__DigitalInput__ = 0;
    const uint USER__DOLLAR____AnalogSerialInput__ = 0;
    const uint AUTH__DOLLAR____AnalogSerialInput__ = 1;
    const uint PSW__DOLLAR____AnalogSerialInput__ = 2;
    const uint SIPSRV__DOLLAR____AnalogSerialInput__ = 3;
    const uint SIPPORT__DOLLAR____AnalogSerialInput__ = 4;
    const uint DOMAIN__DOLLAR____AnalogSerialInput__ = 5;
    const uint REALM__DOLLAR____AnalogSerialInput__ = 6;
    const uint MODE__DOLLAR____AnalogSerialInput__ = 7;
    const uint AUTO__DOLLAR____AnalogSerialInput__ = 8;
    const uint RCONFIG__DOLLAR____AnalogSerialInput__ = 9;
    const uint DNAME__DOLLAR____AnalogSerialInput__ = 10;
    const uint PORT__DOLLAR____AnalogSerialInput__ = 11;
    const uint SRVNAME__DOLLAR____AnalogSerialInput__ = 12;
    const uint PAGEGROUP__DOLLAR____AnalogSerialInput__ = 13;
    const uint PROXYIP__DOLLAR____AnalogSerialInput__ = 14;
    const uint NAMESRV__DOLLAR____AnalogSerialInput__ = 15;
    const uint STUNDOM__DOLLAR____AnalogSerialInput__ = 16;
    const uint STUNIP__DOLLAR____AnalogSerialInput__ = 17;
    const uint DND__DOLLAR____AnalogSerialInput__ = 18;
    const uint APTNAME__DOLLAR____AnalogSerialInput__ = 19;
    const uint SIPAUTOMODE__AnalogSerialInput__ = 20;
    const uint SIPSETUPINPROGRESS_FB__DigitalOutput__ = 0;
    const uint SIPINT__DOLLAR____AnalogSerialOutput__ = 0;
    const uint SIPTELNET__DOLLAR____AnalogSerialOutput__ = 1;
    
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
