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

namespace UserModule_1GSQ_HVAC_URL_V2_0
{
    public class UserModuleClass_1GSQ_HVAC_URL_V2_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.StringInput INPUTCONSTANT;
        Crestron.Logos.SplusObjects.StringInput INPUT01;
        Crestron.Logos.SplusObjects.StringOutput COMBINED01;
        object INPUT01_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 10;
                COMBINED01  .UpdateValue ( INPUTCONSTANT + INPUT01  ) ; 
                
                
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
            
            __context__.SourceCodeLine = 21;
            WaitForInitializationComplete ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        INPUTCONSTANT = new Crestron.Logos.SplusObjects.StringInput( INPUTCONSTANT__AnalogSerialInput__, 200, this );
        m_StringInputList.Add( INPUTCONSTANT__AnalogSerialInput__, INPUTCONSTANT );
        
        INPUT01 = new Crestron.Logos.SplusObjects.StringInput( INPUT01__AnalogSerialInput__, 200, this );
        m_StringInputList.Add( INPUT01__AnalogSerialInput__, INPUT01 );
        
        COMBINED01 = new Crestron.Logos.SplusObjects.StringOutput( COMBINED01__AnalogSerialOutput__, this );
        m_StringOutputList.Add( COMBINED01__AnalogSerialOutput__, COMBINED01 );
        
        
        INPUT01.OnSerialChange.Add( new InputChangeHandlerWrapper( INPUT01_OnChange_0, true ) );
        INPUTCONSTANT.OnSerialChange.Add( new InputChangeHandlerWrapper( INPUT01_OnChange_0, true ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_1GSQ_HVAC_URL_V2_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint INPUTCONSTANT__AnalogSerialInput__ = 0;
    const uint INPUT01__AnalogSerialInput__ = 1;
    const uint COMBINED01__AnalogSerialOutput__ = 0;
    
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
